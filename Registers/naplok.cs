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
		public naplok()
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
		}
		void Button1Click(object sender, EventArgs e)
		{
			Button2Click(null,null);
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

        MessageBox.Show("Hiányzó naplók: " + countTB + " Kitöltött naplók: " + countTG + " Ez százalékosan: " + pro + "%");	

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
					textBox129.Text = (read["operator1"].ToString());	
					textBox129.BackColor = Color.White;	
					textBox128.Text = (read["operator2"].ToString());	
					textBox128.BackColor = Color.White;	
					textBox127.Text = (read["operator3"].ToString());	
					textBox127.BackColor = Color.White;						
					}
				else {
					textBox129.Text = "0";
					textBox129.BackColor = Color.Red;
					textBox128.Text = "0";
					textBox128.BackColor = Color.Red;
					textBox127.Text = "0";
					textBox127.BackColor = Color.Red;
				}
				}		
		}
	}
}
