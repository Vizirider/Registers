/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-07
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Liquidinster
{
	/// <summary>
	/// Description of Blender.
	/// </summary>
	public partial class Blender : Form
	{
		public Blender(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);;
			textBox1.Text = " " + weekNum + ". hét";
			
			this.textBox11.Text = mws;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			kiskevero kv = new kiskevero();
			kv.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			nagykevero nagy = new nagykevero();
			nagy.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			kiskev kk = new kiskev();
			kk.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			nagykev nk = new nagykev();
			nk.Show();
		}
	}
}
