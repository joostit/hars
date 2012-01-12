
namespace BrrrBayBay.HARs.dataModel
{
	public class HARGame
	{
		// Methods
		public HARGame()
		{
			this.ID = 0;
			this.GameType = GameTypes.TimeTrial;
			this.GameName = "";
			this.GameState = GameStates.Playing;
		}

		public HARGame(int id, GameTypes gameType, string gameName, GameStates gameState)
		{
			this.ID = id;
			this.GameType = gameType;
			this.GameName = gameName;
			this.GameState = gameState;
		}

		// Properties
		public string GameName { get; set; }

		public GameStates GameState { get; set; }

		public GameTypes GameType { get; set; }

		public int ID { get; set; }
	}

}