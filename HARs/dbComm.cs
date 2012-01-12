using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using BrrrBayBay.HARs.dataModel;
using System.Data;
using System.Windows.Forms;

namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Holds functionality to communicate with the database
	/// </summary>
	public static class dbComm
	{

		/// <summary>
		/// SQLIte ConnectionString
		/// </summary>
		//private const String connectionStrin;


		#region GameManagement

		/// <summary>
		/// Returns all available games
		/// </summary>
		/// <returns></returns>
		public static List<HARGame> getGames()
		{
			List<HARGame> retVal = null;


			DataTable dt = executeResultQuery("SELECT * from tbl_games");
			retVal = parseDataTableToGameList(dt);

			return retVal;
		}


		/// <summary>
		/// Get the results for a specific game
		/// </summary>
		/// <param name="game">The game</param>
		/// <returns>a list with race results</returns>
		public static List<RaceResult> getRaceResults(HARGame game)
		{
			List<RaceResult> result = new List<RaceResult>();
			RaceResult tmp;
			int tmpRid;
			int tmpUid;
			int tmpGmId;
			int tmpTime;
			int resId;

			String query = "SELECT * FROM vw_resultsPerUser WHERE gameID = " + game.ID.ToString();

			DataTable dt = executeResultQuery(query);

			foreach (DataRow dr in dt.Rows)
			{
				tmpRid = Convert.ToInt32(dr["roundID"]);
				tmpUid = Convert.ToInt32(dr["userID"]);
				tmpGmId = Convert.ToInt32(dr["gameID"]);
				tmpTime = Convert.ToInt32(dr["timeMs"]);
				resId = Convert.ToInt32(dr["resultID"]);

				tmp = new RaceResult(resId, tmpUid, tmpRid, tmpGmId, tmpTime);
				result.Add(tmp);

			}

			return result;
		}


		public static void setGameState(HARGame game, GameStates newState)
		{
			String query = "UPDATE tbl_games SET gameStatus = '" + newState.ToString() + "' WHERE ID = " + game.ID + " ";
			executeNonQuery(query);
		}


		/// <summary>
		/// Get the results for a specific round
		/// </summary>
		/// <param name="game">The game</param>
		/// <returns>a list with race results</returns>
		public static List<RaceResult> getRaceResults(GameRound round)
		{
			List<RaceResult> result = new List<RaceResult>();
			RaceResult tmp;
			int tmpRid;
			int tmpUid;
			int tmpGmId;
			int tmpTime;
			int resId;

			String query = "SELECT * FROM vw_resultsPerUser WHERE roundID = " + round.ID.ToString();

			DataTable dt = executeResultQuery(query);

			foreach (DataRow dr in dt.Rows)
			{
				tmpRid = Convert.ToInt32(dr["roundID"]);
				tmpUid = Convert.ToInt32(dr["userID"]);
				tmpGmId = Convert.ToInt32(dr["gameID"]);
				tmpTime = Convert.ToInt32(dr["timeMs"]);
				resId = Convert.ToInt32(dr["resultID"]);

				tmp = new RaceResult(resId, tmpUid, tmpRid, tmpGmId, tmpTime);
				result.Add(tmp);

			}

			return result;
		}


		/// <summary>
		/// Adds the given user to the specified game round
		/// </summary>
		/// <param name="user">The user to be added</param>
		/// <param name="round">The round to which the user should be added</param>
		public static void addUserToRound(User user, GameRound round)
		{
			string query = "INSERT INTO tbl_usersInRounds VALUES ( NULL, ";
			query = query + round.ID.ToString() + ", ";
			query = query + user.ID.ToString() + ")";
			executeNonQuery(query);
		}

		public static List<User> getUsersByRound(GameRound rnd)
		{
			List<User> retVal = new List<User>();
			string query = "SELECT * FROM vw_usersInGameRounds WHERE roundID = " + rnd.ID.ToString();
			DataTable dt = executeResultQuery(query);


			retVal = parseModifiedUsersDataTableToUserList(dt);


			return retVal;
		}


		/// <summary>
		/// Adds a raceResult to The database
		/// </summary>
		/// <param name="result">The result object to be added</param>
		public static void addRaceResult(RaceResult result)
		{
			string query = "INSERT INTO tbl_raceResults VALUES ( NULL, ";
			query = query + result.UserId.ToString() + ", ";
			query = query + result.RoundId.ToString() + ", ";
			query = query + result.TimeMs.ToString() + ")";
			executeNonQuery(query);

		}


		/// <summary>
		/// Creates a new Round
		/// </summary>
		/// <param name="round">The round to be created. (round.ID is don't care)</param>
		/// <returns>The newly created round with a valid ID, or null when an error occured</returns>
		public static GameRound createNewRound(GameRound round)
		{
			string query = "INSERT INTO tbl_gameRounds VALUES ( NULL, ";
			query = query + round.RoundNumber.ToString() + ", ";
			query = query + round.SubRoundNumber.ToString() + ", ";
			query = query + round.GameID.ToString() + ")";
			executeNonQuery(query);

			GameRound rnd = null;

			// Retreive the original round:
			query = "SELECT ID FROM tbl_gameRounds WHERE ";
			query = query + "roundNumber = " + round.RoundNumber.ToString() + " AND ";
			query = query + "subRoundNumber = " + round.SubRoundNumber.ToString() + " AND ";
			query = query + "gameID = " + round.GameID.ToString() + " ";

			DataTable dt = executeResultQuery(query);


			if (dt.Rows.Count != 1)
			{
				MessageBox.Show("Error during round creation. Number of roundObjects after creation: " + dt.Rows.Count.ToString());
			}
			else
			{
				rnd = new GameRound(0, round.GameID, round.RoundNumber, round.SubRoundNumber);
				rnd.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
			}

			return rnd;
		}


		public static List<GameRound> getGameRoundsForGame(HARGame game)
		{
			List<GameRound> retVal = new List<GameRound>();
			GameRound tmpRound;

			int gmId;
			int rndId;
			int rndNum;
			int rndSubNum;

			String query = "SELECT * FROM tbl_gameRounds WHERE gameID = " + game.ID;

			DataTable dt = executeResultQuery(query);

			foreach (DataRow dr in dt.Rows)
			{
				gmId = Convert.ToInt32(dr["gameID"]);
				rndId = Convert.ToInt32(dr["ID"]);
				rndNum = Convert.ToInt32(dr["roundNumber"]);
				rndSubNum = Convert.ToInt32(dr["subRoundNumber"]);
				tmpRound = new GameRound(rndId, gmId, rndNum, rndSubNum);
				retVal.Add(tmpRound);
			}

			return retVal;
		}



		/// <summary>
		/// Adds a game to the db
		/// </summary>
		/// <param name="game">a HAR game. (GameID is dont't Care)</param>
		/// <returns>The added gameID, now with a valid GameID. Or null if an error occured</returns>
		public static HARGame addGame(HARGame game)
		{
			String query = "INSERT INTO tbl_games VALUES( NULL, ";
			query = query + "'" + deleteUnsafeChars(game.GameName) + "', ";
			query = query + "'" + deleteUnsafeChars(game.GameType.ToString()) + "', ";
			query = query + "'" + deleteUnsafeChars(game.GameState.ToString()) + "')";
			executeNonQuery(query);

			query = "SELECT * FROM tbl_games WHERE  gameName='" + deleteUnsafeChars(game.GameName) + "'";

			DataTable dt = executeResultQuery(query);
			List<HARGame> lst = parseDataTableToGameList(dt);

			return lst[0];
		}



		/// <summary>
		/// gets all users belonging to a specific game
		/// </summary>
		/// <param name="game">The game</param>
		/// <returns>a list with users</returns>
		public static List<User> getUsersByGame(HARGame game)
		{
			string query = "SELECT * FROM vw_usersInGame WHERE gameId = " + game.ID.ToString();
			DataTable dt = executeResultQuery(query);
			List<User> result = parseModifiedUsersDataTableToUserList(dt);
			return result;
		}


		/// <summary>
		/// Remove a user from the usersInGames table
		/// </summary>
		/// <param name="us"></param>
		public static void removeUserFromGame(HARGame game, User us)
		{
			string query = "DELETE FROM tbl_usersInGames WHERE userID = " + us.ID.ToString() + " AND gameID = " + game.ID.ToString();
			executeNonQuery(query);
		}

		/// <summary>
		/// Removes all raceResults for a single user from a single game
		/// </summary>
		/// <param name="game">The game</param>
		/// <param name="us">The user</param>
		public static void removeRaceResults(HARGame game, User us)
		{
			// First get the round ID('s)
			string query = "SELECT * FROM tbl_gameRounds WHERE gameID = " + game.ID.ToString();

			DataTable dt = executeResultQuery(query);

			foreach (DataRow dr in dt.Rows)
			{
				query = "DELETE FROM tbl_raceResults WHERE userID = " + us.ID + " AND roundID = " + Convert.ToInt32(dr["ID"]).ToString();
				executeNonQuery(query);
			}

		}


		/// <summary>
		/// Adds users to an existing game
		/// </summary>
		/// <param name="game">The game</param>
		/// <param name="users">The users</param>
		public static void addUsersToGame(HARGame game, List<User> users)
		{
			foreach (User usr in users)
			{
				String query = "INSERT INTO tbl_usersInGames VALUES (" + usr.ID.ToString() + ", " + game.ID.ToString() + ")";
				executeNonQuery(query);
			}
		}



		/// <summary>
		/// Parses the given data table with games to a list of games
		/// </summary>
		/// <param name="dt">The datatable with games</param>
		/// <returns>a list with games</returns>
		private static List<HARGame> parseDataTableToGameList(DataTable dt)
		{

			List<HARGame> resultList = new List<HARGame>();
			HARGame tmp;
			int id;
			String name;
			GameTypes tp;
			GameStates st;


			foreach (DataRow dr in dt.Rows)
			{
				id = Convert.ToInt32(dr["ID"]);
				name = (String)dr["gameName"];
				tp = (GameTypes)Enum.Parse(typeof(GameTypes), (String)dr["gameType"], true);
				st = (GameStates)Enum.Parse(typeof(GameStates), (String)dr["gameStatus"], true);

				tmp=new HARGame(id, tp, name, st);

				resultList.Add(tmp);
			}
		
			return resultList;
		}




		#endregion



		#region userManagement

		/// <summary>
		/// Parses the the given dataTable to a user List
		/// </summary>
		/// <param name="dt">The dataTable</param>
		/// <returns>a List with User objects</returns>
		private static List<User> parseDataTableToUserList(DataTable dt)
		{
			List<User> resultList = new List<User>();

			int id;
			int sn;
			String fn;
			String ln;
			float cw;
			int grp;
			String grpName;

			foreach (DataRow dr in dt.Rows)
			{
				id = Convert.ToInt32(dr["ID"]);
				sn = Convert.ToInt32(dr["startNumber"]);
				fn = (String)dr["firstName"];
				ln = (String)dr["lastName"];
				cw = (float)Convert.ToDouble(dr["carWeight"]);
				grp = Convert.ToInt32(dr["grp"]);

				try
				{
					grpName = (String)dr["grpName"];
					User tmp = new User(id, sn, fn, ln, cw, grp, grpName);
					resultList.Add(tmp);
				}
				catch 
				{
					User tmp = new User(id, sn, fn, ln, cw, grp);
					resultList.Add(tmp);
				}

				
			}
			return resultList;
		}



		/// <summary>
		/// Parses the the given dataTable to a user List
		/// </summary>
		/// <param name="dt">The dataTable</param>
		/// <returns>a List with User objects</returns>
		private static List<User> parseModifiedUsersDataTableToUserList(DataTable dt)
		{
			List<User> resultList = new List<User>();

			int id;
			int sn;
			String fn;
			String ln;
			float cw;
			int grp;
			String grpName;

			foreach (DataRow dr in dt.Rows)
			{
				id = Convert.ToInt32(dr["userID"]);
				sn = Convert.ToInt32(dr["startNumber"]);
				fn = (String)dr["firstName"];
				ln = (String)dr["lastName"];
				cw = (float)Convert.ToDouble(dr["carWeight"]);
				grp = Convert.ToInt32(dr["grp"]);

				try
				{
					grpName = (String)dr["grpName"];
					User tmp = new User(id, sn, fn, ln, cw, grp, grpName);
					resultList.Add(tmp);
				}
				catch
				{
					User tmp = new User(id, sn, fn, ln, cw, grp);
					resultList.Add(tmp);
				}
			}
			return resultList;
		}


		/// <summary>
		/// Adds a new user to the DB 
		/// </summary>
		/// <param name="newUser"></param>
		public static void addNewUserToDb(User newUser)
		{
			String query = "INSERT INTO tbl_users VALUES( NULL, ";
			query = query + newUser.startNumber.ToString() + ", ";
			query = query + "'" + deleteUnsafeChars(newUser.firstName) + "', ";
			query = query + "'" + deleteUnsafeChars(newUser.lastName) + "', ";
			query = query + newUser.carWeight.ToString() + ", ";
			query = query + newUser.grp.ToString() + ")";
			executeNonQuery(query);
		}


		/// <summary>
		/// Edits an existing nuser
		/// </summary>
		/// <param name="theUser">The user that should be edited</param>
		public static void editUser(User theUser)
		{
			String query = "UPDATE tbl_users SET ";
			query = query + "startNumber= " + theUser.startNumber.ToString() + ", ";
			query = query + "firstName= '" + deleteUnsafeChars(theUser.firstName) + "', ";
			query = query + "lastName= '" + deleteUnsafeChars(theUser.lastName) + "', ";
			query = query + "carWeight= " + theUser.carWeight.ToString() + ", ";
			query = query + "grp= " + theUser.grp.ToString() + " ";
			query = query + "WHERE ID= " + theUser.ID.ToString();

			executeNonQuery(query);
		}


		/// <summary>
		/// Deletes a user from the DB
		/// </summary>
		/// <param name="theUser">The user to be deleted</param>
		public static void deleteUser(User theUser)
		{
			String query = "DELETE FROM tbl_users WHERE ID= " + theUser.ID.ToString();
			executeNonQuery(query);
		}


		/// <summary>
		/// Gets users from a specific group
		/// </summary>
		/// <param name="groupName">The groupName</param>
		/// <returns>a List with user objects</returns>
		public static List<User> getUsersByGroup(String groupName)
		{
			List<User> resultList;
			String query = "SELECT * FROM vw_usersInGrp WHERE grpName = '" + groupName + "'";
			DataTable dt = executeResultQuery(query);
			resultList = parseDataTableToUserList(dt);
			return resultList;
		}



		/// <summary>
		/// Gets all users from the database
		/// </summary>
		/// <returns></returns>
		public static List<User> getUsers()
		{

			List<User> resultList;
			String query = "SELECT * FROM tbl_users";
			DataTable dt = executeResultQuery(query);
			resultList = parseDataTableToUserList(dt);

			return resultList;
		}



		/// <summary>
		/// Gets a user with a specific ID
		/// </summary>
		/// <param name="userID">The userID</param>
		/// <returns>a User object</returns>
		public static User getUser(int userID)
		{
			String query = "SELECT * FROM tbl_users WHERE ID = " + userID.ToString();
			DataTable dt = executeResultQuery(query);
			return parseDataTableToUserList(dt)[0];
		}


		/// <summary>
		/// Get users from the db with the given ID's
		/// </summary>
		/// <returns></returns>
		public static List<User> getUsers(List<int> IDs)
		{

			List<User> resultList = new List<User>();
			List<User> tmpUsr;
			foreach (int id in IDs)
			{
				String query = "SELECT * FROM tbl_users WHERE ID = ";
				DataTable dt = executeResultQuery(query);
				tmpUsr = parseDataTableToUserList(dt);
				resultList.Add(tmpUsr[0]);
			}
			return resultList;
		}


		/// <summary>
		/// Gets users from a specific group
		/// </summary>
		/// <param name="groupId">The group ID</param>
		/// <returns>a List with user objects</returns>
		public static List<User> getUsersByGroup(int groupId)
		{
			List<User> resultList;
			String query = "SELECT * FROM vw_usersInGrp WHERE grp = " + groupId.ToString();
			DataTable dt = executeResultQuery(query);
			resultList = parseDataTableToUserList(dt);
			return resultList;
		}


		/// <summary>
		/// Gets all available groups
		/// </summary>
		/// <returns></returns>
		public static List<Group> getGroups()
		{
			List<Group> resultList = new List<Group>();
			String query = "SELECT * FROM tbl_groups";
			DataTable dt = executeResultQuery(query);

			foreach (DataRow dr in dt.Rows)
			{
				try
				{
					Group tmp = new Group(Convert.ToInt32(dr["ID"]), (String)dr["name"]);
					resultList.Add(tmp);
				}
				catch { }
			}

			return resultList;
		}


		/// <summary>
		/// Adds a group
		/// </summary>
		/// <param name="grp">The new group</param>
		public static void addGroup(Group grp)
		{
			String query = "INSERT INTO tbl_groups VALUES( NULL, ";
			query = query + "'" + deleteUnsafeChars(grp.Name) + "' )";
			executeNonQuery(query);
		}


		/// <summary>
		/// edits an existing group
		/// </summary>
		/// <param name="grp">The group</param>
		public static void editGroup(Group grp)
		{
			String query = "UPDATE tbl_groups SET ";
			query = query + "name= '" + deleteUnsafeChars(grp.Name) + "' ";
			query = query + "WHERE ID= " + grp.ID.ToString();

			executeNonQuery(query);
		}



		/// <summary>
		/// Deletes a group
		/// </summary>
		/// <param name="grp">The group to be deleted.</param>
		public static void deleteGroup(Group grp)
		{
			String query = "DELETE FROM tbl_groups WHERE ID= " + grp.ID.ToString();
			executeNonQuery(query);
		}


		#endregion

		#region Utils


		/// <summary>
		/// Exectutes a query on the DB without a result.
		/// </summary>
		/// <param name="query">The query</param>
		/// <returns>The result of the inner ExecuteNonQuery method</returns>
		private static int executeNonQuery(String query)
		{
			//String connectionString = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\HARsDB.s3db";
			String connectionString = "Data Source=HARsDB.s3db";
			SQLiteConnection cnn = new SQLiteConnection(connectionString);
			cnn.Open();
			SQLiteCommand command = new SQLiteCommand(cnn);
			command.CommandText = query;
			return command.ExecuteNonQuery();
		}


		/// <summary>
		/// Delete unsafe characters from a string to be used in SQL
		/// </summary>
		/// <param name="input">The input string</param>
		/// <returns>the output string</returns>
		private static String deleteUnsafeChars(String input)
		{
			input = input.Replace("'", "");
			input = input.Replace("(", "");
			input = input.Replace(")", "");
			input = input.Replace("\"", "");
			input = input.Replace("\\", "");
			input = input.Replace(",", "");
			input = input.Replace(";", "");
			input = input.Replace("\"", "");
			input = input.Replace(":", "");

			return input;
		}




		/// <summary>
		/// Executes a query on the Db and returns the result as a dataTable
		/// </summary>
		/// <param name="query">The SQL query</param>
		/// <returns>a DataTable with the results</returns>
		private static DataTable executeResultQuery(String query)
		{
			DataTable dt = new DataTable();

			String connectionString = "Data Source=HARsDB.s3db";

			SQLiteConnection cnn = new SQLiteConnection(connectionString);
			cnn.Open();
			SQLiteCommand getUsersCommand = new SQLiteCommand(cnn);
			getUsersCommand.CommandText = query;
			SQLiteDataReader reader = getUsersCommand.ExecuteReader();

			try
			{
				dt.Load(reader);
			}
			catch { }		// Workaround a failing constraint mechanism

			return dt;
		}


		#endregion

	}
}
