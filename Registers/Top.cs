/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-13
 * Time: 08:18
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

namespace Liquidinster
{
	/// <summary>
	/// Description of Top.
	/// </summary>
	///  Top scores of users of registers
	public partial class Top : Form
	{
		public Top()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Button1Click(null,null);
			Button2Click(null,null);
			Button3Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT Operátor, Kitöltött FROM Kitoltottnevesall ORDER BY Kitöltött DESC", conn);
			dataAdapter1.Fill(ds);	
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT Ellenorzo, Töltött FROM Javitott ORDER BY Töltött DESC ", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();		
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT Felhasználó, Hasznalta FROM belepett ORDER BY Hasznalta DESC", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();		
		}
		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Operátor, Kitöltött FROM Kitoltottnevesall WHERE Operátor LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();	
		}
		void Button4Click(object sender, EventArgs e)
		{
			Button5Click(null,null);
			Button6Click(null,null);
			Button7Click(null,null);
			Button8Click(null,null);
			Button9Click(null,null);	
            textBox2.BackColor = (Color.Orange);
            textBox3.BackColor = (Color.Red);
            textBox4.BackColor = (Color.DeepSkyBlue);
            textBox5.BackColor = (Color.Green);			
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Duna ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox2.Text = (read["Javitott"].ToString());		
					}	
		}
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Tisza", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox3.Text = (read["Javitott"].ToString());		
					}	
		}
		}
		void Button7Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Kőrös", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox4.Text = (read["Javitott"].ToString());		
					}	
		}
		}
		void Button8Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Maros", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox5.Text = (read["Javitott"].ToString());		
					}	
		}
		}
		void Button9Click(object sender, EventArgs e)
		{
//for input for pie chart..
            int i1 = int.Parse(textBox2.Text);
            int i2 = int.Parse(textBox3.Text);
            int i3 = int.Parse(textBox4.Text);
            int i4 = int.Parse(textBox5.Text);
            
            float total = i1 + i2 + i3 + i4;
            float deg1 = (i1 / total) * 360;
            float deg2 = (i2 / total) * 360;
            float deg3 = (i3 / total) * 360;
            float deg4 = (i4 / total) * 360;
            
            Pen p = new Pen(Color.Black, 2);
 
            Graphics g = this.CreateGraphics();
 
            Rectangle rec = new Rectangle(label4.Location.X - 100, 310, 80, 80);
 
            Brush b1 = new SolidBrush(Color.Orange);
            Brush b2 = new SolidBrush(Color.Red);
            Brush b3 = new SolidBrush(Color.DeepSkyBlue);
            Brush b4 = new SolidBrush(Color.Green);
            
            g.Clear(Stati.DefaultBackColor);
            g.DrawPie(p, rec, 0, deg1);
            g.FillPie(b1, rec, 0, deg1);
            g.DrawPie(p, rec, deg1, deg2);
            g.FillPie(b2, rec, deg1, deg2);
            g.DrawPie(p, rec, deg2 + deg1, deg3);
            g.FillPie(b3, rec, deg2 + deg1, deg3);
            g.DrawPie(p, rec, deg3 + deg2 + deg1, deg4);
            g.FillPie(b4, rec, deg3 + deg2 + deg1, deg4);      	
		}
		void TextBox6KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Felhasználó, Hasznalta FROM belepett WHERE Felhasználó LIKE ('" + textBox6.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();		
		}
	}
}
