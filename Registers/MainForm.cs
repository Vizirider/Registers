/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-05
 * Time: 14:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Liquidinster
{
	/// <summary>
	/// Description of MainForm.
	/// PepsiCo registers
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm(string mws, string PO, string lang)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			// Format week and datetimepicker to standard
			
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			
			button72.Text = lang;
			if(button72.Text == "Lang")
			{
			textBox10.Text = " " + weekNum + ". hét";	
			}
			else if(button72.Text == "Nyelv")
			{
			textBox10.Text = " " + weekNum + ". week";	
			}
			this.textBox11.Text = mws;
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "yyyy.MM.dd";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";			

		}

		void Button44Click(object sender, EventArgs e)
		{
			// Each stored procedure from production datatable to another 
			
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			
			SqlCommand cmd01 = new SqlCommand(@"insert into liquida
    		select *
    		from liquid t1
    		where not exists (select * from liquida t2 where t2.POszam = t1.POszam);",conn);
			cmd01.ExecuteNonQuery();
			
			SqlCommand cmd02 = new SqlCommand(@"insert into akla
    		select *
    		from akl t1
    		where not exists (select * from akla t2 where t2.POszam = t1.POszam);",conn);
			cmd02.ExecuteNonQuery();
			
			SqlCommand cmd03 = new SqlCommand(@"insert into bmpa
    		select *
    		from bmp t1
    		where not exists (select * from bmpa t2 where t2.POszam = t1.POszam);",conn);
			cmd03.ExecuteNonQuery();
			
			SqlCommand cmd04 = new SqlCommand(@"insert into blendinga
    		select *
    		from blending t1
    		where not exists (select * from blendinga t2 where t2.POszam = t1.POszam);",conn);
			cmd04.ExecuteNonQuery();
			
			SqlCommand cmd05 = new SqlCommand(@"insert into packingoffa
    		select *
    		from packingoff t1
    		where not exists (select * from packingoffa t2 where t2.POszam = t1.POszam);",conn);
			cmd05.ExecuteNonQuery();
			
			SqlCommand cmd06 = new SqlCommand(@"insert into liquidella
    		select *
    		from liquidell t1
    		where not exists (select * from liquidella t2 where t2.POszam = t1.POszam);",conn);
			cmd06.ExecuteNonQuery();
			
			SqlCommand cmd07 = new SqlCommand(@"insert into bmpella
    		select *
    		from bmpell t1
    		where not exists (select * from bmpella t2 where t2.POszam = t1.POszam);",conn);
			cmd07.ExecuteNonQuery();
			
			SqlCommand cmd08 = new SqlCommand(@"insert into blendella
    		select *
    		from blendell t1
    		where not exists (select * from blendella t2 where t2.POszam = t1.POszam);",conn);
			cmd08.ExecuteNonQuery();
			
			SqlCommand cmd09 = new SqlCommand(@"insert into blendkisella
    		select *
    		from blendkisell t1
    		where not exists (select * from blendkisella t2 where t2.POszam = t1.POszam);",conn);
			cmd09.ExecuteNonQuery();
			
			SqlCommand cmd010 = new SqlCommand(@"insert into packella
    		select *
    		from packell t1
    		where not exists (select * from packella t2 where t2.POszam = t1.POszam);",conn);
			cmd010.ExecuteNonQuery();
			
			SqlCommand cmd011 = new SqlCommand(@"insert into sdella
    		select *
    		from sdell t1
    		where not exists (select * from sdella t2 where t2.POszam = t1.POszam);",conn);
			cmd011.ExecuteNonQuery();
			
			SqlCommand cmd012 = new SqlCommand(@"insert into pfella
    		select *
    		from pfell t1
    		where not exists (select * from pfella t2 where t2.POszam = t1.POszam);",conn);
			cmd012.ExecuteNonQuery();
			
			SqlCommand cmd = new SqlCommand(@"DELETE FROM dbo.liquid  WHERE POszam IS NULL",conn);
			SqlCommand cmd1 = new SqlCommand(@"DELETE FROM dbo.liquida  WHERE POszam IS NULL",conn);
			SqlCommand cmd2 = new SqlCommand(@"DELETE FROM dbo.akl  WHERE POszam IS NULL",conn);
			SqlCommand cmd3 = new SqlCommand(@"DELETE FROM dbo.akla  WHERE POszam IS NULL",conn);
			SqlCommand cmd4 = new SqlCommand(@"DELETE FROM dbo.bmp  WHERE POszam IS NULL",conn);
			SqlCommand cmd5 = new SqlCommand(@"DELETE FROM dbo.bmpa  WHERE POszam IS NULL",conn);
			SqlCommand cmd6 = new SqlCommand(@"DELETE FROM dbo.blending  WHERE POszam IS NULL",conn);
			SqlCommand cmd7 = new SqlCommand(@"DELETE FROM dbo.blendinga  WHERE POszam IS NULL",conn);
			SqlCommand cmd8 = new SqlCommand(@"DELETE FROM dbo.packingoff  WHERE POszam IS NULL",conn);
			SqlCommand cmd9 = new SqlCommand(@"DELETE FROM dbo.packingoffa  WHERE POszam IS NULL",conn);
			SqlCommand cmd32 = new SqlCommand(@"DELETE FROM dbo.liquidell  WHERE POszam IS NULL",conn);
			SqlCommand cmd33 = new SqlCommand(@"DELETE FROM dbo.liquidella  WHERE POszam IS NULL",conn);
			SqlCommand cmd34 = new SqlCommand(@"DELETE FROM dbo.bmpell  WHERE POszam IS NULL",conn);
			SqlCommand cmd35 = new SqlCommand(@"DELETE FROM dbo.bmpella  WHERE POszam IS NULL",conn);
			SqlCommand cmd36 = new SqlCommand(@"DELETE FROM dbo.blendell  WHERE POszam IS NULL",conn);
			SqlCommand cmd37 = new SqlCommand(@"DELETE FROM dbo.blendella  WHERE POszam IS NULL",conn);
			SqlCommand cmd38 = new SqlCommand(@"DELETE FROM dbo.packell  WHERE POszam IS NULL",conn);
			SqlCommand cmd39 = new SqlCommand(@"DELETE FROM dbo.packella  WHERE POszam IS NULL",conn);
			SqlCommand cmd40 = new SqlCommand(@"DELETE FROM dbo.sdell  WHERE POszam IS NULL",conn);
			SqlCommand cmd41 = new SqlCommand(@"DELETE FROM dbo.sdella  WHERE POszam IS NULL",conn);
			SqlCommand cmd42 = new SqlCommand(@"DELETE FROM dbo.pfell  WHERE POszam IS NULL",conn);
			SqlCommand cmd43 = new SqlCommand(@"DELETE FROM dbo.pfella  WHERE POszam IS NULL",conn);
			SqlCommand cmd46 = new SqlCommand(@"DELETE FROM dbo.blendkisell  WHERE POszam IS NULL",conn);
			SqlCommand cmd47 = new SqlCommand(@"DELETE FROM dbo.blendkisella  WHERE POszam IS NULL",conn);
//			SqlCommand cmd10 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM liquid
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    liquid
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd11 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM liquida
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    liquida
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd12 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM akl
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    akl
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd13 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM akla
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    akla
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd14 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM bmp
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    bmp
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd15 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM bmpa
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    bmpa
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd16 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM blending
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    blending
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd17 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM blendinga
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    blendinga
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd18 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM packingoff
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    packingoff
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd19 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM packingoffa
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    packingoffa
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			
//			SqlCommand cmd20 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM liquidell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    liquidell
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd21 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM liquidella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    liquidella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd22 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM bmpell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    bmpell
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd23 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM bmpella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    bmpella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd24 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM blendell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    blendell
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd25 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM blendella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    blendella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd26 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM packell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    packell
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd27 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM packella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    packella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd28 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM sdell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    sdell
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd29 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM sdella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    sdella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd30 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM pfell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    pfell
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd31 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM pfella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    pfella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd44 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM blendkisell
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    blendkisella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
//			SqlCommand cmd45 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM blendkisella
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    blendkisella
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
			
			cmd.ExecuteNonQuery();
			cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			cmd3.ExecuteNonQuery();
			cmd4.ExecuteNonQuery();
			cmd5.ExecuteNonQuery();
			cmd6.ExecuteNonQuery();
			cmd7.ExecuteNonQuery();
			cmd8.ExecuteNonQuery();
			cmd9.ExecuteNonQuery();
//			cmd10.ExecuteNonQuery();
//			cmd11.ExecuteNonQuery();
//			cmd12.ExecuteNonQuery();
//			cmd13.ExecuteNonQuery();
//			cmd14.ExecuteNonQuery();
//			cmd15.ExecuteNonQuery();
//			cmd16.ExecuteNonQuery();
//			cmd17.ExecuteNonQuery();
//			cmd18.ExecuteNonQuery();
//			cmd19.ExecuteNonQuery();
//			cmd20.ExecuteNonQuery();
//			cmd21.ExecuteNonQuery();
//			cmd22.ExecuteNonQuery();
//			cmd23.ExecuteNonQuery();
//			cmd24.ExecuteNonQuery();
//			cmd25.ExecuteNonQuery();
//			cmd26.ExecuteNonQuery();
//			cmd27.ExecuteNonQuery();
//			cmd28.ExecuteNonQuery();
//			cmd29.ExecuteNonQuery();
//			cmd30.ExecuteNonQuery();
//			cmd31.ExecuteNonQuery();
			cmd32.ExecuteNonQuery();
			cmd33.ExecuteNonQuery();
			cmd34.ExecuteNonQuery();
			cmd35.ExecuteNonQuery();
			cmd36.ExecuteNonQuery();
			cmd37.ExecuteNonQuery();
			cmd38.ExecuteNonQuery();
			cmd39.ExecuteNonQuery();	
			cmd40.ExecuteNonQuery();
			cmd41.ExecuteNonQuery();
			cmd42.ExecuteNonQuery();
			cmd43.ExecuteNonQuery();
//			cmd44.ExecuteNonQuery();
//			cmd45.ExecuteNonQuery();
			cmd46.ExecuteNonQuery();
			cmd47.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen tisztítottad a listát, frissült. Beléphetsz újra", "Üzenet");
			this.Close();
		}
		void Button50Click(object sender, EventArgs e)
		{
			Liquidinsert lq = new Liquidinsert(this.textBox11.Text, this.textBox1.Text);
			lq.Show();
		}
		void Button42Click(object sender, EventArgs e)
		{
			Button61Click(sender, e);
			Button60Click(sender, e);
			Button59Click(sender, e);
			Button58Click(sender, e);
			Button57Click(sender, e);
			Button79Click(null,null);
		}
		void Button34Click(object sender, EventArgs e)
		{

				Nemfelvitt nf = new Nemfelvitt();
		        nf.Show();

		}
		void Button41Click(object sender, EventArgs e)
		{
			Button56Click(sender, e);
			Button55Click(sender, e);
			Button54Click(sender, e);
			Button53Click(sender, e);
			Button52Click(sender, e);
		}
		void Button61Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM liquida", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			dataGridView10.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquida", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox16.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
		}
		void Button60Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM akla", conn);
			dataAdapter2.Fill(ds);	
			dataGridView9.DataSource = ds.Tables[0];
			dataGridView9.AutoResizeColumns();
			dataGridView9.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM akla", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox15.Text = result.ToString();
    		}
		}
		void Button59Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM bmpa", conn);
			dataAdapter3.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpa", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox14.Text = result.ToString();
    		}		
		}
		void Button58Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM blendinga", conn);
			dataAdapter4.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendinga", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox13.Text = result.ToString();

			}	
		}
		void Button57Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM packingoffa", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packingoffa", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox12.Text = result.ToString();
    		}	
		}
		void Button56Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM liquida WHERE Ellenorizve IS NULL", conn);
			dataAdapter5.Fill(ds);	
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			dataGridView10.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquida WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox16.Text = result.ToString();
    		}	
		}
		void Button55Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM akla WHERE Ellenorizve IS NULL", conn);
			dataAdapter5.Fill(ds);	
			dataGridView9.DataSource = ds.Tables[0];
			dataGridView9.AutoResizeColumns();
			dataGridView9.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM akla WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox15.Text = result.ToString();
    		}
		}
		void Button54Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM bmpa WHERE Ellenorizve IS NULL", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpa WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox14.Text = result.ToString();
    		}	
		}
		void Button53Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM blendinga WHERE Ellenorizve IS NULL", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendinga WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox13.Text = result.ToString();
    		}	
		}
		void Button52Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM packingoffa WHERE Ellenorizve IS NULL", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packingoffa WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox12.Text = result.ToString();
    		}
		}
		void Button49Click(object sender, EventArgs e)
		{
			// Open akl form with textbox instance (username)
			Aklinsert akl = new Aklinsert(this.textBox11.Text);
			akl.Show();
		}
		void Button48Click(object sender, EventArgs e)
		{
			Bmpinsert bmp = new Bmpinsert(this.textBox11.Text);
			bmp.Show();	
		}
		void Button47Click(object sender, EventArgs e)
		{
			blendinginsert blend = new blendinginsert(this.textBox11.Text);
			blend.Show();		
		}
		void Button46Click(object sender, EventArgs e)
		{
			packingoffinsert pack = new packingoffinsert(this.textBox11.Text);
			pack.Show();	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			if(button72.Text == "Nyelv")
			{
		    Image myimage = new Bitmap(@"V:\Common (Don't share confidential docs here)\adminregisters\hun.png");
		    button72.BackgroundImage = myimage;
		    button42.Text = "All";
		    button73.Text = "Wrongs";
		    button41.Text = "Unchecked";
		    label17.Text = "Archive year";
			button34.Text = "Missing POs";
			button44.Text = "Update,Delete null rows, wrong POs";
			label8.Text = "table";
			label16.Text = "the PO number";
			label18.Text = "palletisation";	
			button71.Text = "delete";	
			button82.Text = "delete";			
			button43.Text = "Search";
			}
			else if(button72.Text == "Lang")
			{
		    Image myimage = new Bitmap(@"V:\Common (Don't share confidential docs here)\adminregisters\eng.png");
		    button72.BackgroundImage = myimage;
		    button42.Text = "Összes";
		    button73.Text = "Hibás";
		    button41.Text = "Ellenőrizetlen";
		    label17.Text = "Archív év";
			button34.Text = "Nem felvittek";
			button44.Text = "Frissítés, Törlés üres sorok, hibás PO-k";
			label8.Text = "táblázatos";
			label16.Text = "adott POszam";
			label18.Text = "palettázós";	
			button71.Text = "törlés";	
			button82.Text = "kivétel";
			button43.Text = "Keres";			
			}		
		}
		void DataGridView6CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Button43Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM liquida WHERE POszam LIKE ('" + textBox9.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			Button40Click(sender, e);
			Button38Click(sender, e);
			Button36Click(sender, e);
			Button35Click(sender, e);
			textBox16.Text = "";
			textBox15.Text = "";
			textBox14.Text = "";
			textBox13.Text = "";
			textBox12.Text = "";

		}
		void Button40Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM akla WHERE POszam LIKE ('" + textBox9.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView9.DataSource = ds.Tables[0];
			dataGridView9.AutoResizeColumns();
		}
		void Button38Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM bmpa WHERE POszam LIKE ('" + textBox9.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
		}
		void Button36Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM blendinga WHERE POszam LIKE ('" + textBox9.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
		}
		void Button35Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM packingoffa WHERE POszam LIKE ('" + textBox9.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
		}
		void Button51Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1(this.textBox11.Text);
			f1.Show();
		}
		void Button62Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4(this.textBox11.Text);
			f4.Show();
		}
		void Button65Click(object sender, EventArgs e)
		{
			Form5 f5 = new Form5(this.textBox11.Text);
			f5.Show();
		}
		void Button64Click(object sender, EventArgs e)
		{
			Form6 f6 = new Form6(this.textBox11.Text);
			f6.Show();
	
		}
		void Button63Click(object sender, EventArgs e)
		{
			Form7 f7 = new Form7(this.textBox11.Text);
			f7.Show();
		
		}
		void Button45Click(object sender, EventArgs e)
		{
			Liquid liq = new Liquid(this.textBox11.Text,this.textBox9.Text);
			liq.Show();
		}
		void Button66Click(object sender, EventArgs e)
		{
			aklro akl = new aklro(this.textBox11.Text,this.textBox9.Text);
			akl.Show();	
		}
		void Button69Click(object sender, EventArgs e)
		{
			bmpro bmp = new bmpro(this.textBox11.Text,this.textBox9.Text);
			bmp.Show();	
		}
		void Button68Click(object sender, EventArgs e)
		{
			blendr blend = new blendr(this.textBox11.Text,this.textBox9.Text);
			blend.Show();	
		}
		void Button67Click(object sender, EventArgs e)
		{
			packrcs pack = new packrcs(this.textBox11.Text,this.textBox9.Text);
			pack.Show();	
		}
		void Button70Click(object sender, EventArgs e)
		{
			
			// Pepsico excel from V folder
			if(comboBox1.Text == ""){
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2014-2015.xlsx";
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2016.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();
	        MessageBox.Show("Excel 2014-2015-2016 archív!");
			}
			else if(comboBox1.Text == "2014-2015"){
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2014-2015.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();
	        MessageBox.Show("Excel 2014-2015 archív!");			
			}
			else if(comboBox1.Text == "2016"){
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2016.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();
	        MessageBox.Show("Excel 2016 archív!");				
			}
		}
		void Button71Click(object sender, EventArgs e)
		{
		DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Register from " + comboBox2.Text, MessageBoxButtons.YesNo);
		if(dialogResult == DialogResult.Yes)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			if(comboBox2.Text == "liquid")
			{
			SqlCommand cmd1 = new SqlCommand(@"DELETE FROM dbo.liquid  WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommand cmd2 = new SqlCommand(@"DELETE FROM dbo.liquida  WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "akl")
			{
			SqlCommand cmd3 = new SqlCommand(@"DELETE FROM dbo.akl  WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommand cmd4 = new SqlCommand(@"DELETE FROM dbo.akla  WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			cmd4.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "bmp")
			{
			SqlCommand cmd5 = new SqlCommand(@"DELETE FROM dbo.bmp  WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommand cmd6 = new SqlCommand(@"DELETE FROM dbo.bmpa  WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd5.ExecuteNonQuery();
			cmd6.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "blending")
			{
			SqlCommand cmd7 = new SqlCommand(@"DELETE FROM dbo.blending  WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommand cmd8 = new SqlCommand(@"DELETE FROM dbo.blendinga  WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd7.ExecuteNonQuery();
			cmd8.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "packingoff")
			{
			SqlCommand cmd9 = new SqlCommand(@"DELETE FROM dbo.packingoff  WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommand cmd10 = new SqlCommand(@"DELETE FROM dbo.packingoffa  WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd9.ExecuteNonQuery();
			cmd10.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "PEPSICO")
			{
			SqlCommand cmd11 = new SqlCommand(@"DELETE FROM dbo.pepsiall  WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommand cmd12 = new SqlCommand(@"DELETE FROM dbo.pepsiall  WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd11.ExecuteNonQuery();
			cmd12.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			conn.Close();
		}
		else{
			
		}
		}

		void Button73Click(object sender, EventArgs e)
		{
			Button74Click(sender, e);
			Button75Click(sender, e);
			Button76Click(sender, e);
			Button77Click(sender, e);
			Button78Click(sender, e);
		}
		void Button73MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button25, "Nem megfelelőségek");		
		}
		void Button74Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM nemmegliq WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			dataGridView10.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmegliq WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox16.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
	
		}
		void Button75Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM nemmegakl WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView9.DataSource = ds.Tables[0];
			dataGridView9.AutoResizeColumns();
			dataGridView9.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmegakl WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox15.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
	
		}
		void Button76Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM nemmegbmp WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') ", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmegbmp WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox14.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
		}
		void Button77Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM nemmegblend WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmegblend WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox13.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
	
		}
		void Button78Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM nemmegpack WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmegpack WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox12.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
		}
		void DataGridView10CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime date = Convert.ToDateTime("2016-08-21");
			if(dateTimePicker1.Value < date){			
			Liquido liqo = new Liquido(this.textBox11.Text, this.dataGridView10.CurrentCell.Value.ToString());
			liqo.Show();	
			}
			else{
			Liquid liq = new Liquid(this.textBox11.Text, this.dataGridView10.CurrentCell.Value.ToString());
			liq.Show();				
			}
		}
		void DataGridView9CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime date = Convert.ToDateTime("2016-08-21");
		
			if(dateTimePicker1.Value < date){
			aklro aklo = new aklro(this.textBox11.Text,this.dataGridView9.CurrentCell.Value.ToString());
			aklo.Show();					
			}
			else{
			aklr akl = new aklr(this.textBox11.Text,this.dataGridView9.CurrentCell.Value.ToString());
			akl.Show();	
			}
		}
		void DataGridView8CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime date = Convert.ToDateTime("2016-08-21");
			if(dateTimePicker1.Value < date){
			bmpro bmpo = new bmpro(this.textBox11.Text, this.dataGridView8.CurrentCell.Value.ToString());
			bmpo.Show();	
			}
			else{
			bmpr bmp = new bmpr(this.textBox11.Text, this.dataGridView8.CurrentCell.Value.ToString());
			bmp.Show();				
			}
		}
		void DataGridView7CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime date = Convert.ToDateTime("2016-08-21");
			if(dateTimePicker1.Value < date){
			blendro blendo = new blendro(this.textBox11.Text,this.dataGridView7.CurrentCell.Value.ToString());
			blendo.Show();				
			}
			else{
			blendr blend = new blendr(this.textBox11.Text,this.dataGridView7.CurrentCell.Value.ToString());
			blend.Show();
			}
		}
		void DataGridView6CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime date = Convert.ToDateTime("2016-08-21");
			if(dateTimePicker1.Value < date){
			packrcso packo = new packrcso(this.textBox11.Text,this.dataGridView6.CurrentCell.Value.ToString());
			packo.Show();	
			}
			else{
			packrcs pack = new packrcs(this.textBox11.Text,this.dataGridView6.CurrentCell.Value.ToString());
			pack.Show();	
			}
		}
		void Button79Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT Batch, Operator1 FROM packingoffpal WHERE Datum = ('" + dateTimePicker1.Text +"')", conn);
			dataAdapter4.Fill(ds);	
			dataGridView11.DataSource = ds.Tables[0];
			dataGridView11.AutoResizeColumns();
			dataGridView11.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM packingoffpal WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox17.Text = result.ToString();

			}		
		}
		void DataGridView11CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			paletta pal = new paletta(this.dataGridView11.CurrentCell.Value.ToString());
			pal.Show();		
		}
		void Button72Click(object sender, EventArgs e)
		{
			
			// Language selector
			if(button72.Text == "Lang")
			{
			button72.Text = "Nyelv";
		    Image myimage = new Bitmap(@"V:\Common (Don't share confidential docs here)\adminregisters\hun.png");
		    button72.BackgroundImage = myimage;
		    button42.Text = "All";
		    button73.Text = "Wrongs";
		    button41.Text = "Unchecked";
		    label17.Text = "Archive year";
			button34.Text = "Missing POs";
			button44.Text = "Update,Delete null rows, wrong POs";
			label8.Text = "table";
			label16.Text = "the PO number";
			label18.Text = "palletisation";			
			label7.Text = "POnumber";
			button71.Text = "delete";
			button43.Text = "Search";
			}
			else if(button72.Text == "Nyelv")
			{
			button72.Text = "Lang";
		    Image myimage = new Bitmap(@"V:\Common (Don't share confidential docs here)\adminregisters\eng.png");
		    button72.BackgroundImage = myimage;
		    button42.Text = "Összes";
		    button73.Text = "Hibás";
		    button41.Text = "Ellenőrizetlen";
		    label17.Text = "Archív év";
			button34.Text = "Nem felvittek";
			button44.Text = "Frissítés, Törlés üres sorok, hibás PO-k";
			label8.Text = "táblázatos";
			label16.Text = "adott POszam";
			label18.Text = "palettázós";
			label7.Text = "POszam";		
			button71.Text = "törlés";		
			button43.Text = "Keres";	
			}			
		}
		void Button80Click(object sender, EventArgs e)
		{
			Statpep stp = new Statpep();
			stp.Show();
		}
		void Button81Click(object sender, EventArgs e)
		{
			QMtabla qm = new QMtabla();
			qm.Show();
		}
		void TextBox9KeyUp(object sender, KeyEventArgs e)
		{
			
			// Search for the PO-s in each Production Area
			if (e.KeyCode == Keys.Enter)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ki FROM liquida WHERE POszam LIKE ('" + textBox9.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			Button40Click(sender, e);
			Button38Click(sender, e);
			Button36Click(sender, e);
			Button35Click(sender, e);
			textBox16.Text = "";
			textBox15.Text = "";
			textBox14.Text = "";
			textBox13.Text = "";
			textBox12.Text = "";
			}
		}
		void Button82Click(object sender, EventArgs e)
		{
		DialogResult dialogResult = MessageBox.Show("Are you sure?", "n/a in " + comboBox2.Text, MessageBoxButtons.YesNo);
		if(dialogResult == DialogResult.Yes)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			if(comboBox2.Text == "liquid")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [LIQ] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "akl")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [AKL] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "bmp")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [BMP] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "blending")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [BLEND] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "packingoff")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [PACK_OFF] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			conn.Close();
		}
		else{
			
		}
	
		}


	}
}
