using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrrrBayBay.HARs.dataModel;

namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Provides functionality for game scheduling
	/// </summary>
	public static  class GameScheduler
	{

		/// <summary>
		/// Creates a new game schedule for a game
		/// </summary>
		/// <param name="game">The game for which a new schedule must be created</param>
		public static void createGameSchedule(HARGame game)
		{


			switch (game.GameType)
			{
				case GameTypes.TimeTrial:
					createTimeTrialSchedule(game);
					break;
				case GameTypes.ChampionsLeague:
					createLeagueSchedule(game);
					break;
			}


		}


		/// <summary>
		/// Creates a new Timetrial schedule for a game
		/// </summary>
		/// <param name="game">The game</param>
		private static void createTimeTrialSchedule(HARGame game)
		{
			GameRound gm = new GameRound(0, game.ID, 0, 0);
			gm = dbComm.createNewRound(gm);
		}


		/// <summary>
		/// Creates a new GroupAndKnockout schedule for a game
		/// </summary>
		/// <param name="game">The game</param>
		private static void createLeagueSchedule(HARGame game)
		{
			createLeagueRounds(game);
			addUsersToLeaguePoules(game);
		}


		/// <summary>
		/// Adds the users of the given game to the poules
		/// </summary>
		/// <param name="game">The game</param>
		private static void addUsersToLeaguePoules(HARGame game)
		{
			int pouleI = 0;

			// First get all users and rounds in the game
			List<User> usrs = dbComm.getUsersByGame(game);
			Dictionary<int, GameRound> pouleRounds = new Dictionary<int, GameRound>();		// Holds poule rounds. SubroundNumber as key
			List<GameRound> allRounds = dbComm.getGameRoundsForGame(game);

			// Sort out the poule rounds
			foreach (GameRound gr in allRounds)
			{
				if (gr.RoundNumber == 3)
				{
					pouleRounds.Add(gr.SubRoundNumber, gr);
				}
			}

			// Devide the users under the four poule rounds
			for (int i = 0; i < usrs.Count; i++)
			{
				dbComm.addUserToRound(usrs[i], pouleRounds[pouleI]);
				pouleI++;
				if (pouleI > 3)
				{
					pouleI = 0;
				}
			}
		}


		/// <summary>
		/// Creates the League rounds
		/// </summary>
		/// <param name="game">The game that the rounds should belong to</param>
		private static void createLeagueRounds(HARGame game)
		{
			dbComm.createNewRound(new GameRound(0, game.ID, 0, 0));		// Final

			dbComm.createNewRound(new GameRound(0, game.ID, 1, 0));		// Semi final A
			dbComm.createNewRound(new GameRound(0, game.ID, 1, 1));		// Semi final B

			dbComm.createNewRound(new GameRound(0, game.ID, 2, 0));		// Quarter final A
			dbComm.createNewRound(new GameRound(0, game.ID, 2, 1));		// quarter final B
			dbComm.createNewRound(new GameRound(0, game.ID, 2, 2));		// quarter final C
			dbComm.createNewRound(new GameRound(0, game.ID, 2, 3));		// quarter final D

			dbComm.createNewRound(new GameRound(0, game.ID, 3, 0));		// Poule A
			dbComm.createNewRound(new GameRound(0, game.ID, 3, 1));		// Poule B
			dbComm.createNewRound(new GameRound(0, game.ID, 3, 2));		// Poule C
			dbComm.createNewRound(new GameRound(0, game.ID, 3, 3));		// Poule D
		}

	}
}
