/*
 * Created by SharpDevelop.
 * User: AJB
 * Date: 12/12/2013
 * Time: 12:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GreenCal
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int TimerInverval { get; set; }
		DateTime tim1;
		DateTime tim2;
		TimeSpan tim3;
		//public Timer timmor = new Timer();
		string buttonName = "" ;
		int count=0;
		//int i;
		string[] generalArray;
		string[] twoArray = {"a","b","c","2"};
		string[] threeArray = {"d","e","f","3"};
		string[] fourArray = {"g","h","i","4"};
		string[] fiveArray = {"j","k","l","5"};
		string[] sixArray = {"m","n","o","6"};
		string[] sevenArray = {"p","q","r","s","7"};
		string[] eightArray = {"t","u","v","8"};
		string[] nineArray = {"w","x","y","z", "9"};
		string[] zeroArray = {" ","0"};
		string[] starArray = {"a","b","c","2"}; // to be changed/No need at all  <<<<<<<<<<<<<<<<<<<<<<<<<
		string[] hashArray = {"a","b","c","2"}; // to be changed/ NO need at all <<<<<<<<<<<<<<<<<<<<<<<<<
		string[] oneArray = {".",",","'","?", "\"","1","-","(","@","/",":","_"};
		public void SetTextScreen()
		{
			try
			{
				if(txtScreen.Tag.ToString() == "1") generalArray = oneArray;
				if(txtScreen.Tag.ToString() == "2") generalArray = twoArray;
				if(txtScreen.Tag.ToString() == "3") generalArray = threeArray;
				if(txtScreen.Tag.ToString() == "4") generalArray = fourArray;
				if(txtScreen.Tag.ToString() == "5") generalArray = fiveArray;
				if(txtScreen.Tag.ToString() == "6") generalArray = sixArray;
				if(txtScreen.Tag.ToString() == "7") generalArray = sevenArray;
				if(txtScreen.Tag.ToString() == "8") generalArray = eightArray;
				if(txtScreen.Tag.ToString() == "9") generalArray = nineArray;
				if(txtScreen.Tag.ToString() == "0") generalArray = zeroArray;
			}
			catch
			{
				MessageBox.Show("String error, check the program");
			}
			
			if(count > 0)
			{
				if(count > generalArray.Length)
					count = (count % generalArray.Length);
				if(btnStar.Tag.ToString() == "lower") txtScreen.Text += generalArray[count-1];
				else txtScreen.Text += generalArray[count-1].ToUpper();
			}
		}
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			txtScreen.Tag = "off";
			timmor.Interval = 2000;
			btnStar.Tag="lower";
		}
		
		void TimmorTick(object sender, EventArgs e)
		{
			tim2 = DateTime.Now;
			tim3 = tim2 - tim1;
			if(tim3.Seconds > 0 && txtScreen.Tag.ToString() != "off")
			{
				SetTextScreen();
				
				count = 0;
				txtScreen.Tag = "off";
				timmor.Stop();
			}
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			buttonName = sender.ToString().Substring(sender.ToString().Length-1, 1) ;
			if(txtScreen.Tag.ToString() == "off")
			{
				txtScreen.Tag = buttonName;
				tim1 = DateTime.Now;
				timmor.Start();
			}
			count++;
		}
		
		void BtnStarClick(object sender, EventArgs e)
		{
			if(btnStar.Tag.ToString()=="lower")
			{
				btnStar.Tag = "upper";
			}
			else
			{
				btnStar.Tag = "lower";
			}
			
		}
		
		void ChangeTimerToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			//this.Hide();
		}
	}
}
