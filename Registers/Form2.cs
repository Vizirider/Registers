/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2015-12-07
 * Time: 13:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing.Imaging;


namespace Liquidinster
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			string barcode = textBox1.Text;
			
			//http://www.idautomation.com/fonts/free/IDAutomationCode39.zip
			
			Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
			Font oFont = new System.Drawing.Font("IDAutomationHC39M", 20);
			PointF point = new PointF(2f, 2f);
			SolidBrush black = new SolidBrush(Color.Black);
			SolidBrush White = new SolidBrush(Color.White);
			graphics.FillRectangle(White,0,0,bitmap.Width,bitmap.Height);
			graphics.DrawString("*" + barcode + "*",oFont,black,point);
			}
			using(MemoryStream ms = new MemoryStream()){
				bitmap.Save(ms,ImageFormat.Png);
				pictureBox1.Image = bitmap;
				pictureBox1.Height = bitmap.Height;
				pictureBox1.Width = bitmap.Width;
			}
		}
	}
}
