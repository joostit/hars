using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrrrBayBay.HARs.dataModel;

namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Holds information about the race setup
	/// </summary>
	public class LeagueRaceSetup
	{
		/// <summary>
		/// Holds a List with users who should race
		/// </summary>
		public List<User> UserList { get; set; }

		/// <summary>
		/// Holds the gameRound for each userID.
		/// </summary>
		public Dictionary<int, GameRound> RoundsByUserId { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public LeagueRaceSetup()
		{
			UserList = new List<User>();
			RoundsByUserId = new Dictionary<int, GameRound>();
		}
	}
}
