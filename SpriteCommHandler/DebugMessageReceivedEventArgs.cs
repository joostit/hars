using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrrrBayBay.SpriteCommHandler
{
	/// <summary>
	/// Debug message event handler
	/// </summary>
	/// <param name="sender">event sender</param>
	/// <param name="args">EventArgs</param>
	public delegate void DebugMessageReceivedEventHandler(Object sender, DebugMessageReceivedEventArgs args);

	/// <summary>
	/// Debug message received event arguments
	/// </summary>
	public class DebugMessageReceivedEventArgs
	{
		/// <summary>
		/// Gets or sets the identifier
		/// </summary>
		public int Identifier { get; set; }

		/// <summary>
		/// Gets or sets the message
		/// </summary>
		public String Message { get; set; }


		/// <summary>
		/// Constructor
		/// </summary>
		public DebugMessageReceivedEventArgs()
		{
			Identifier = 0;
			Message = "";
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="id">The debug ID</param>
		/// <param name="msg">The message</param>
		public DebugMessageReceivedEventArgs(int id, String msg)
		{
			Identifier = id;
			Message = msg;
		}

	}
}
