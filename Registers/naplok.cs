/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-07-18
 * Time: 08:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms.DataVisualization.Charting;

namespace Liquidinster
{
	/// <summary>
	/// Description of naplok.
	/// </summary>
	/// Digital room check with each of area, show mws name to textboxes
	public partial class naplok : Form
	{
		public naplok(string lang)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			button72.Text = lang;
			Button46Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			Button4Click(null,null);
			Button5Click(null,null);
			Button6Click(null,null);
			Button7Click(null,null);
			Button8Click(null,null);
			Button9Click(null,null);
			Button10Click(null,null);
			Button16Click(null,null);
			Button15Click(null,null);
			Button14Click(null,null);
			Button13Click(null,null);
			Button12Click(null,null);
			Button11Click(null,null);
			Button21Click(null,null);
			Button20Click(null,null);
			Button19Click(null,null);	
			Button18Click(null,null);
			Button17Click(null,null);
			Button22Click(null,null);
			Button23Click(null,null);
			Button24Click(null,null);	
			Button25Click(null,null);
			Button26Click(null,null);	
			Button27Click(null,null);	
			Button28Click(null,null);
			Button29Click(null,null);
			Button30Click(null,null);
			Button31Click(null,null);
			Button32Click(null,null);	
			Button33Click(null,null);
			Button34Click(null,null);	
			Button35Click(null,null);
			Button43Click(null,null);
			Button42Click(null,null);	
			Button41Click(null,null);
			Button40Click(null,null);	
			Button39Click(null,null);	
			Button38Click(null,null);
			Button37Click(null,null);
			Button36Click(null,null);
			Button44Click(null,null);
			Button45Click(null,null);
			Button2Click(null,null);

        int countTB = 0;
        int countTG = 0;
        foreach (Control c in this.Controls) 
        {

            if (c.GetType() == typeof(TextBox) && c.BackColor == Color.Red)
            {
                countTB++;
            }
            if (c.GetType() == typeof(TextBox) && c.BackColor == Color.White)
            {
                countTG++;
            }
        }
        
        double pro = 100-(Convert.ToDouble(countTB) / (Convert.ToDouble(countTB) + Convert.ToDouble(countTG)))*100;
        
        
			if(button72.Text == "Nyelv")
			{
        	MessageBox.Show(dateTimePicker1.Text+" Hiányzó naplók: " + countTB + " Kitöltött naplók: " + countTG + " Ez százalékosan: " + pro + "%");

			}
			else if(button72.Text == "Lang")
			{
			MessageBox.Show(dateTimePicker1.Text+" Missing logs: " + countTB + " Filled logs: " + countTG + " This is in percentage: " + pro + "%");	
			}
	

            int i1 = countTG;
            int i2 = countTB;
 
            float total = i1 + i2;
            float deg1 = (i1 / total) * 360;
            float deg2 = (i2 / total) * 360;
            
            Pen p = new Pen(Color.Black, 2);
 
            Graphics g = this.CreateGraphics();
 
