using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrrrBayBay.SpriteCommHandler
{

	/// <summary>
	/// Eventhandler for the error received event
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="args">EventArgs</param>
	public delegate void ErrorReceivedEventHandler(Object sender, ErrorReceivedEventArs args);

	/// <summary>
	/// ErrorReceived eventArgs
	/// </summary>
	public class ErrorReceivedEventArs
	{

		/// <summary>
		/// The Track number where the error occured.
		/// </summary>
		public int TrackNumber { get; set; }

		/// <summary>
		/// an Error description
		/// </summary>
		public String Description { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public ErrorReceivedEventArs()
		{
			TrackNumber = 0;
			Description = "";
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="trackNumber">The trackNumber</param>
		/// <param name="description">an Error description</param>
		public ErrorReceivedEventArs(int trackNumber, String description)
		{
			TrackNumber = trackNumber;
			Description = description;

		}

	}
}
