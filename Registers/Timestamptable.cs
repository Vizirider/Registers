/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2017-05-05
 * Time: 00:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Registers
{
	/// <summary>
	/// Description of Timestamptable.
	/// </summary>
	public partial class Timestamptable : Form
	{
		public Timestamptable()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void fourliq()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.liqdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '4') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox1.Text = (read["Diff"].ToString());
			        textBox6.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox1.Text = "4";
			    	textBox1.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void twoliq()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.liqdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '2') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox2.Text = (read["Diff"].ToString());
			        textBox5.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox2.Text = "2";
			    	textBox5.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void oneliq()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.liqdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '1') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox3.Text = (read["Diff"].ToString());
			        textBox4.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox3.Text = "1";
			    	textBox4.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void okliq()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.liqdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = 'OK') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox12.Text = (read["Diff"].ToString());
			        textBox11.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox12.Text = "OK";
			    	textBox11.Text = "0";
			    }
			    read.Close();
			}
		}
		public void fourakl	()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.akldiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '4') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox24.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox24.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void twoakl()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.akldiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '2') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox23.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox23.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void oneakl()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.akldiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '1') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox22.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox22.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void okakl()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.akldiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = 'OK') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox15.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox15.Text = "0";
			    }
			    read.Close();
			}
		}
		public void fourbmp	()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.bmpdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '4') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox36.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox36.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void twobmp()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.bmpdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '2') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox35.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox35.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void onebmp()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.bmpdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '1') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox34.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox34.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void okbmp()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.bmpdiffpeptable WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = 'OK') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox27.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox27.Text = "0";
			    }
			    read.Close();
			}
		}
		
		public void fourble	()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.blenddifpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '4') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox48.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox48.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void twoble()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.blenddifpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '2') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox47.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox47.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void oneble()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.blenddifpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '1') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox46.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox46.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void okble()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.blenddifpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = 'OK') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox39.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox39.Text = "0";
			    }
			    read.Close();
			}
		}
		
		public void fourpack()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.packdiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '4') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox60.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox60.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void twopack()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.packdiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '2') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox59.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox59.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void onepack()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.packdiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = '1') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox58.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox58.Text = "0";
			    }
			    read.Close();
			}		
		}
		public void okpack()
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("SELECT SUM(POszam) AS POszam, Diff FROM dbo.packdiffpeptable WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND  ('" + dateTimePicker2.Text +"') AND (Diff = 'OK') GROUP BY Diff", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    if (read.Read())
			    {
			        textBox51.Text = (read["POszam"].ToString());
			    }
			    else{
			    	textBox51.Text = "0";
			    }
			    read.Close();
			}
		}


		void Button1Click(object sender, EventArgs e)
		{
			chart1.Series.Clear();
			chart2.Series.Clear();
			fourliq();
			twoliq();
			oneliq();
			okliq(); 
            float i1 = float.Parse(textBox6.Text);
            float i2 = float.Parse(textBox5.Text);
            float i3 = float.Parse(textBox4.Text);
            float i4 = float.Parse(textBox11.Text);  
            float sumliq = i1 + i2 + i3 + i4;
            textBox74.Text = sumliq.ToString();
            float l4 = i1 / sumliq * 100;
            textBox9.Text = l4.ToString("0.00") + " %";
            float l2 = i2 / sumliq * 100;
            textBox8.Text = l2.ToString("0.00") + " %";   
            float l1 = i3 / sumliq * 100;
            textBox7.Text = l1.ToString("0.00") + " %" ;
            float lok = i4 / sumliq * 100;
            textBox10.Text =  lok.ToString("0.00") + " %";
            float lno = 100 - lok;
            textBox73.Text = lno.ToString("0.00") + " %";
			fourakl();
			twoakl();
			oneakl();
			okakl();
            float j1 = float.Parse(textBox24.Text);
            float j2 = float.Parse(textBox23.Text);
            float j3 = float.Parse(textBox22.Text);
            float j4 = float.Parse(textBox15.Text);  
            float sumakl = j1 + j2 + j3 + j4;
            textBox72.Text = sumakl.ToString();
            float a4 = j1 / sumakl * 100;
            textBox21.Text = a4.ToString("0.00") + " %";
            float a2 = j2 / sumakl * 100;
            textBox20.Text = a2.ToString("0.00") + " %";   
            float a1 = j3 / sumakl * 100;
            textBox19.Text = a1.ToString("0.00") + " %" ;
            float aok = j4 / sumakl * 100;
            textBox14.Text =  aok.ToString("0.00") + " %";
            float ano = 100 - aok;
            textBox71.Text = ano.ToString("0.00") + " %";
            fourbmp();
            twobmp();
            onebmp();
            okbmp();
            float k1 = float.Parse(textBox36.Text);
            float k2 = float.Parse(textBox35.Text);
            float k3 = float.Parse(textBox34.Text);
            float k4 = float.Parse(textBox27.Text);  
            float sumbmp = k1 + k2 + k3 + k4;
            textBox69.Text = sumbmp.ToString();
            float b4 = k1 / sumbmp * 100;
            textBox33.Text = b4.ToString("0.00") + " %";
            float b2 = k2 / sumbmp * 100;
            textBox32.Text = b2.ToString("0.00") + " %";   
            float b1 = k3 / sumbmp * 100;
            textBox31.Text = b1.ToString("0.00") + " %" ;
            float bok = k4 / sumbmp * 100;
            textBox26.Text =  bok.ToString("0.00") + " %";
            float bno = 100 - bok;
            textBox68.Text = bno.ToString("0.00") + " %";
            fourble();
            twoble();
            oneble();
            okble();
            float m1 = float.Parse(textBox48.Text);
            float m2 = float.Parse(textBox47.Text);
            float m3 = float.Parse(textBox46.Text);
            float m4 = float.Parse(textBox39.Text);  
            float sumble = m1 + m2 + m3 + m4;
            textBox66.Text = sumble.ToString();
            float bl4 = m1 / sumble * 100;
            textBox45.Text = bl4.ToString("0.00") + " %";
            float bl2 = m2 / sumble * 100;
            textBox44.Text = bl2.ToString("0.00") + " %";   
            float bl1 = m3 / sumble * 100;
            textBox43.Text = bl1.ToString("0.00") + " %" ;
            float blok = m4 / sumble * 100;
            textBox38.Text =  blok.ToString("0.00") + " %";
            float blno = 100 - blok;
            textBox65.Text = blno.ToString("0.00") + " %";
            fourpack();
            twopack();
            onepack();
            okpack();
            float n1 = float.Parse(textBox60.Text);
            float n2 = float.Parse(textBox59.Text);
            float n3 = float.Parse(textBox58.Text);
            float n4 = float.Parse(textBox51.Text);  
            float sumpa = n1 + n2 + n3 + n4;
            textBox63.Text = sumpa.ToString();
            float p4 = n1 / sumpa * 100;
            textBox57.Text = p4.ToString("0.00") + " %";
            float p2 = n2 / sumpa * 100;
            textBox56.Text = p2.ToString("0.00") + " %";   
            float p1 = n3 / sumpa * 100;
            textBox55.Text = p1.ToString("0.00") + " %" ;
            float pok = n4 / sumpa * 100;
            textBox50.Text =  pok.ToString("0.00") + " %";
            float pno = 100 - pok;
            textBox62.Text = pno.ToString("0.00") + " %";
            float sumok = i4 + j4 + k4 + m4 + n4;
            textBox13.Text = sumok.ToString();
            float sum = sumliq + sumakl + sumbmp + sumble + sumpa;
            textBox17.Text = sum.ToString();
            float percentage = sumok / sum * 100;
            textBox16.Text = percentage.ToString("0.00") + " %";
            
            double lokp = Math.Round(lok, 2);
            double aokp = Math.Round(aok, 2);
            double bokp = Math.Round(bok, 2);
            double blokp = Math.Round(blok, 2);
            double pokp = Math.Round(pok, 2);    

            double lnop = Math.Round(lno, 2);
            double anop = Math.Round(ano, 2);
            double bnop = Math.Round(bno, 2);
            double blnop = Math.Round(blno, 2);
            double pnop = Math.Round(pno, 2);             

            double[] yValues = { lokp, aokp, bokp, blokp, pokp};
            double[] zValues = { lnop, anop, bnop, blnop, pnop};
		    string[] xNames = { "LIQ", "AKL", "BMP", "BLEND", "PACK OFF" };
		    chart1.Series.Add("OK");
		  	chart1.Series["OK"].Points.DataBindXY(xNames, yValues);
		  	chart1.Series["OK"].Color = Color.Green;
		  	chart1.Series["OK"].IsValueShownAsLabel = true;
		    chart1.Series.Add("LATE");
		  	chart1.Series["LATE"].Points.DataBindXY(xNames, zValues);
		  	chart1.Series["LATE"].Color = Color.Red;
		  	chart1.Series["LATE"].IsValueShownAsLabel = true;
		  	chart1.Series["OK"].ChartType = SeriesChartType.StackedColumn;
		  	chart1.Series["LATE"].ChartType = SeriesChartType.StackedColumn;
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT Month, LQ, AKL, BMP, BLEND, PACK, Expr1 AS 'ALL' FROM roctimetableall WHERE Year = YEAR(getdate()) ORDER BY Month", conn);
			dataAdapter1.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();

			DataGridViewColumn dataGridViewColumn1 = dataGridView1.Columns[1];
        	dataGridViewColumn1.HeaderCell.Style.BackColor = Color.Blue;	
			DataGridViewColumn dataGridViewColumn2 = dataGridView1.Columns[2];
        	dataGridViewColumn2.HeaderCell.Style.BackColor = Color.Brown;   
			DataGridViewColumn dataGridViewColumn3 = dataGridView1.Columns[3];
        	dataGridViewColumn3.HeaderCell.Style.BackColor = Color.Green; 
			DataGridViewColumn dataGridViewColumn4 = dataGridView1.Columns[4];
        	dataGridViewColumn4.HeaderCell.Style.BackColor = Color.Purple;
			DataGridViewColumn dataGridViewColumn5 = dataGridView1.Columns[5];
        	dataGridViewColumn5.HeaderCell.Style.BackColor = Color.Aqua;   
			DataGridViewColumn dataGridViewColumn6 = dataGridView1.Columns[6];
        	dataGridViewColumn6.HeaderCell.Style.BackColor = Color.Orange;         	
			chart2.DataSource = ds.Tables[0];
			chart2.Series.Add("LQ");
			chart2.Series["LQ"].YValueMembers = "LQ";
			chart2.Series["LQ"].XValueMember = "Month";
			chart2.Series["LQ"].ChartType = SeriesChartType.Line;
			chart2.Series["LQ"].LegendText = "LQ";
			chart2.Series["LQ"].Color = Color.Blue;
			chart2.Series["LQ"].BorderWidth = 3;
			chart2.Series.Add("AKL");
			chart2.Series["AKL"].YValueMembers = "AKL";
			chart2.Series["AKL"].XValueMember = "Month";
			chart2.Series["AKL"].LegendText = "AKL";
			chart2.ChartAreas[0].AxisX.Title = "Month";
			chart2.Series["AKL"].ChartType = SeriesChartType.Line;
			chart2.Series["AKL"].Color = Color.Brown;	
			chart2.Series["AKL"].BorderWidth = 3;
			chart2.Series.Add("BMP");
			chart2.Series["BMP"].YValueMembers = "BMP";
			chart2.Series["BMP"].XValueMember = "Month";
			chart2.Series["BMP"].LegendText = "BMP";
			chart2.ChartAreas[0].AxisX.Title = "Month";
			chart2.Series["BMP"].ChartType = SeriesChartType.Line;
			chart2.Series["BMP"].Color = Color.Green;
			chart2.Series["BMP"].BorderWidth = 3;
			chart2.Series.Add("BLEND");
			chart2.Series["BLEND"].YValueMembers = "BLEND";
			chart2.Series["BLEND"].XValueMember = "Month";
			chart2.Series["BLEND"].LegendText = "BLEND";
			chart2.ChartAreas[0].AxisX.Title = "Month";
			chart2.Series["BLEND"].ChartType = SeriesChartType.Line;
			chart2.Series["BLEND"].Color = Color.Purple;
			chart2.Series["BLEND"].BorderWidth = 3;
			chart2.Series.Add("PACK");
			chart2.Series["PACK"].YValueMembers = "PACK";
			chart2.Series["PACK"].XValueMember = "Month";
			chart2.Series["PACK"].LegendText = "PACK";
			chart2.ChartAreas[0].AxisX.Title = "Month";
			chart2.Series["PACK"].ChartType = SeriesChartType.Line;
			chart2.Series["PACK"].Color = Color.Aqua;
			chart2.Series["PACK"].BorderWidth = 3;
			chart2.Series.Add("ALL");
			chart2.Series["ALL"].YValueMembers = "ALL";
			chart2.Series["ALL"].XValueMember = "Month";
			chart2.Series["ALL"].LegendText = "ALL";
			chart2.ChartAreas[0].AxisX.Title = "Month";
			chart2.Series["ALL"].ChartType = SeriesChartType.Line;
			chart2.Series["ALL"].Color = Color.Orange;
			chart2.Series["ALL"].IsValueShownAsLabel = true;
			chart2.Series["ALL"].BorderWidth = 3;	
		}


	}
}
