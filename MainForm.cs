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
		
		public void Refresh(){
			Button41Click(null,null);
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
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
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
		//    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
	//	    button72.BackgroundImage = myimage;
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
			Liquid liq = new Liquid(this.textBox11.Text,this.textBox9.Text, this);
			liq.Show();
		}
		void Button66Click(object sender, EventArgs e)
		{
			aklro akl = new aklro(this.textBox11.Text,this.textBox9.Text, this);
			akl.Show();	
		}
		void Button69Click(object sender, EventArgs e)
		{
			bmpro bmp = new bmpro(this.textBox11.Text,this.textBox9.Text, this);
			bmp.Show();	
		}
		void Button68Click(object sender, EventArgs e)
		{
			blendr blend = new blendr(this.textBox11.Text,this.textBox9.Text, this);
			blend.Show();	
		}
		void Button67Click(object sender, EventArgs e)
		{
			packrcs pack = new packrcs(this.textBox11.Text,this.textBox9.Text, this);
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
			DateTime Valtoztatas = Convert.ToDateTime("2016-08-21");
			
			DateTime Valtoztatas1 = Convert.ToDateTime("2017-10-15");

			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Datum from dbo.liquida WHERE POszam = ('" +this.dataGridView10.CurrentCell.Value.ToString() + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();					

				while (read.Read()) {
					string Datum = read["Datum"].ToString();
					DateTime Termeles = Convert.ToDateTime(Datum);					
					if(Termeles < Valtoztatas){
					Liquido liqo = new Liquido(this.textBox11.Text,this.dataGridView10.CurrentCell.Value.ToString(), this);
					liqo.Show();
			        }
					else if(Termeles > Valtoztatas && Termeles < Valtoztatas1){
					Liquid liq = new Liquid(this.textBox11.Text,this.dataGridView10.CurrentCell.Value.ToString(), this);
					liq.Show();
					}
					else if(Termeles >= Valtoztatas1){
					Registers.Liquidnew liqn = new Registers.Liquidnew(this.textBox11.Text,this.dataGridView10.CurrentCell.Value.ToString(), this);
					liqn.Show();			
					}
				}
				
			}
		}
		void DataGridView9CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime Valtoztatas = Convert.ToDateTime("2016-08-21");
			
			DateTime Valtoztatas1 = Convert.ToDateTime("2017-10-15");

			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Datum from dbo.akla WHERE POszam = ('" +this.dataGridView9.CurrentCell.Value.ToString() + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();					

				while (read.Read()) {
					string Datum = read["Datum"].ToString();
					DateTime Termeles = Convert.ToDateTime(Datum);					
					if(Termeles < Valtoztatas){
					aklro aklo = new aklro(this.textBox11.Text,this.dataGridView9.CurrentCell.Value.ToString(), this);
					aklo.Show();
			        }
					else if(Termeles > Valtoztatas && Termeles < Valtoztatas1){
					aklr akl = new aklr(this.textBox11.Text,this.dataGridView9.CurrentCell.Value.ToString(), this);
					akl.Show();
					}
					else if(Termeles >= Valtoztatas1){
					Registers.aklnew liqn = new Registers.aklnew(this.textBox11.Text,this.dataGridView9.CurrentCell.Value.ToString(), this);
					liqn.Show();			
					}
				}
				
			}
		}
		void DataGridView8CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime Valtoztatas = Convert.ToDateTime("2016-08-21");
			DateTime Valtoztatas1 = Convert.ToDateTime("2017-10-15");

			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Datum from dbo.bmpa WHERE POszam = ('" +this.dataGridView8.CurrentCell.Value.ToString() + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();					

				while (read.Read()) {
					string Datum = read["Datum"].ToString();
					DateTime Termeles = Convert.ToDateTime(Datum);					
					if(Termeles < Valtoztatas){
					bmpro bmpo = new bmpro(this.textBox11.Text,this.dataGridView8.CurrentCell.Value.ToString(), this);
					bmpo.Show();
			        }
					else if(Termeles > Valtoztatas && Termeles < Valtoztatas1){
					bmpr bmp = new bmpr(this.textBox11.Text,this.dataGridView8.CurrentCell.Value.ToString(), this);
					bmp.Show();
					}
					else if(Termeles >= Valtoztatas1){
					Registers.bmpruj bmpr = new Registers.bmpruj(this.textBox11.Text,this.dataGridView8.CurrentCell.Value.ToString(), this);
					bmpr.Show();
					}
				}
				
			}
		}
		void DataGridView7CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DateTime Valtoztatas = Convert.ToDateTime("2016-08-21");
			DateTime Valtoztatas1 = Convert.ToDateTime("2017-10-15");

			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendinga WHERE POszam = ('" +this.dataGridView7.CurrentCell.Value.ToString() + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();					

				while (read.Read()) {
					String Datum = read["Datum"].ToString();
					DateTime Termeles = Convert.ToDateTime(Datum);	
					if (read["1504e"].ToString() != "True") {
						if(Termeles < Valtoztatas){		
								blendro blendo = new blendro(this.textBox11.Text,this.dataGridView7.CurrentCell.Value.ToString(), this);
								blendo.Show();							
						}
						else if(Termeles > Valtoztatas && Termeles < Valtoztatas1){
								blendr blend = new blendr(this.textBox11.Text,this.dataGridView7.CurrentCell.Value.ToString(), this);
								blend.Show();	
						}
						else if(Termeles >= Valtoztatas1){
					Registers.blendruj blendruj = new Registers.blendruj(this.textBox11.Text,this.dataGridView7.CurrentCell.Value.ToString(), this);
					blendruj.Show();						    		  
						}
					} 
					else {				
						Registers.blendpepsi pepsiblend = new Registers.blendpepsi(this.textBox11.Text,this.dataGridView7.CurrentCell.Value.ToString(), this);
						pepsiblend.Show();
					}
				}
				
			}
		}
		void DataGridView6CellClick(object sender, DataGridViewCellEventArgs e)
		{

			DateTime Valtoztatas = Convert.ToDateTime("2016-08-21");
			DateTime Valtoztatas1 = Convert.ToDateTime("2017-10-15");

			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Datum from dbo.packingoffa WHERE POszam = ('" +this.dataGridView6.CurrentCell.Value.ToString() + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();					

				while (read.Read()) {
					string Datum = read["Datum"].ToString();
					DateTime Termeles = Convert.ToDateTime(Datum);					
					if(Termeles < Valtoztatas){
					packrcso packo = new packrcso(this.textBox11.Text,this.dataGridView6.CurrentCell.Value.ToString(), this);
					packo.Show();
			        }
					else if(Termeles >= Valtoztatas1){
					Registers.packuj packuj = new Registers.packuj(this.textBox11.Text,this.dataGridView6.CurrentCell.Value.ToString(), this);
					packuj.Show();	
					}
					else if (Termeles > Valtoztatas && Termeles < Valtoztatas1){
					packrcs pack = new packrcs(this.textBox11.Text,this.dataGridView6.CurrentCell.Value.ToString(), this);
					pack.Show();
					}
				}
				
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
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
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
			button82.Text = "drops";
			button43.Text = "Search";
			}
			else if(button72.Text == "Nyelv")
			{
			button72.Text = "Lang";
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
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
			button82.Text = "kivétel";			
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
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[pepsiall] SET [LIQ] = 'n/a' WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "akl")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[pepsiall] SET [AKL] = 'n/a' WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "bmp")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[pepsiall] SET [BMP] = 'n/a' WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "blending")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[pepsiall] SET [BLEND] = 'n/a' WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "packingoff")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[pepsiall] SET [PACK_OFF] = 'n/a' WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			else if(comboBox2.Text == "PEPSICO")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[pepsiall] SET [PACK_OFF] = 'n/a', [BLEND] = 'n/a', [BMP] = 'n/a', [AKL] = 'n/a', [LIQ] = 'n/a' WHERE POszam = ('" + textBox9.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button43Click(sender, e);
			}
			conn.Close();
		}
		else{
			
		}
	
		}
		void Button83Click(object sender, EventArgs e)
		{
			Registers.Regtimep reg = new Registers.Regtimep();
			reg.Show();	
		}
		void Button84Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
		DialogResult result2 = MessageBox.Show("Átnézted az összes ellenőrizetlen PO-t ?",
	    "Ellenőrzés",
	    MessageBoxButtons.YesNoCancel,
	    MessageBoxIcon.Question);
			if(result2 == DialogResult.Yes)
			{
			SqlCommand cmd1 = new SqlCommand(@"Update dbo.liquida set Ellenorizve = 1, Ki='" + textBox11.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd1.ExecuteNonQuery();
			SqlCommand cmd2 = new SqlCommand(@"Update dbo.akla set Ellenorizve = 1, Ki='" + textBox11.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd2.ExecuteNonQuery();
			SqlCommand cmd3 = new SqlCommand(@"Update dbo.bmpa set Ellenorizve = 1, Ki='" + textBox11.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd3.ExecuteNonQuery();
			SqlCommand cmd4 = new SqlCommand(@"Update dbo.blendinga set Ellenorizve = 1, Ki='" + textBox11.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd4.ExecuteNonQuery();
			SqlCommand cmd5 = new SqlCommand(@"Update dbo.packingoffa set Ellenorizve = 1, Ki='" + textBox11.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd5.ExecuteNonQuery();		
			Button41Click(sender, e);				
			}	
		}


	}
}