            Rectangle rec = new Rectangle(textBox1.Location.X + textBox1.Size.Width + 400, 300, 100, 100);
 
            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            
            g.DrawPie(p, rec, 0, deg1);
            g.FillPie(b1, rec, 0, deg1);
            g.DrawPie(p, rec, deg1, deg2);
            g.FillPie(b2, rec, deg1, deg2);
            textBox130.Text = pro.ToString();
			            
		}
		void Button2Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 2", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox57.Text = (read["Operator1"].ToString());	
					textBox57.BackColor = Color.White;	
					textBox56.Text = (read["Operator2"].ToString());	
					textBox56.BackColor = Color.White;	
					textBox55.Text = (read["Operator3"].ToString());	
					textBox55.BackColor = Color.White;						
					}
				else {
					textBox57.Text = "0";
					textBox57.BackColor = Color.Red;
					textBox56.Text = "0";
					textBox56.BackColor = Color.Red;
					textBox55.Text = "0";
					textBox55.BackColor = Color.Red;
				}
				}	
		}
		void Button3Click(object sender, EventArgs e)
		{
		System.Diagnostics.Process.Start(@"V:\Production\14 REGISTER\naplo1.accdb");	
		}
		void Button4Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.szobaSD WHERE Datum = ('" + dateTimePicker1.Text + "') AND SD = 'M450' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox60.Text = (read["Operator1"].ToString());	
					textBox60.BackColor = Color.White;	
					textBox59.Text = (read["Operator2"].ToString());	
					textBox59.BackColor = Color.White;	
					textBox58.Text = (read["Operator3"].ToString());	
					textBox58.BackColor = Color.White;						
					}
				else {
					textBox60.Text = "0";
					textBox60.BackColor = Color.Red;
					textBox59.Text = "0";
					textBox59.BackColor = Color.Red;
					textBox58.Text = "0";
					textBox58.BackColor = Color.Red;
				}
				}	
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.szobaSD WHERE Datum = ('" + dateTimePicker1.Text + "') AND SD = 'M60' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox63.Text = (read["Operator1"].ToString());	
					textBox63.BackColor = Color.White;	
					textBox62.Text = (read["Operator2"].ToString());	
					textBox62.BackColor = Color.White;	
					textBox61.Text = (read["Operator3"].ToString());	
					textBox61.BackColor = Color.White;						
					}
				else {
					textBox63.Text = "0";
					textBox63.BackColor = Color.Red;
					textBox62.Text = "0";
					textBox62.BackColor = Color.Red;
					textBox61.Text = "0";
					textBox61.BackColor = Color.Red;
				}
				}		
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.szobaSD WHERE Datum = ('" + dateTimePicker1.Text + "') AND SD = 'M20' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox66.Text = (read["Operator1"].ToString());	
					textBox66.BackColor = Color.White;	
					textBox65.Text = (read["Operator2"].ToString());	
					textBox65.BackColor = Color.White;	
					textBox64.Text = (read["Operator3"].ToString());	
					textBox64.BackColor = Color.White;						
					}
				else {
					textBox66.Text = "0";
					textBox66.BackColor = Color.Red;
					textBox65.Text = "0";
					textBox65.BackColor = Color.Red;
					textBox64.Text = "0";
					textBox64.BackColor = Color.Red;
				}
				}	
		}
		void Button7Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPF WHERE Datum = ('" + dateTimePicker1.Text + "') AND Reactor = 'R1601' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox69.Text = (read["operator1"].ToString());	
					textBox69.BackColor = Color.White;	
					textBox68.Text = (read["operator2"].ToString());	
					textBox68.BackColor = Color.White;	
					textBox67.Text = (read["operator3"].ToString());	
					textBox67.BackColor = Color.White;						
					}
				else {
					textBox69.Text = "0";
					textBox69.BackColor = Color.Red;
					textBox68.Text = "0";
					textBox68.BackColor = Color.Red;
					textBox67.Text = "0";
					textBox67.BackColor = Color.Red;
				}
				}	
		}
		void Button8Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPF WHERE Datum = ('" + dateTimePicker1.Text + "') AND Reactor = 'R4001' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox72.Text = (read["operator1"].ToString());	
					textBox72.BackColor = Color.White;	
					textBox71.Text = (read["operator2"].ToString());	
					textBox71.BackColor = Color.White;	
					textBox70.Text = (read["operator3"].ToString());	
					textBox70.BackColor = Color.White;						
					}
				else {
					textBox72.Text = "0";
					textBox72.BackColor = Color.Red;
					textBox71.Text = "0";
					textBox71.BackColor = Color.Red;
					textBox70.Text = "0";
					textBox70.BackColor = Color.Red;
				}
				}	
		}
		void Button9Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPF WHERE Datum = ('" + dateTimePicker1.Text + "') AND Reactor = 'Lödige' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox75.Text = (read["operator1"].ToString());	
					textBox75.BackColor = Color.White;	
					textBox74.Text = (read["operator2"].ToString());	
					textBox74.BackColor = Color.White;	
					textBox73.Text = (read["operator3"].ToString());	
					textBox73.BackColor = Color.White;						
					}
				else {
					textBox75.Text = "0";
					textBox75.BackColor = Color.Red;
					textBox74.Text = "0";
					textBox74.BackColor = Color.Red;
					textBox73.Text = "0";
					textBox73.BackColor = Color.Red;
				}
				}	
		}
		void Button10Click(object sender, EventArgs e)
		{
            SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Körös, Duna, Tisza, Maros FROM [Muszakbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			conn.Close();	
		}
		void Button16Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '6001' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox96.Text = (read["operator1"].ToString());	
					textBox96.BackColor = Color.White;	
					textBox95.Text = (read["operator2"].ToString());	
					textBox95.BackColor = Color.White;	
					textBox94.Text = (read["operator3"].ToString());	
					textBox94.BackColor = Color.White;						
					}
				else {
					textBox96.Text = "0";
					textBox96.BackColor = Color.Red;
					textBox95.Text = "0";
					textBox95.BackColor = Color.Red;
					textBox94.Text = "0";
					textBox94.BackColor = Color.Red;
				}
				}	
		}
		void Button15Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '6002' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox99.Text = (read["operator1"].ToString());	
					textBox99.BackColor = Color.White;	
					textBox98.Text = (read["operator2"].ToString());	
					textBox98.BackColor = Color.White;	
					textBox97.Text = (read["operator3"].ToString());	
					textBox97.BackColor = Color.White;						
					}
				else {
					textBox99.Text = "0";
					textBox99.BackColor = Color.Red;
					textBox98.Text = "0";
					textBox98.BackColor = Color.Red;
					textBox97.Text = "0";
					textBox97.BackColor = Color.Red;
				}
				}	
		}
		void Button14Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '6003' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox102.Text = (read["operator1"].ToString());	
					textBox102.BackColor = Color.White;	
					textBox101.Text = (read["operator2"].ToString());	
					textBox101.BackColor = Color.White;	
					textBox100.Text = (read["operator3"].ToString());	
					textBox100.BackColor = Color.White;						
					}
				else {
					textBox102.Text = "0";
					textBox102.BackColor = Color.Red;
					textBox101.Text = "0";
					textBox101.BackColor = Color.Red;
					textBox100.Text = "0";
					textBox100.BackColor = Color.Red;
				}
				}	
		}
		void Button13Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '1501' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox105.Text = (read["operator1"].ToString());	
					textBox105.BackColor = Color.White;	
					textBox104.Text = (read["operator2"].ToString());	
					textBox104.BackColor = Color.White;	
					textBox103.Text = (read["operator3"].ToString());	
					textBox103.BackColor = Color.White;						
					}
				else {
					textBox105.Text = "0";
					textBox105.BackColor = Color.Red;
					textBox104.Text = "0";
					textBox104.BackColor = Color.Red;
					textBox103.Text = "0";
					textBox103.BackColor = Color.Red;
				}
				}	
		}
		void Button12Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '1502' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox108.Text = (read["operator1"].ToString());	
					textBox108.BackColor = Color.White;	
					textBox107.Text = (read["operator2"].ToString());	
					textBox107.BackColor = Color.White;	
					textBox106.Text = (read["operator3"].ToString());	
					textBox106.BackColor = Color.White;						
					}
				else {
					textBox108.Text = "0";
					textBox108.BackColor = Color.Red;
					textBox107.Text = "0";
					textBox107.BackColor = Color.Red;
					textBox106.Text = "0";
					textBox106.BackColor = Color.Red;
				}
				}	
		}
		void Button11Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '1503' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox111.Text = (read["operator1"].ToString());	
					textBox111.BackColor = Color.White;	
					textBox110.Text = (read["operator2"].ToString());	
					textBox110.BackColor = Color.White;	
					textBox109.Text = (read["operator3"].ToString());	
					textBox109.BackColor = Color.White;						
					}
				else {
					textBox111.Text = "0";
					textBox111.BackColor = Color.Red;
					textBox110.Text = "0";
					textBox110.BackColor = Color.Red;
					textBox109.Text = "0";
					textBox109.BackColor = Color.Red;
				}
				}	
		}
		void Button21Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '500' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox114.Text = (read["operator1"].ToString());	
					textBox114.BackColor = Color.White;	
					textBox113.Text = (read["operator2"].ToString());	
					textBox113.BackColor = Color.White;	
					textBox112.Text = (read["operator3"].ToString());	
					textBox112.BackColor = Color.White;						
					}
				else {
					textBox114.Text = "0";
					textBox114.BackColor = Color.Red;
					textBox113.Text = "0";
					textBox113.BackColor = Color.Red;
					textBox112.Text = "0";
					textBox112.BackColor = Color.Red;
				}
				}	
		}
		void Button20Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '100' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox117.Text = (read["operator1"].ToString());	
					textBox117.BackColor = Color.White;	
					textBox116.Text = (read["operator2"].ToString());	
					textBox116.BackColor = Color.White;	
					textBox115.Text = (read["operator3"].ToString());	
					textBox115.BackColor = Color.White;						
					}
				else {
					textBox117.Text = "0";
					textBox117.BackColor = Color.Red;
					textBox116.Text = "0";
					textBox116.BackColor = Color.Red;
					textBox115.Text = "0";
					textBox115.BackColor = Color.Red;
				}
				}	
		}
		void Button19Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'Diosna' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox120.Text = (read["operator1"].ToString());	
					textBox120.BackColor = Color.White;	
					textBox119.Text = (read["operator2"].ToString());	
					textBox119.BackColor = Color.White;	
					textBox118.Text = (read["operator3"].ToString());	
					textBox118.BackColor = Color.White;						
					}
				else {
					textBox120.Text = "0";
					textBox120.BackColor = Color.Red;
					textBox119.Text = "0";
					textBox119.BackColor = Color.Red;
					textBox118.Text = "0";
					textBox118.BackColor = Color.Red;
				}
				}	
		}
		void Button18Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'Henschel' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox123.Text = (read["operator1"].ToString());	
					textBox123.BackColor = Color.White;	
					textBox122.Text = (read["operator2"].ToString());	
					textBox122.BackColor = Color.White;	
					textBox121.Text = (read["operator3"].ToString());	
					textBox121.BackColor = Color.White;						
					}
				else {
					textBox123.Text = "0";
					textBox123.BackColor = Color.Red;
					textBox122.Text = "0";
					textBox122.BackColor = Color.Red;
					textBox121.Text = "0";
					textBox121.BackColor = Color.Red;
				}
				}		
		}
		void Button17Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBLE WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = '1504' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox126.Text = (read["operator1"].ToString());	
					textBox126.BackColor = Color.White;	
					textBox125.Text = (read["operator2"].ToString());	
					textBox125.BackColor = Color.White;	
					textBox124.Text = (read["operator3"].ToString());	
					textBox124.BackColor = Color.White;						
					}
				else {
					textBox126.Text = "0";
					textBox126.BackColor = Color.Red;
					textBox125.Text = "0";
					textBox125.BackColor = Color.Red;
					textBox124.Text = "0";
					textBox124.BackColor = Color.Red;
				}
				}	
		}
		void Button27Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = '3'", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox78.Text = (read["operator1"].ToString());	
					textBox78.BackColor = Color.White;	
					textBox77.Text = (read["operator2"].ToString());	
					textBox77.BackColor = Color.White;	
					textBox76.Text = (read["operator3"].ToString());	
					textBox76.BackColor = Color.White;						
					}
				else {
					textBox78.Text = "0";
					textBox78.BackColor = Color.Red;
					textBox77.Text = "0";
					textBox77.BackColor = Color.Red;
					textBox76.Text = "0";
					textBox76.BackColor = Color.Red;
				}
				}	
		}
		void Button26Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = '4'", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox81.Text = (read["operator1"].ToString());	
					textBox81.BackColor = Color.White;	
					textBox80.Text = (read["operator2"].ToString());	
					textBox80.BackColor = Color.White;	
					textBox79.Text = (read["operator3"].ToString());	
					textBox79.BackColor = Color.White;						
					}
				else {
					textBox81.Text = "0";
					textBox81.BackColor = Color.Red;
					textBox80.Text = "0";
					textBox80.BackColor = Color.Red;
					textBox79.Text = "0";
					textBox79.BackColor = Color.Red;
				}
				}	
		}
		void Button25Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = '5' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox84.Text = (read["operator1"].ToString());	
					textBox84.BackColor = Color.White;	
					textBox83.Text = (read["operator2"].ToString());	
					textBox83.BackColor = Color.White;	
					textBox82.Text = (read["operator3"].ToString());	
					textBox82.BackColor = Color.White;						
					}
				else {
					textBox84.Text = "0";
					textBox84.BackColor = Color.Red;
					textBox83.Text = "0";
					textBox83.BackColor = Color.Red;
					textBox82.Text = "0";
					textBox82.BackColor = Color.Red;
				}
				}	
		}
		void Button24Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = '6' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox87.Text = (read["operator1"].ToString());	
					textBox87.BackColor = Color.White;	
					textBox86.Text = (read["operator2"].ToString());	
					textBox86.BackColor = Color.White;	
					textBox85.Text = (read["operator3"].ToString());	
					textBox85.BackColor = Color.White;						
					}
				else {
					textBox87.Text = "0";
					textBox87.BackColor = Color.Red;
					textBox86.Text = "0";
					textBox86.BackColor = Color.Red;
					textBox85.Text = "0";
					textBox85.BackColor = Color.Red;
				}
				}	
		}
		void Button23Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = '7'", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox90.Text = (read["operator1"].ToString());	
					textBox90.BackColor = Color.White;	
					textBox89.Text = (read["operator2"].ToString());	
					textBox89.BackColor = Color.White;	
					textBox88.Text = (read["operator3"].ToString());	
					textBox88.BackColor = Color.White;						
					}
				else {
					textBox90.Text = "0";
					textBox90.BackColor = Color.Red;
					textBox89.Text = "0";
					textBox89.BackColor = Color.Red;
					textBox88.Text = "0";
					textBox88.BackColor = Color.Red;
				}
				}	
		}
		void Button22Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaBMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = '9'", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox93.Text = (read["operator1"].ToString());	
					textBox93.BackColor = Color.White;	
					textBox92.Text = (read["operator2"].ToString());	
					textBox92.BackColor = Color.White;	
					textBox91.Text = (read["operator3"].ToString());	
					textBox91.BackColor = Color.White;						
					}
				else {
					textBox93.Text = "0";
					textBox93.BackColor = Color.Red;
					textBox92.Text = "0";
					textBox92.BackColor = Color.Red;
					textBox91.Text = "0";
					textBox91.BackColor = Color.Red;
				}
				}		
		}
		void Button35Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 'SMP01' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox30.Text = (read["operator1"].ToString());	
					textBox30.BackColor = Color.White;	
					textBox38.Text = (read["operator2"].ToString());	
					textBox38.BackColor = Color.White;	
					textBox46.Text = (read["operator3"].ToString());	
					textBox46.BackColor = Color.White;						
					}
				else {
					textBox30.Text = "0";
					textBox30.BackColor = Color.Red;
					textBox38.Text = "0";
					textBox38.BackColor = Color.Red;
					textBox46.Text = "0";
					textBox46.BackColor = Color.Red;
				}
				}	
		}
		void Button34Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 'SMP02' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox31.Text = (read["operator1"].ToString());	
					textBox31.BackColor = Color.White;	
					textBox39.Text = (read["operator2"].ToString());	
					textBox39.BackColor = Color.White;	
					textBox47.Text = (read["operator3"].ToString());	
					textBox47.BackColor = Color.White;						
					}
				else {
					textBox31.Text = "0";
					textBox31.BackColor = Color.Red;
					textBox39.Text = "0";
					textBox39.BackColor = Color.Red;
					textBox47.Text = "0";
					textBox47.BackColor = Color.Red;
				}
				}	
		}
		void Button33Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 'SMP03' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox32.Text = (read["operator1"].ToString());	
					textBox32.BackColor = Color.White;	
					textBox40.Text = (read["operator2"].ToString());	
					textBox40.BackColor = Color.White;	
					textBox48.Text = (read["operator3"].ToString());	
					textBox48.BackColor = Color.White;						
					}
				else {
					textBox32.Text = "0";
					textBox32.BackColor = Color.Red;
					textBox40.Text = "0";
					textBox40.BackColor = Color.Red;
					textBox48.Text = "0";
					textBox48.BackColor = Color.Red;
				}
				}	
		}
		void Button32Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 'SMP04' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox33.Text = (read["operator1"].ToString());	
					textBox33.BackColor = Color.White;	
					textBox41.Text = (read["operator2"].ToString());	
					textBox41.BackColor = Color.White;	
					textBox49.Text = (read["operator3"].ToString());	
					textBox49.BackColor = Color.White;						
					}
				else {
					textBox33.Text = "0";
					textBox33.BackColor = Color.Red;
					textBox41.Text = "0";
					textBox41.BackColor = Color.Red;
					textBox49.Text = "0";
					textBox49.BackColor = Color.Red;
				}
				}	
		}
		void Button31Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 'SMP05' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox34.Text = (read["operator1"].ToString());	
					textBox34.BackColor = Color.White;	
					textBox42.Text = (read["operator2"].ToString());	
					textBox42.BackColor = Color.White;	
					textBox50.Text = (read["operator3"].ToString());	
					textBox50.BackColor = Color.White;						
					}
				else {
					textBox34.Text = "0";
					textBox34.BackColor = Color.Red;
					textBox42.Text = "0";
					textBox42.BackColor = Color.Red;
					textBox50.Text = "0";
					textBox50.BackColor = Color.Red;
				}
				}		
		}
		void Button30Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND (Allomas = '01' OR Allomas = 'Halal') ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox35.Text = (read["operator1"].ToString());	
					textBox35.BackColor = Color.White;	
					textBox43.Text = (read["operator2"].ToString());	
					textBox43.BackColor = Color.White;	
					textBox51.Text = (read["operator3"].ToString());	
					textBox51.BackColor = Color.White;						
					}
				else {
					textBox35.Text = "0";
					textBox35.BackColor = Color.Red;
					textBox43.Text = "0";
					textBox43.BackColor = Color.Red;
					textBox51.Text = "0";
					textBox51.BackColor = Color.Red;
				}
				}	
		}
		void Button29Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND (Allomas = '02' OR Allomas = 'Haram') ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox36.Text = (read["operator1"].ToString());	
					textBox36.BackColor = Color.White;	
					textBox44.Text = (read["operator2"].ToString());	
					textBox44.BackColor = Color.White;	
					textBox52.Text = (read["operator3"].ToString());	
					textBox52.BackColor = Color.White;						
					}
				else {
					textBox36.Text = "0";
					textBox36.BackColor = Color.Red;
					textBox44.Text = "0";
					textBox44.BackColor = Color.Red;
					textBox52.Text = "0";
					textBox52.BackColor = Color.Red;
				}
				}	
		}
		void Button28Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaAKL WHERE Datum = ('" + dateTimePicker1.Text + "') AND (Allomas = '03' OR Allomas = 'Tartalék') ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox37.Text = (read["operator1"].ToString());	
					textBox37.BackColor = Color.White;	
					textBox45.Text = (read["operator2"].ToString());	
					textBox45.BackColor = Color.White;	
					textBox53.Text = (read["operator3"].ToString());	
					textBox53.BackColor = Color.White;						
					}
				else {
					textBox37.Text = "0";
					textBox37.BackColor = Color.Red;
					textBox45.Text = "0";
					textBox45.BackColor = Color.Red;
					textBox53.Text = "0";
					textBox53.BackColor = Color.Red;
				}
				}	
		}
		void Button43Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POS1' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox4.Text = (read["operator1"].ToString());	
					textBox4.BackColor = Color.White;	
					textBox12.Text = (read["operator2"].ToString());	
					textBox12.BackColor = Color.White;	
					textBox21.Text = (read["operator3"].ToString());	
					textBox21.BackColor = Color.White;						
					}
				else {
					textBox4.Text = "0";
					textBox4.BackColor = Color.Red;
					textBox12.Text = "0";
					textBox12.BackColor = Color.Red;
					textBox21.Text = "0";
					textBox21.BackColor = Color.Red;
				}
				}	
		}
		void Button42Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POS2' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox5.Text = (read["operator1"].ToString());	
					textBox5.BackColor = Color.White;	
					textBox13.Text = (read["operator2"].ToString());	
					textBox13.BackColor = Color.White;	
					textBox22.Text = (read["operator3"].ToString());	
					textBox22.BackColor = Color.White;						
					}
				else {
					textBox5.Text = "0";
					textBox5.BackColor = Color.Red;
					textBox13.Text = "0";
					textBox13.BackColor = Color.Red;
					textBox22.Text = "0";
					textBox22.BackColor = Color.Red;
				}
				}	
		}
		void Button41Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POS3' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox54.Text = (read["operator1"].ToString());	
					textBox54.BackColor = Color.White;	
					textBox14.Text = (read["operator2"].ToString());	
					textBox14.BackColor = Color.White;	
					textBox23.Text = (read["operator3"].ToString());	
					textBox23.BackColor = Color.White;						
					}
				else {
					textBox54.Text = "0";
					textBox54.BackColor = Color.Red;
					textBox14.Text = "0";
					textBox14.BackColor = Color.Red;
					textBox23.Text = "0";
					textBox23.BackColor = Color.Red;
				}
				}	
		}
		void Button40Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POS6' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox6.Text = (read["operator1"].ToString());	
					textBox6.BackColor = Color.White;	
					textBox15.Text = (read["operator2"].ToString());	
					textBox15.BackColor = Color.White;	
					textBox24.Text = (read["operator3"].ToString());	
					textBox24.BackColor = Color.White;						
					}
				else {
					textBox6.Text = "0";
					textBox6.BackColor = Color.Red;
					textBox15.Text = "0";
					textBox15.BackColor = Color.Red;
					textBox24.Text = "0";
					textBox24.BackColor = Color.Red;
				}
				}	
		}
		void Button39Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POS7' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox7.Text = (read["operator1"].ToString());	
					textBox7.BackColor = Color.White;	
					textBox16.Text = (read["operator2"].ToString());	
					textBox16.BackColor = Color.White;	
					textBox25.Text = (read["operator3"].ToString());	
					textBox25.BackColor = Color.White;						
					}
				else {
					textBox7.Text = "0";
					textBox7.BackColor = Color.Red;
					textBox16.Text = "0";
					textBox16.BackColor = Color.Red;
					textBox25.Text = "0";
					textBox25.BackColor = Color.Red;
				}
				}	
		}
		void Button38Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPAL WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'Palettázó' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox8.Text = (read["operator1"].ToString());	
					textBox8.BackColor = Color.White;	
					textBox17.Text = (read["operator2"].ToString());	
					textBox17.BackColor = Color.White;	
					textBox26.Text = (read["operator3"].ToString());	
					textBox26.BackColor = Color.White;						
					}
				else {
					textBox8.Text = "0";
					textBox8.BackColor = Color.Red;
					textBox17.Text = "0";
					textBox17.BackColor = Color.Red;
					textBox26.Text = "0";
					textBox26.BackColor = Color.Red;
				}
				}	
		}
		void Button37Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'Karton h' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox9.Text = (read["operator1"].ToString());	
					textBox9.BackColor = Color.White;	
					textBox18.Text = (read["operator2"].ToString());	
					textBox18.BackColor = Color.White;	
					textBox27.Text = (read["operator3"].ToString());	
					textBox27.BackColor = Color.White;						
					}
				else {
					textBox9.Text = "0";
					textBox9.BackColor = Color.Red;
					textBox18.Text = "0";
					textBox18.BackColor = Color.Red;
					textBox27.Text = "0";
					textBox27.BackColor = Color.Red;
				}
				}	
		}
		void Button36Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POSBG1' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox10.Text = (read["operator1"].ToString());	
					textBox10.BackColor = Color.White;	
					textBox19.Text = (read["operator2"].ToString());	
					textBox19.BackColor = Color.White;	
					textBox28.Text = (read["operator3"].ToString());	
					textBox28.BackColor = Color.White;						
					}
				else {
					textBox10.Text = "0";
					textBox10.BackColor = Color.Red;
					textBox19.Text = "0";
					textBox19.BackColor = Color.Red;
					textBox28.Text = "0";
					textBox28.BackColor = Color.Red;
				}
				}	
		}
		void Button44Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaPACK WHERE Datum = ('" + dateTimePicker1.Text + "') AND Gep = 'POS4' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox11.Text = (read["operator1"].ToString());	
					textBox11.BackColor = Color.White;	
					textBox20.Text = (read["operator2"].ToString());	
					textBox20.BackColor = Color.White;	
					textBox29.Text = (read["operator3"].ToString());	
					textBox29.BackColor = Color.White;						
					}
				else {
					textBox11.Text = "0";
					textBox11.BackColor = Color.Red;
					textBox20.Text = "0";
					textBox20.BackColor = Color.Red;
					textBox29.Text = "0";
					textBox29.BackColor = Color.Red;
				}
				}	
		}
		void Button45Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.szobaLIQ WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					comboBox1.Text = (read["operator1"].ToString());	
					comboBox1.BackColor = Color.White;	
					comboBox2.Text = (read["operator2"].ToString());	
					comboBox2.BackColor = Color.White;	
					comboBox3.Text = (read["operator3"].ToString());	
					comboBox3.BackColor = Color.White;						
					}
				else {
					comboBox1.Text = "0";
					comboBox1.BackColor = Color.Red;
					comboBox2.Text = "0";
					comboBox2.BackColor = Color.Red;
					comboBox3.Text = "0";
					comboBox3.BackColor = Color.Red;
				}
				}		
		}
		void NaplokLoad(object sender, EventArgs e)
		{
			if(button72.Text == "Lang")
			{
			button72.Text = "Nyelv";
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
			button72.BackgroundImage = myimage;
			label6.Text = "Töltöttség";
			chart1.Series["Naploszam"].LegendText = "Naploszam";
			chart1.Series["Hianyzo"].LegendText = "Hianyzo";		
			chart1.Series["Target"].YValueMembers = "Target";
			button3.Text = "Naplók";
			label11.Text = "Műszak:";
			}
			else if(button72.Text == "Nyelv")
			{
			button72.Text = "Lang";
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
		    button72.BackgroundImage = myimage;
			label6.Text = "Filled";			
			chart1.Series["Naploszam"].LegendText = "Lognumber";
			chart1.Series["Hianyzo"].LegendText = "Missing";		
			chart1.Series["Target"].YValueMembers = "Target";	
			button3.Text = "Logs";
			label11.Text = "Shift:";
			}
			Button1Click(null,null);
		}
		void Button72Click(object sender, EventArgs e)
		{
			if(button72.Text == "Lang")
			{
			button72.Text = "Nyelv";
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
			button72.BackgroundImage = myimage;
			label6.Text = "Töltöttség";
			chart1.Series["Naploszam"].LegendText = "Naploszam";
			chart1.Series["Hianyzo"].LegendText = "Hianyzo";		
			chart1.Series["Target"].YValueMembers = "Target";
			button3.Text = "Naplók";
			label11.Text = "Műszak:";
			}
			else if(button72.Text == "Nyelv")
			{
			button72.Text = "Lang";
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
		    button72.BackgroundImage = myimage;
			label6.Text = "Filled";			
			chart1.Series["Naploszam"].LegendText = "Lognumber";
			chart1.Series["Hianyzo"].LegendText = "Missing";		
			chart1.Series["Target"].YValueMembers = "Target";	
			button3.Text = "Logs";
			label11.Text = "Shift:";			
			}	
		}
		void Button46Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT Week, Naploszam, Hianyzo, Target FROM naploweek WHERE Year = YEAR(GETDATE()) ORDER BY Week", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("Naploszam");
			chart1.Series["Naploszam"].YValueMembers = "Naploszam";
			chart1.Series["Naploszam"].XValueMember = "Week";
			chart1.Series["Naploszam"].ChartType = SeriesChartType.StackedArea;
			chart1.Series["Naploszam"].LegendText = "Naploszam";
			chart1.Series["Naploszam"].Color = Color.Green;
			chart1.Series["Naploszam"].IsValueShownAsLabel = true;
			chart1.Series.Add("Hianyzo");
			chart1.Series["Hianyzo"].YValueMembers = "Hianyzo";
			chart1.Series["Hianyzo"].XValueMember = "Week";
			chart1.Series["Hianyzo"].LegendText = "Hianyzo";
			chart1.ChartAreas[0].AxisX.Title = "Week";
			chart1.ChartAreas[0].AxisX.Interval = 1;
			chart1.Series["Hianyzo"].IsValueShownAsLabel = true;
			chart1.Series["Hianyzo"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["Hianyzo"].Color = Color.Red;
			chart1.Series["Hianyzo"]["PixelPointWidth"] = "10";
			chart1.Series.Add("Target");
			chart1.Series["Target"].YValueMembers = "Target";
			chart1.Series["Target"].XValueMember = "Week";
			chart1.Series["Target"].ChartType = SeriesChartType.Line;
			chart1.Series["Series1"].IsVisibleInLegend = false;
		}
		void Button47Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			if(comboBox4.Text == "POS1" || comboBox4.Text == "POS2" || comboBox4.Text == "POS3" || comboBox4.Text == "POS4" || comboBox4.Text == "POSBG1" || comboBox4.Text == "POS6" || comboBox4.Text == "POS7" ||  comboBox4.Text == "Karton h")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Gep", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " szobában " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "SMP01" || comboBox4.Text == "SMP02" || comboBox4.Text == "SMP03" || comboBox4.Text == "SMP04" || comboBox4.Text == "SMP05" || comboBox4.Text == "01" || comboBox4.Text == "02" || comboBox4.Text == "03")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Allomas", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " állomáson " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "SMP01" || comboBox4.Text == "2" || comboBox4.Text == "3" || comboBox4.Text == "4" || comboBox4.Text == "5" || comboBox4.Text == "6" || comboBox4.Text == "9")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Allomas", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " állomáson " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "2" || comboBox4.Text == "3" || comboBox4.Text == "4" || comboBox4.Text == "5" || comboBox4.Text == "6" || comboBox4.Text == "7" ||comboBox4.Text == "9")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Allomas", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " állomáson " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "Diosna" || comboBox4.Text == "Henschel" || comboBox4.Text == "100" || comboBox4.Text == "500" || comboBox4.Text == "1501" || comboBox4.Text == "1502" || comboBox4.Text == "1503" || comboBox4.Text == "1504" || comboBox4.Text == "6001" || comboBox4.Text == "6002" || comboBox4.Text == "6003")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Gep", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " szobában " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "M20" || comboBox4.Text == "M60" || comboBox4.Text == "M450")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.SD (Datum, SD, Operator1)  VALUES 
			(@Datum, @SD, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@SD", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " szobában " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "R1601" || comboBox4.Text == "R4001" || comboBox4.Text == "Lödige")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.PF (Datum, Reactor, Operator1)  VALUES 
			(@Datum, @Reactor, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Reactor", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " szobában " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}
			else if(comboBox4.Text == "Palettázó")
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.Pal (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Gep", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen pótoltál " + comboBox4.Text + " szobában " + dateTimePicker1.Text + " dátummal", "Üzenet"); 
			Button1Click(null,null);
			}			
		}
		void Button47MouseMove(object sender, MouseEventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button47, ", Correct log");
	
		}
		void Button48Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
		DialogResult result2 = MessageBox.Show("Leállás volt az adott napon minden gépen?",
	    "Ellenőrzés",
	    MessageBoxButtons.YesNoCancel,
	    MessageBoxIcon.Question);
			if(result2 == DialogResult.Yes)
			{
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.Pal (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Gep", "Palettázó"));
			cmd.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd.ExecuteNonQuery();
			SqlCommand cmd1 = new SqlCommand(@"Insert into dbo.PF (Datum, Reactor, Operator1)  VALUES 
			(@Datum, @Reactor, @Operator1)",conn);
			cmd1.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd1.Parameters.Add(new SqlParameter("@Reactor", "R1601"));
			cmd1.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd1.ExecuteNonQuery();
			SqlCommand cmd2 = new SqlCommand(@"Insert into dbo.PF (Datum, Reactor, Operator1)  VALUES 
			(@Datum, @Reactor, @Operator1)",conn);
			cmd2.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd2.Parameters.Add(new SqlParameter("@Reactor", "R4001"));
			cmd2.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd2.ExecuteNonQuery();
			SqlCommand cmd3 = new SqlCommand(@"Insert into dbo.PF (Datum, Reactor, Operator1)  VALUES 
			(@Datum, @Reactor, @Operator1)",conn);
			cmd3.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd3.Parameters.Add(new SqlParameter("@Reactor", "Lödige"));
			cmd3.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd3.ExecuteNonQuery();
			SqlCommand cmd4 = new SqlCommand(@"Insert into dbo.SD (Datum, SD, Operator1)  VALUES 
			(@Datum, @SD, @Operator1)",conn);
			cmd4.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd4.Parameters.Add(new SqlParameter("@SD", "M20"));
			cmd4.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd4.ExecuteNonQuery();
			SqlCommand cmd5 = new SqlCommand(@"Insert into dbo.SD (Datum, SD, Operator1)  VALUES 
			(@Datum, @SD, @Operator1)",conn);
			cmd5.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd5.Parameters.Add(new SqlParameter("@SD", "M60"));
			cmd5.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd5.ExecuteNonQuery();
			SqlCommand cmd6 = new SqlCommand(@"Insert into dbo.SD (Datum, SD, Operator1)  VALUES 
			(@Datum, @SD, @Operator1)",conn);
			cmd6.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd6.Parameters.Add(new SqlParameter("@SD", "M450"));
			cmd6.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd6.ExecuteNonQuery();
			SqlCommand cmd7 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd7.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd7.Parameters.Add(new SqlParameter("@Gep", "Diosna"));
			cmd7.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd7.ExecuteNonQuery();
			SqlCommand cmd8 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd8.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd8.Parameters.Add(new SqlParameter("@Gep", "Henschel"));
			cmd8.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd8.ExecuteNonQuery();
			SqlCommand cmd9 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd9.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd9.Parameters.Add(new SqlParameter("@Gep", "100"));
			cmd9.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd9.ExecuteNonQuery();
			SqlCommand cmd10 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd10.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd10.Parameters.Add(new SqlParameter("@Gep", "500"));
			cmd10.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd10.ExecuteNonQuery();
			SqlCommand cmd11 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd11.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd11.Parameters.Add(new SqlParameter("@Gep", "1501"));
			cmd11.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd11.ExecuteNonQuery();
			SqlCommand cmd12 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd12.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd12.Parameters.Add(new SqlParameter("@Gep", "1502"));
			cmd12.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd12.ExecuteNonQuery();
			SqlCommand cmd13 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd13.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd13.Parameters.Add(new SqlParameter("@Gep", "1503"));
			cmd13.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd13.ExecuteNonQuery();
			SqlCommand cmd14 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd14.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd14.Parameters.Add(new SqlParameter("@Gep", "1504"));
			cmd14.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd14.ExecuteNonQuery();
			SqlCommand cmd15 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd15.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd15.Parameters.Add(new SqlParameter("@Gep", "6001"));
			cmd15.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd15.ExecuteNonQuery();
			SqlCommand cmd16 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd16.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd16.Parameters.Add(new SqlParameter("@Gep", "6002"));
			cmd16.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd16.ExecuteNonQuery();
			SqlCommand cmd17 = new SqlCommand(@"Insert into dbo.ble (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd17.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd17.Parameters.Add(new SqlParameter("@Gep", "6003"));
			cmd17.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd17.ExecuteNonQuery();
			SqlCommand cmd18 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd18.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd18.Parameters.Add(new SqlParameter("@Allomas", "2"));
			cmd18.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd18.ExecuteNonQuery();
			SqlCommand cmd19 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd19.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd19.Parameters.Add(new SqlParameter("@Allomas", "3"));
			cmd19.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd19.ExecuteNonQuery();
			SqlCommand cmd20 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd20.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd20.Parameters.Add(new SqlParameter("@Allomas", "4"));
			cmd20.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd20.ExecuteNonQuery();
			SqlCommand cmd21 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd21.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd21.Parameters.Add(new SqlParameter("@Allomas", "5"));
			cmd21.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd21.ExecuteNonQuery();
			SqlCommand cmd22 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd22.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd22.Parameters.Add(new SqlParameter("@Allomas", "6"));
			cmd22.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd22.ExecuteNonQuery();
			SqlCommand cmd23 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd23.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd23.Parameters.Add(new SqlParameter("@Allomas", "7"));
			cmd23.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd23.ExecuteNonQuery();
			SqlCommand cmd24 = new SqlCommand(@"Insert into dbo.BMPnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd24.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd24.Parameters.Add(new SqlParameter("@Allomas", "9"));
			cmd24.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd24.ExecuteNonQuery();
			SqlCommand cmd25 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd25.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd25.Parameters.Add(new SqlParameter("@Allomas", "SMP01"));
			cmd25.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd25.ExecuteNonQuery();
			SqlCommand cmd26 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd26.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd26.Parameters.Add(new SqlParameter("@Allomas", "SMP02"));
			cmd26.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd26.ExecuteNonQuery();
			SqlCommand cmd27 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd27.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd27.Parameters.Add(new SqlParameter("@Allomas", "SMP03"));
			cmd27.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd27.ExecuteNonQuery();
			SqlCommand cmd28 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd28.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd28.Parameters.Add(new SqlParameter("@Allomas", "SMP04"));
			cmd28.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd28.ExecuteNonQuery();
			SqlCommand cmd29 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd29.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd29.Parameters.Add(new SqlParameter("@Allomas", "SMP05"));
			cmd29.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd29.ExecuteNonQuery();
			SqlCommand cmd30 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd30.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd30.Parameters.Add(new SqlParameter("@Allomas", "01"));
			cmd30.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd30.ExecuteNonQuery();
			SqlCommand cmd31 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd31.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd31.Parameters.Add(new SqlParameter("@Allomas", "02"));
			cmd31.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd31.ExecuteNonQuery();
			SqlCommand cmd32 = new SqlCommand(@"Insert into dbo.AKLnap (Datum, Allomas, Operator1)  VALUES 
			(@Datum, @Allomas, @Operator1)",conn);
			cmd32.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd32.Parameters.Add(new SqlParameter("@Allomas", "03"));
			cmd32.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd32.ExecuteNonQuery();
			SqlCommand cmd33 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd33.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd33.Parameters.Add(new SqlParameter("@Gep", "POS1"));
			cmd33.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd33.ExecuteNonQuery();
			SqlCommand cmd34 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd34.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd34.Parameters.Add(new SqlParameter("@Gep", "POS2"));
			cmd34.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd34.ExecuteNonQuery();
			SqlCommand cmd35 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd35.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd35.Parameters.Add(new SqlParameter("@Gep", "POS3"));
			cmd35.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd35.ExecuteNonQuery();
			SqlCommand cmd36 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd36.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd36.Parameters.Add(new SqlParameter("@Gep", "POS4"));
			cmd36.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd36.ExecuteNonQuery();
			SqlCommand cmd37 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd37.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd37.Parameters.Add(new SqlParameter("@Gep", "POSBG1"));
			cmd37.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd37.ExecuteNonQuery();
			SqlCommand cmd38 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd38.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd38.Parameters.Add(new SqlParameter("@Gep", "POS6"));
			cmd38.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd38.ExecuteNonQuery();
			SqlCommand cmd39 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd39.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd39.Parameters.Add(new SqlParameter("@Gep", "POS7"));
			cmd39.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd39.ExecuteNonQuery();
			SqlCommand cmd40 = new SqlCommand(@"Insert into dbo.pack (Datum, Gep, Operator1)  VALUES 
			(@Datum, @Gep, @Operator1)",conn);
			cmd40.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd40.Parameters.Add(new SqlParameter("@Gep", "Karton h"));
			cmd40.Parameters.Add(new SqlParameter("@Operator1", ""));
			cmd40.ExecuteNonQuery();
			Button1Click(sender, e);			
			}	
		}

	}
}
