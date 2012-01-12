using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrrrBayBay.SpriteCommHandler
{

	/// <summary>
	/// RaceResults received event handler
	/// </summary>
	/// <param name="sender">Event sender</param>
	/// <param name="args">Event args</param>
	public delegate void RaceResultsReceivedEventHandler(Object sender, RaceResultsReceivedEventArgs args);

	/// <summary>
	/// Race results event args
	/// </summary>
	public class RaceResultsReceivedEventArgs : EventArgs
	{
		/// <summary>
		/// Gets or sets a Dictionary with trackNumber as Key and time as value
		/// </summary>
		public Dictionary<int, int> Results { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public RaceResultsReceivedEventArgs()
		{
			Results = new Dictionary<int, int>();
		}

		/// <summary>
		/// Cosntructor
		/// </summary>
		/// <param name="results">The resultys</param>
		public RaceResultsReceivedEventArgs(Dictionary<int, int> results)
		{
			Results = results;
		}
	}
}
