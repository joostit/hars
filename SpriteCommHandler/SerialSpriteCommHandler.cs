using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using BrrrBayBay.HARs;

namespace BrrrBayBay.SpriteCommHandler
{
	/// <summary>
	/// Handles 
	/// </summary>
	public class SerialSpriteCommHandler
	{

		/// <summary>
		/// Set this to enable or disable dataLogging
		/// </summary>
		public Boolean EnableDataLogging {get;set;}

		/// <summary>
		/// Holds the current DisplayString
		/// </summary>
		public String DefaultDisplayString { get; private set; }

		/// <summary>
		/// Carriage return ASCII character
		/// </summary>
		private const char CR = (char) 0x0D;

		/// <summary>
		/// NewLine ASCII character
		/// </summary>
		private const char NL = (char)0x0A;

		/// <summary>
		/// Locking object for writing data to the SpriteController
		/// </summary>
		private Object writeLock = new object();

		/// <summary>
		/// The RX buffer
		/// </summary>
		List<char> rxBuffer = new List<char>();

		/// <summary>
		/// Gets or sets the BaudRate. Changes must be made before connecting.
		/// </summary>
		public int BaudRate { get; set; }

		/// <summary>
		/// Gets or sets the PortName (e.g. COM1). Changes must be made before connecting.
		/// </summary>
		public String PortName { get; set; }

		/// <summary>
		/// Gets or sets the number of Stopbits. Changes must be made before connecting.
		/// </summary>
		public StopBits StopBits { get; set; }

		/// <summary>
		/// Gets or sets the Parity. Changes must be made before connecting.
		/// </summary>
		public Parity Parity { get; set; }

		/// <summary>
		/// Gets or sets the number of databits. Changes must be made before connecting.
		/// </summary>
		public int DataBits { get; set; }

		/// <summary>
		/// The thread that runs the serial port listener
		/// </summary>
		private Thread rxThread;

		/// <summary>
		/// Serial port used to communicate with the device
		/// </summary>
		private SerialPort serialConn;

		/// <summary>
		/// Indicates if the last char was a carriage return
		/// </summary>
		private Boolean lastByteWasCr;

		/// <summary>
		/// Indicates if the RX thread must continue to run
		/// </summary>
		private Boolean rxThreadMustRun = true;

		/// <summary>
		/// CarriageRetuturn/NewLine pair
		/// </summary>
		private char[] terminatorString = new char[] { CR, NL };

		/// <summary>
		/// Indicates if valid data is being received. (Started with a $ character)
		/// </summary>
		private Boolean RxInProgress = false;

		/// <summary>
		/// Gets raised when the StartRace ack has been received
		/// </summary>
		public event EventHandler RaceStartedAck;

		/// <summary>
		/// Gets raised when the end race ack has been received
		/// </summary>
		public event EventHandler RaceEndedAck;

		/// <summary>
		/// Indicates that the race has started.
		/// </summary>
		public event EventHandler RaceStarted;

		/// <summary>
		/// Gets raised when a track has finished
		/// </summary>
		public event TrackFinishedEventHandler TrackFinished;

		/// <summary>
		/// an Ack has been received for the controller reset command
		/// </summary>
		public event EventHandler ControllerResetAck;

		/// <summary>
		/// Gets raised when Display Ack received
		/// </summary>
		public event EventHandler DisplayAckReceived;

		/// <summary>
		/// Gets raised when the race results have been received
		/// </summary>
		public event RaceResultsReceivedEventHandler RaceResultsReceived;

		/// <summary>
		/// Gets raised when the controller software is finished booting.
		/// </summary>
		public event EventHandler SpriteControllerReady;

		/// <summary>
		/// An error has been received
		/// </summary>
		public event ErrorReceivedEventHandler ErrorReceived;

		/// <summary>
		/// Gets raised when a debug message was received
		/// </summary>
		public event DebugMessageReceivedEventHandler DebugMessageReceived;

		/// <summary>
		/// Constructor
		/// </summary>
		public SerialSpriteCommHandler()
		{
			DefaultDisplayString = "87654321";
			EnableDataLogging = true;

			// Defaults
			Parity = Parity.None;
			StopBits = StopBits.One;
			BaudRate = 9600;
			DataBits = 8;
			PortName = "COM4";
		}


