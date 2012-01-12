using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrrrBayBay.HARs.dataModel;
using BrrrBayBay.SpriteCommHandler;

namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Base class for Game Panel
	/// </summary>
	public partial class GameControl : UserControl
	{

		/// <summary>
		/// Gets or sets the Game object
		/// </summary>
		protected HARGame Game { get; set; }

		/// <summary>
		/// The spriteCommHandler
		/// </summary>
		protected SerialSpriteCommHandler CommHandler { get; set; }


		/// <summary>
		/// Constructor
		/// </summary>
		public GameControl()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

		/// <summary>
		/// Returns a list with raceresults sorted by time. (fastest time on position 0)
		/// </summary>
		/// <param name="inputList">The results to be sorted</param>
		/// <returns>a sorted list</returns>
		protected List<RaceResult> sortResults(List<RaceResult> inputList)
		{

			List<RaceResult> retVal = new List<RaceResult>();

			// add the first element
			if (inputList.Count > 0)
			{
				retVal.Add(inputList[0]);
			}

			if (inputList.Count > 1)
			{
				// Sort the results
				for (int iIn = 1; iIn < inputList.Count; iIn++)
				{

					for (int iSort = 0; iSort <= retVal.Count; iSort++)
					{
						if (iSort == retVal.Count)
						{
							retVal.Add(inputList[iIn]);
							break;
						}
						else
						{
							if (inputList[iIn].TimeMs < retVal[iSort].TimeMs)
							{
								retVal.Insert(iSort, inputList[iIn]);
								break;
							}
						}
					}
				}

			}
			return retVal;
		}
	}
}
