using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrrrBayBay.HARs.dataModel;
using System.IO;

namespace BrrrBayBay.HARs
{
	public static class FileWriter
	{

		/// <summary>
		/// Saves the game results
		/// </summary>
		/// <param name="game">The game</param>
		/// <param name="users">The users with theur ID as key</param>
		/// <param name="results">a sorted list with the results. First place at position 1</param>
		/// <returns>The path to the textFile or an empty String when an error occured.</returns>
		public static string saveTimeTrialResults(HARGame game, Dictionary<int, User> users, List<RaceResult> results)
		{
			String path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\HARs_Results_" + game.GameName + ".txt";
			User tmpUsr;
			int time;
			int sNum;
			String name;

			try
			{
				// create a writer and open the file
				TextWriter tw = new StreamWriter(path);

				// write a line of text to the file
				tw.WriteLine("HAR game results for " + game.GameName + " at " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
				tw.WriteLine("\n\n");
				tw.WriteLine("#" + "\t" + "Time" + "\t" + "Number" + "\t" + "Name");


				for (int i = 0; i < results.Count; i++)
				{
					tmpUsr = users[results[i].UserId];
					time = results[i].TimeMs;	//.ToString("0,000");
					sNum = tmpUsr.startNumber;
					name = tmpUsr.firstName + " " + tmpUsr.lastName;
					tw.WriteLine((i + 1).ToString() + "\t" + time.ToString("0,000") + "\t" + sNum.ToString() + "\t" + name);
				}


				// close the stream
				tw.Close();
			}
			catch
			{
				path = "";
			}

			return path;
		}


		public static void logSerialData(string val, Boolean incoming)
		{
			String path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\HARs_serialLog.txt";
			try
			{
				// create a writer and open the file
				TextWriter tw = new StreamWriter(path,true);

				String timeString = DateTime.Now.Ticks.ToString();

				switch (incoming)
				{
					case true:
						tw.WriteLine(timeString + "\tIN:  \t" + val);
						break;
					case false:
						tw.WriteLine(timeString + "\tOUT: \t" + val);
						break;
				}
				
				tw.Close();
			}
			catch { }
		}

	}
}
