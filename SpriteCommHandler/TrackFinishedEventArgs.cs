using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrrrBayBay.SpriteCommHandler
{
	/// <summary>
	/// Eventhandler for trackFinished event
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="args"></param>
	public delegate void TrackFinishedEventHandler(Object sender, TrackFinishedEventArgs args);

	/// <summary>
	/// Track finished event arguments
	/// </summary>
	public class TrackFinishedEventArgs
	{
		/// <summary>
		/// Gets or sets the trackNumber
		/// </summary>
		public int TrackNumber{get;set;}

		/// <summary>
		/// Constructor
		/// </summary>
		public TrackFinishedEventArgs()
		{
			TrackNumber = 0;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="trackNumber">The TrackNumber</param>
		public TrackFinishedEventArgs(int trackNumber)
		{
			TrackNumber = trackNumber;
		}
	}
}
