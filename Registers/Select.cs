/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-23
 * Time: 08:34
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
using System.Drawing.Imaging;

namespace Liquidinster
{
	/// <summary>
	/// Description of Select.
	/// Main menu, which kind of register at Production
	/// </summary>
	public partial class Select : Form
	{
		
		public Select(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();	
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.textBox8.Text = mws;
			label2.Font = new Font(label2.Font.FontFamily, 6);
			button6.Font = new Font(label2.Font.FontFamily, 16);
		}
		void Button3Click(object sender, EventArgs e)
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

			conn.Close();
		MainForm mf = new MainForm(this.textBox8.Text, this.textBox8.Text, button9.Text);
		mf.Show();
		}
		void Button30Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\Production\14 REGISTER\registercooispi.bat";
			proc.StartInfo.WorkingDirectory = @"V:\Production\14 REGISTER";
			proc.Start();
	        MessageBox.Show("SAP szkript !!");
		}
		void Button5Click(object sender, EventArgs e)
		{
			LogReg f2 = new LogReg();
			f2.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
						
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
	
			SqlCommand cmd112 = new SqlCommand(@"insert into lodigea
    		select *
    		from lodige t1
    		where not exists (select * from lodigea t2 where t2.POszam = t1.POszam);",conn);
			cmd112.ExecuteNonQuery();
			
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
			SqlCommand cmd147 = new SqlCommand(@"DELETE FROM dbo.lodige  WHERE POszam IS NULL",conn);
			SqlCommand cmd148 = new SqlCommand(@"DELETE FROM dbo.lodigea  WHERE POszam IS NULL",conn);
			
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
			
//			SqlCommand cmd48 = new SqlCommand(
//			@"SET NOCOUNT ON
//			SET ROWCOUNT 1
//			WHILE 1 = 1
//			 BEGIN
//			   DELETE  
//			   FROM reportall
//			   WHERE POszam IN
//			        (SELECT  POszam
//			         FROM    reportall
//			         GROUP BY POszam
//			         HAVING  COUNT(*) > 1)
//			      IF @@Rowcount = 0
//			      BREAK;
//			 END
//			 SET ROWCOUNT 0",conn);
						SqlCommand cmd49 = new SqlCommand(
			@"SET NOCOUNT ON
			SET ROWCOUNT 1
			WHILE 1 = 1
			 BEGIN
			   DELETE  
			   FROM lodige
			   WHERE POszam IN
			        (SELECT  POszam
			         FROM    lodige
			         GROUP BY POszam
			         HAVING  COUNT(*) > 1)
			      IF @@Rowcount = 0
			      BREAK;
			 END
			 SET ROWCOUNT 0",conn);
						SqlCommand cmd50 = new SqlCommand(
			@"SET NOCOUNT ON
			SET ROWCOUNT 1
			WHILE 1 = 1
			 BEGIN
			   DELETE  
			   FROM lodigea
			   WHERE POszam IN
			        (SELECT  POszam
			         FROM    lodigea
			         GROUP BY POszam
			         HAVING  COUNT(*) > 1)
			      IF @@Rowcount = 0
			      BREAK;
			 END
			 SET ROWCOUNT 0",conn);
			
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
//			cmd48.ExecuteNonQuery();
			cmd49.ExecuteNonQuery();
			cmd50.ExecuteNonQuery();
			cmd147.ExecuteNonQuery();
			cmd148.ExecuteNonQuery();
			conn.Close();
			MainForm1 mf1 = new MainForm1(this.textBox8.Text, button9.Text);
			mf1.Show();
//			celebrate cb = new celebrate(this.textBox8.Text, button9.Text);
//			cb.Show();
		}
		void Button6Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			Blender bl = new Blender(this.textBox8.Text);
			bl.Show();
			SqlCommand cmd1 = new SqlCommand(@"DELETE FROM dbo.Blendertime  WHERE PO IS NULL",conn);
			SqlCommand cmd2 = new SqlCommand(@"DELETE FROM dbo.Blendertime1  WHERE PO IS NULL",conn);
			SqlCommand cmd3 = new SqlCommand(
			@"SET NOCOUNT ON
			SET ROWCOUNT 1
			WHILE 1 = 1
			 BEGIN
			   DELETE  
			   FROM Blendertime
			   WHERE PO IN
			        (SELECT  PO
			         FROM    Blendertime
			         GROUP BY PO
			         HAVING  COUNT(*) > 1)
			      IF @@Rowcount = 0
			      BREAK;
			 END
			 SET ROWCOUNT 0",conn);
			SqlCommand cmd4 = new SqlCommand(
			@"SET NOCOUNT ON
			SET ROWCOUNT 1
			WHILE 1 = 1
			 BEGIN
			   DELETE  
			   FROM Blendertime1
			   WHERE PO IN
			        (SELECT  PO
			         FROM    Blendertime1
			         GROUP BY PO
			         HAVING  COUNT(*) > 1)
			      IF @@Rowcount = 0
			      BREAK;
			 END
			 SET ROWCOUNT 0",conn);
			cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			cmd3.ExecuteNonQuery();
			cmd4.ExecuteNonQuery();
		}
		void Button7Click(object sender, EventArgs e)
		{
			Top top = new Top();
			top.Show();
		}
		void Button8Click(object sender, EventArgs e)
		{
			Stati stati = new Stati();
			stati.Show();
		}
		void Button9Click(object sender, EventArgs e)
		{
			// Language 
			if(button9.Text == "Lang")
			{
			label1.Text = "Hello";
			button5.Text = "Login";
			button4.Text = "PRODUCTION CHECK";
			button8.Text = "Daily Stat";
			button30.Text = "SAP update";
			label2.Text = "Developer: Robert Vizi robert.vizi@givaudan.com";
			button9.Text = "Nyelv";
			button10.Text = "AUDIT LOG";
		    Image myimage = new Bitmap(@"V:\Common (Don't share confidential docs here)\adminregisters\hun.png");
		    button9.BackgroundImage = myimage;
			}
			else if(button9.Text == "Nyelv")
			{
			label1.Text = "Üdv";
			button5.Text = "Belépett";
			button4.Text = "GYÁRTÁS ELLENŐRZÉS";
			button8.Text = "Napi stat";
			button30.Text = "SAP frissítés";
			button10.Text = "ELLENŐRZÉSI NAPLÓ";
			label2.Text = "Fejlesztő: Vizi Róbert robert.vizi@givaudan.com";
			button9.Text = "Lang";
		    Image myimage = new Bitmap(@"V:\Common (Don't share confidential docs here)\adminregisters\eng.png");
		    button9.BackgroundImage = myimage;				
			}
			
		}
		void Button10Click(object sender, EventArgs e)
		{
			naplok nap = new naplok();
			nap.Show();	
		}

	}
}
