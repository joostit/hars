
namespace BrrrBayBay.HARs.dataModel
{
	public class User
	{
		// Methods
		public User()
		{
			this.ID = 0;
			this.startNumber = 0;
			this.firstName = "";
			this.lastName = "";
			this.carWeight = 0f;
			this.grp = 0;
			this.grpName = "";
		}

		public User(int ID, int startNumber, string firstName, string lastName, float carWeight, int grp)
		{
			this.ID = ID;
			this.startNumber = startNumber;
			this.firstName = firstName;
			this.lastName = lastName;
			this.carWeight = carWeight;
			this.grp = grp;
			this.grpName = "";
		}

		public User(int ID, int startNumber, string firstName, string lastName, float carWeight, int grp, string grpName)
		{
			this.ID = ID;
			this.startNumber = startNumber;
			this.firstName = firstName;
			this.lastName = lastName;
			this.carWeight = carWeight;
			this.grp = grp;
			this.grpName = grpName;
		}

		// Properties
		public float carWeight { get; set; }

		public string firstName { get; set; }

		public int grp { get; set; }

		public string grpName { get; set; }

		public int ID { get; set; }

		public string lastName { get; set; }

		public int startNumber { get; set; }
	}

}