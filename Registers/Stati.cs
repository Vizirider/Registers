/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-20
 * Time: 07:55
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
	/// Description of Stati.
	/// </summary>
	public partial class Stati : Form
	{
		public Stati()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
					Button32Click(null,null);
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
		}
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			
			this.timer1.Start();
			Button1Click(null,null);
			Button2Click(null,null);
			Button3Click(null,null);
			Button4Click(null,null);
			Button6Click(null,null);
			Button5Click(null,null);
			Button8Click(null,null);
			Button7Click(null,null);
			Button9Click(null,null);
			Button10Click(null,null);
			Button12Click(null,null);
			Button11Click(null,null);
			Button14Click(null,null);
			Button13Click(null,null);
			
			Button16Click(null,null);
			Button18Click(null,null);
			Button20Click(null,null);
			Button22Click(null,null);
			Button24Click(null,null);
			Button25Click(null,null);

			Button15Click(null,null);
			Button17Click(null,null);
			Button19Click(null,null);
			Button21Click(null,null);
			Button23Click(null,null);
			Button31Click(null,null);
			Button30Click(null,null);
			Button29Click(null,null);
			Button28Click(null,null);
			Button27Click(null,null);
			Button26Click(null,null);
			Button33Click(null,null);


		}

		void Button1Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Osszregdatumonkent WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox1.Text = (read["Ossz"].ToString());		
					}
				}
		}
		void Button2Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Ossznincsregdatumonkent WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox2.Text = (read["Ossz"].ToString());
					}
				else{
					textBox2.Text = "0";
					textBox2.BackColor = Color.Green;
				}
				}	
		}
		void Button3Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nincsliqberegszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox4.Text = (read["Regszam"].ToString());
					textBox4.BackColor = Color.White;
					}
				else{
					textBox4.Text = "0";
					textBox4.BackColor = Color.Green;
				}
				}		
		}
		void Button4Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.liqregszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox3.Text = (read["Regiszterszam"].ToString());	
					textBox3.BackColor = Color.White;					
					}
				else{
					textBox3.Text = "0";
				}
				}	
		}
		void Button31Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.liqszazalek WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox31.Text = (read["Szazalek"].ToString());	
					textBox31.BackColor = Color.White;							
					}

				else{
					textBox31.Text = "100";
					textBox31.BackColor = Color.Green;
				}
				}
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nincsbmpberegszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox5.Text = (read["Regszam"].ToString());	
					textBox5.BackColor = Color.White;					
					}
				else {
					textBox5.Text = "0";
					textBox5.BackColor = Color.Green;
				}
				}	
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.bmpreg WHERE Termelesdatum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox6.Text = (read["Regiszterszam"].ToString());	
					textBox6.BackColor = Color.White;					
					}
				else{
					textBox6.Text = "0";
				}
				}	
		}
		void Button30Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.bmpszazalek WHERE Termelesdatum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox30.Text = (read["Szazalek"].ToString());		
					textBox30.BackColor = Color.White;
					}
				else{
					textBox30.Text = "100";
					textBox30.BackColor = Color.Green;
				}
				}	
		}
		void Button8Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nincsblendberegszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox7.Text = (read["Regszam"].ToString());	
					textBox7.BackColor = Color.White;					
					}
				else{
					textBox7.Text = "0";
					textBox7.BackColor = Color.Green;
				}
				}	
		}
		void Button7Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox8.Text = (read["Regszam"].ToString());	
					textBox8.BackColor = Color.White;					
					}
				else if(string.IsNullOrWhiteSpace(textBox8.Text)){
					textBox8.Text = (read["Nagy"].ToString());
				}
				else{
					textBox8.Text = (read["Kicsi"].ToString());					
				}
				}	
		}
		void Button29Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendszazalek WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox29.Text = (read["Szazalek"].ToString());		
					textBox29.BackColor = Color.White;
					}

				else{
					textBox29.Text = "100";
					textBox29.BackColor = Color.Green;
				}
	
				}
		}
		void Button10Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nincssdberegszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox9.Text = (read["Regszam"].ToString());	
					textBox9.BackColor = Color.White;					
					}
				else{
					textBox9.Text = "0";
					textBox9.BackColor = Color.Green;
				}
				}	
		}
		void Button9Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.sdregszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()){
					textBox10.Text = (read["Regiszterszam"].ToString());
					textBox10.BackColor = Color.White;					
				}
				else{
					textBox10.Text = "0";
				}
			}
		}
	
		void Button28Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.sdszazalek WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox28.Text = (read["Szazalek"].ToString());	
					textBox28.BackColor = Color.White;					
					}
				else{
					textBox28.Text = "100";
					textBox28.BackColor = Color.Green;
				}
				}	
		}
		void Button12Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nincspfberegszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox11.Text = (read["Regszam"].ToString());
					textBox11.BackColor = Color.White;					
					}
				else{
					textBox11.Text = "0";
					textBox11.BackColor = Color.Green;
				}
				}	
		}
		void Button11Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.pfregszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()){
					textBox12.Text = (read["Regiszterszam"].ToString());
					textBox12.BackColor = Color.White;					
				}
				else{
					textBox12.Text = "0";
				}
			}	
		}
		void Button27Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.pfszazalek WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox27.Text = (read["Szazalek"].ToString());	
					textBox27.BackColor = Color.White;								
					}
				else{
					textBox27.Text = "100";
					textBox27.BackColor = Color.Green;
				}
				}	
		}
		void Button14Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nincspackberegszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox13.Text = (read["Regszam"].ToString());	
					textBox13.BackColor = Color.White;					
					}
				else{
					textBox13.Text = "0";
					textBox13.BackColor = Color.Green;
				}
				}		
		}
		void Button13Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.packregszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()){
					textBox14.Text = (read["Regiszterszam"].ToString());
					textBox14.BackColor = Color.White;					
				}
				else{
					textBox14.Text = "0";
				}
			}	
		}
		void Button26Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.packszazalek WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox26.Text = (read["Szazalek"].ToString());		
					textBox26.BackColor = Color.White;
					}
				else{
					textBox26.Text = "100";
					textBox26.BackColor = Color.Green;
				}
				}	
		}
		void Button16Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.liqnemmegszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox20.Text = (read["Regszam"].ToString());	
					textBox20.BackColor = Color.White;					
					}
				else{
					textBox20.Text = "0";
					textBox20.BackColor = Color.Green;
				}
				}	
		}
		void Button18Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.bmpnemmegszam WHERE Termelesdatum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox19.Text = (read["Regszam"].ToString());	
					textBox19.BackColor = Color.White;					
					}
				else{
					textBox19.Text = "0";
					textBox19.BackColor = Color.Green;
				}
				}	
		}
		void Button20Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendnemmegsza WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox18.Text = (read["Regszam"].ToString());	
					textBox18.BackColor = Color.White;					
					}
				else{
					textBox18.Text = "0";
					textBox18.BackColor = Color.Green;
				}
				}	
		}
		void Button22Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.sdnemmegszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox17.Text = (read["Regszam"].ToString());	
					textBox17.BackColor = Color.White;					
					}
				else{
					textBox17.Text = "0";
					textBox17.BackColor = Color.Green;
				}
				}	
		}
		void Button24Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.pfnemmegszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox16.Text = (read["Regszam"].ToString());	
					textBox16.BackColor = Color.White;					
					}
				else{
					textBox16.Text = "0";
					textBox16.BackColor = Color.Green;
				}
				}	
		}
		void Button25Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.packnemmegszam WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox15.Text = (read["Regszam"].ToString());	
					textBox15.BackColor = Color.White;					
					}
				else{
					textBox15.Text = "0";
					textBox15.BackColor = Color.Green;
				}
				}		
		}
		void Button15Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nemmegliqszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox24.Text = (read["Regszam"].ToString());	
					textBox24.BackColor = Color.White;					
					}
				else{
					textBox24.Text = "0";
					textBox24.BackColor = Color.Green;
				}
				}	
		}
		void Button17Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nemmegaklszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox23.Text = (read["Regszam"].ToString());	
					textBox23.BackColor = Color.White;					
					}
				else{
					textBox23.Text = "0";
					textBox23.BackColor = Color.Green;
				}
				}	
		}
		void Button19Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nemmegbmpszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox22.Text = (read["Regszam"].ToString());	
					textBox22.BackColor = Color.White;					
					}
				else{
					textBox22.Text = "0";
					textBox22.BackColor = Color.Green;
				}
				}	
		}
		void Button21Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nemmegblendszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox21.Text = (read["Regszam"].ToString());	
					textBox21.BackColor = Color.White;					
					}
				else{
					textBox21.Text = "0";
					textBox21.BackColor = Color.Green;
				}
				}	
		}
		void Button23Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.nemmegpackszam WHERE Datum = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox25.Text = (read["Regszam"].ToString());	
					textBox25.BackColor = Color.White;					
					}
				else{
					textBox25.Text = "0";
					textBox25.BackColor = Color.Green;
				}
				}	
		}
		void Button32Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM chart ORDER BY Termeles", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("Felvittek");
			chart1.Series["Felvittek"].YValueMembers = "Osszfel";
			chart1.Series["Felvittek"].XValueMember = "Termeles";
			chart1.Series["Felvittek"].ChartType = SeriesChartType.StackedArea;
			chart1.Series.Add("Nem felvittek");
			chart1.Series["Nem felvittek"].YValueMembers = "Ossz";
			chart1.Series["Nem felvittek"].XValueMember = "Termeles";
			chart1.Series["Nem felvittek"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series.Add("Cél");
			chart1.Series["Cél"].YValueMembers = "Target";
			chart1.Series["Cél"].XValueMember = "Termeles";
			chart1.Series["Cél"].ChartType = SeriesChartType.Line;
			chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
			chart1.DataBind();			
			
		}
		void Button33Click(object sender, EventArgs e)
		{
//for input for pie chart..
            int i1 = int.Parse(textBox1.Text);
            int i2 = int.Parse(textBox2.Text);
 
            float total = i1 + i2;
            float deg1 = (i1 / total) * 360;
            float deg2 = (i2 / total) * 360;
            
            Pen p = new Pen(Color.Black, 2);
 
            Graphics g = this.CreateGraphics();
 
            Rectangle rec = new Rectangle(textBox1.Location.X + textBox1.Size.Width + 25, 65, 100, 100);
 
            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            
            g.Clear(Stati.DefaultBackColor);
            g.DrawPie(p, rec, 0, deg1);
            g.FillPie(b1, rec, 0, deg1);
            g.DrawPie(p, rec, deg1, deg2);
            g.FillPie(b2, rec, deg1, deg2);
          
		}
			
		}

	}
