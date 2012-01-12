namespace BrrrBayBay.HARs.dataModel
{

	public class GameRound
	{
		// Methods
		public GameRound(int id, int gameId, int roundNumber, int subRoundNumber)
		{
			this.ID = id;
			this.GameID = gameId;
			this.RoundNumber = roundNumber;
			this.SubRoundNumber = subRoundNumber;
		}

		// Properties
		public int GameID { get; set; }

		public int ID { get; set; }

		public int RoundNumber { get; set; }

		public int SubRoundNumber { get; set; }
	}

}