		/// <summary>
		/// Opens the connection en starts listening. Throws an exception if anything goes wrong.
		/// </summary>
		public void connect()
		{
			// First open the serial port
			serialConn = new SerialPort(PortName, BaudRate, Parity, DataBits, StopBits);
			serialConn.Open();
			serialConn.ReadTimeout = 100;

			// Then start a listener thread
			rxThread = new Thread(new ThreadStart(listenerThreadmethod));
			rxThread.Name = "SerialPortlistener";
			rxThread.IsBackground = true;
			rxThread.Start();

			if (EnableDataLogging)
			{
				FileWriter.logSerialData("\n\nNew Connection: " + DateTime.Now.ToLongTimeString(), false);
			}

		}

		private Boolean writeCommandToDevice(String cmd)
		{
			if (serialConn.IsOpen)
			{
				try
				{
					lock (writeLock)
					{
						if (EnableDataLogging)
						{
							FileWriter.logSerialData(cmd, false);
						}
						serialConn.Write(cmd);
						serialConn.Write(terminatorString, 0, 2);
  						return true;
					}
				}
				catch
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// Starts the race by sending $S
		/// </summary>
		/// <returns>true when no error occured</returns>
		public Boolean startRace()
		{
			return writeCommandToDevice("$S");
		}

		/// <summary>
		/// Resets the SpriteController
		/// </summary>
		/// <returns>true when no error occured</returns>
		public Boolean resetController()
		{
			return writeCommandToDevice("$R");
		}

		public Boolean setDisplayString(String display)
		{
			return writeCommandToDevice("$D " + display);
		}

		/// <summary>
		/// Ends a race by sending $F and requests all scores
		/// </summary>
		/// <returns>true when no error occured</returns>
		public Boolean endRace()
		{
			return writeCommandToDevice("$F");
		}


		/// <summary>
		/// Requests the race results
		/// </summary>
		/// <returns>true when no error occured</returns>
		public Boolean requestRaceResults()
		{
			return writeCommandToDevice("$M");
		}

		/// <summary>
		/// Method that runs the serial port listener on a new thread
		/// </summary>
		private void listenerThreadmethod()
		{
			int batchSize = 8;
			char[] tempRx;
			int nRead = 0;

			try
			{
				while (rxThreadMustRun)
				{
					tempRx = new char[batchSize];

					try
					{
						nRead = serialConn.Read(tempRx, 0, batchSize);
					}
					catch (TimeoutException)
					{
						// Timeout exception is to be expected here. 
					}

					if (nRead != 0)
					{
						for (int i = 0; i < nRead; i++)
						{
							// If we're not RX'ing, check if we may start.
							if (RxInProgress == false)
							{
								if (tempRx[i] == '$')
								{
									RxInProgress = true;
								}
							}
							if (RxInProgress)
							{

								switch (tempRx[i])
								{
									case CR:

										break;

									case NL:
										if (lastByteWasCr)		// if a CR/NL pair was received
										{
											//Do something with the received message
											completeMessageReceived();

											// clear the rx buffer
											RxInProgress = false;
											rxBuffer = new List<char>();
											lastByteWasCr = false;
										}
										break;

									default:

										rxBuffer.Add(tempRx[i]);
										break;
								}
							}
							lastByteWasCr = (tempRx[i] == CR);
						}
					}
					Thread.Sleep(100);
				}
			}
			catch (ThreadAbortException)
			{
				// Thread interrupted
			}
			catch (ThreadInterruptedException)
			{
				// Thread aborted
			}
		}


		/// <summary>
		/// Gets called when a complete message has been received
		/// </summary>
		private void completeMessageReceived()
		{
			String msg = "";
			for (int i = 0; i < rxBuffer.Count; i++)
			{
				msg = msg + new String(rxBuffer[i], 1);
			}

			if (EnableDataLogging)
			{
				FileWriter.logSerialData(msg, true);
			}

			determineMessageType(msg);
		}



		private void determineMessageType(String msg)
		{
			if (msg[0] == '$')		// Standard command
			{
				String typeString = msg.Substring(0, 2);

				switch (typeString)
				{
					case "$r":	// Reset ack
						if (ControllerResetAck != null)
						{
							ControllerResetAck(this, new EventArgs());
						}
						break;

					case "$s":	// start ack
						if (RaceStartedAck != null)
						{
							RaceStartedAck(this, new EventArgs());
						}
						break;

					case "$f":	// finsish ack (Race ended)
						if (RaceEndedAck != null)
						{
							RaceEndedAck(this, new EventArgs());
						}
						break;

					case "$m":	// Race result times ack. (With trailing results)
						parseAndDispatchTrackTimes(msg);
						break;

					case "$B":	// unsollicited race startted message
						if (RaceStarted != null)
						{
							RaceStarted(this, new EventArgs());
						}
						break;

					case "$o":	// Peripherals set ack
						// ToDo: Implement
						break;

					case "$d":	// Display ack
						if (DisplayAckReceived != null)
						{
							DisplayAckReceived(this, new EventArgs());
						}
						break;

					case "$G":	// track finished (With trailing track number)
						parseAndDispatchesTrackFinished(msg);
						break;

					case "$I":	// Boot success
						if (SpriteControllerReady != null)
						{
							SpriteControllerReady(this, new EventArgs());
						}
						break;

					case "$E":	// Error with trailing trackNumber and description.
							parseAndDispatchIncomingError(msg);
							break;

					case "$x":	// Error with trailing trackNumber and description.
							parseDebugMessage(msg);
							break;

					default:
						unknownMessageReceived(msg);
						break;

				}
			}
			else
			{
				unknownMessageReceived(msg);
			}

		}


		/// <summary>
		/// Send debug commando with identifier
		/// </summary>
		/// <param name="i">The debug identifier</param>
		public void sendDebugVal(int i)
		{
			writeCommandToDevice("$X " + i.ToString());
		}


		/// <summary>
		/// Parses and dispatches the incoming track times.
		/// </summary>
		/// <param name="msg">The message</param>
		private void parseAndDispatchTrackTimes(String msg)
		{
			// TrackId as key, time as value
			Dictionary<int, int> results = new Dictionary<int, int>();
			String valString = "";
			String[] parts = msg.Split(' ');

			try
			{
				for (int i = 1; i < 9; i++)
				{
					valString = parts[i];
					results.Add(i, Convert.ToInt32(valString));
				}
			}
			catch
			{
				throw new Exception("Error[parsing race results");
			}
			

			if (RaceResultsReceived != null)
			{
				RaceResultsReceived(this, new RaceResultsReceivedEventArgs(results));
			}
		}


		private void unknownMessageReceived(String msg)
		{
			//: ToDO Implement
		}


		/// <summary>
		/// Parses and dispatches the messag that a track has finished
		/// </summary>
		/// <param name="msg">The message</param>
		private void parseAndDispatchesTrackFinished(String msg)
		{
			int trackID = 0;

			String[] parts = msg.Split(' ');

			trackID = Convert.ToInt32(parts[1]);	
			
			if (TrackFinished != null)
			{
				TrackFinished(this, new TrackFinishedEventArgs(trackID));
			}
		}


		/// <summary>
		/// Parses the debug message
		/// </summary>
		/// <param name="msg">The message %x n msg...</param>
		private void parseDebugMessage(String msg)
		{
			String message = "";
			int id = 0;

			String[] parts = msg.Split(' ');
			id = Convert.ToInt32(parts[1]);

			message = parts[2];
			for (int i = 3; i < parts.Length; i++)
			{
				message = " " + parts[i];
			}

			if (DebugMessageReceived != null)
			{
				DebugMessageReceived(this, new DebugMessageReceivedEventArgs(id, message));
			}

		}


		/// <summary>
		/// Parses and dispatches an incoming error message
		/// </summary>
		/// <param name="msg">The message></param>
		private void parseAndDispatchIncomingError(String msg)
		{
			int trackID = 0;
			String description = "";

			String[] parts = msg.Split(' ');

			trackID = Convert.ToInt32(parts[1]);
			description = parts[2];

			if (ErrorReceived != null)
			{
				ErrorReceived(this, new ErrorReceivedEventArs(trackID, description));
			}


		}
	

		/// <summary>
		/// Closes the connection
		/// </summary>
		public void disconnect()
		{
			try
			{
				rxThreadMustRun = false;
				Thread.Sleep(500);
				rxThread.Abort();
			}
			catch { }
			try
			{
				serialConn.Close();
			}
			catch { }
		}


	}
}
