using System.Collections.Generic;
namespace BrrrBayBay.HARs.dataModel
{

	public class PlayingUser : User
	{
		// Methods
		public PlayingUser(User usr)
		{
			base.carWeight = usr.carWeight;
			base.firstName = usr.firstName;
			base.grp = usr.grp;
			base.grpName = usr.grpName;
			base.ID = usr.ID;
			base.lastName = usr.lastName;
			base.startNumber = usr.startNumber;
			this.RaceResults = new Dictionary<int, RaceResult>();
		}

		// Properties
		public Dictionary<int, RaceResult> RaceResults { get; set; }
	}

}