using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrrrBayBay.HARs
{
	public partial class RaceTimeBox : UserControl
	{


		private int time = 0;

		public RaceTimeBox()
		{
			InitializeComponent();
		}

		

		private void RaceTimeBox_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Sets the time in this timeBox
		/// </summary>
		/// <param name="timeMs">The time in ms</param>
		public void setTime(int timeMs)
		{
			time = timeMs;
			timeBox.Text = timeMs.ToString();
		}

		/// <summary>
		/// Initialize this control
		/// </summary>
		/// <param name="trackNumber">The tracknumber this control is user for</param>
		public void init(int trackNumber)
		{
			timeBox.Text = "";
		}

		/// <summary>
		/// returns the time in the textbox
		/// </summary>
		/// <returns>The time in ms</returns>
		public int getTime()
		{
			return time;
		}

		/// <summary>
		/// Sets if this control is enabled
		/// </summary>
		/// <param name="enabled"></param>
		public void setEnabled(Boolean enabled)
		{
			timeBox.ReadOnly = !enabled;
		}


		/// <summary>
		///  Sets the controls visible state
		/// </summary>
		/// <param name="state">the new state</param>
		public void setVisible(Boolean state)
		{
			timeBox.Visible = state;
			finishedBox.Visible = state;
		}


		public void setFinished()
		{
			finishedBox.Checked = true;
		}


		private void textBox1_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				time = Convert.ToInt32(timeBox.Text);
			}
			catch
			{
				if (time == 0)
				{
					timeBox.Text = "";
				}
				else
				{
					timeBox.Text = time.ToString();
				}
			}
		}

	}
}
