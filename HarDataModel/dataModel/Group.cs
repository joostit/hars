
namespace BrrrBayBay.HARs.dataModel
{
	public class Group
	{
		// Methods
		public Group()
		{
			this.ID = 0;
			this.Name = "";
		}

		public Group(int id, string name)
		{
			this.ID = id;
			this.Name = name;
		}

		public override string ToString()
		{
			return this.Name;
		}

		// Properties
		public int ID { get; set; }

		public string Name { get; set; }
	}

}