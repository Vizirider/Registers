/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-11-21
 * Time: 09:21
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

namespace Registers
{
	/// <summary>
	/// Description of MainForm5.
	/// </summary>
	public partial class MainForm5 : Form
	{
		public MainForm5(string mws, string lang)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			button72.Text = lang;			
			this.textBox8.Text = mws;
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Name FROM dbo.Admins WHERE ID=('" + textBox8.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox14.Text = (read["Name"].ToString());		
				}
				else {
				this.textBox14.Text = textBox8.Text;				
				}
				read.Close();
			}
		}
		void MainForm5Load(object sender, EventArgs e)
		{
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			if(button72.Text == "Nyelv")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
		    button72.BackgroundImage = myimage;
		    button72.Text = "Nyelv";
			textBox4.Text = " " + weekNum + "week";
			button13.Text = "Non comfort";
			button15.Text = "Non comfort";
			button7.Text = "Search";
			button12.Text = "Search";
			button3.Text = "New";
			button8.Text = "New";
			button2.Text = "Read";
			button6.Text = "Read";
			button5.Text = "Delete";
			button4.Text = "Delete";
		    button42.Text = "All";
		    button41.Text = "Unchecked";
			}
			else if(button72.Text == "Lang")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
		    button72.BackgroundImage = myimage;
		    button72.Text = "Lang";
			textBox4.Text = " " + weekNum + ". hét";
			button13.Text = "Nem megfelelő";
			button15.Text = "Nem megfelelő";
			button7.Text = "Keres";
			button12.Text = "Keres";
			button3.Text = "Új";
			button8.Text = "Új";
			button2.Text = "Néz";
			button6.Text = "Néz";
			button5.Text = "Törlés";
			button4.Text = "Törlés";
		    button42.Text = "Összes";
		    button41.Text = "Ellenőrizetlen";
			}	
		}
		void Button42Click(object sender, EventArgs e)
		{
			Button1Click(null,null);
			Button10Click(null,null);
		}
		void Button41Click(object sender, EventArgs e)
		{
			Button9Click(null,null);
			Button11Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
					SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM liquidip", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidip", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}	
		}
		void Button10Click(object sender, EventArgs e)
		{
					SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM blendingip", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendingip", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}		
		}
		void Button9Click(object sender, EventArgs e)
		{
					SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM liquidip WHERE Ellenorizve IS NULL", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidip WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}	
		}
		void Button11Click(object sender, EventArgs e)
		{
					SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM blendingip WHERE Ellenorizve IS NULL", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendingip WHERE Ellenorizve IS NULL", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}	
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Length == 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM liquidip WHERE Batch LIKE ('" + textBox3.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM liquidip WHERE Batch LIKE ('" + textBox3.Text +"%')",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			else if(textBox3.Text.Length == 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM liquidip WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidip WHERE POszam LIKE ('" + textBox1.Text +"%')",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			else{
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM liquidip WHERE (POszam LIKE ('" + textBox1.Text +"%') AND Batch LIKE ('" + textBox3.Text +"%'))",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM warehouse WHERE (POszam LIKE ('" + textBox1.Text +"%') AND Batch LIKE ('" + textBox3.Text +"%'))",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			}	
		}
		void Button12Click(object sender, EventArgs e)
		{
			if(textBox7.Text.Length == 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM blendingip WHERE Batch LIKE ('" + textBox6.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM blendingip WHERE Batch LIKE ('" + textBox6.Text +"%')",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			else if(textBox6.Text.Length == 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM blendingip WHERE POszam LIKE ('" + textBox7.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendingip WHERE POszam LIKE ('" + textBox7.Text +"%')",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			else{
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM blendingip WHERE (POszam LIKE ('" + textBox7.Text +"%') AND Batch LIKE ('" + textBox6.Text +"%'))",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM warehouse WHERE (POszam LIKE ('" + textBox7.Text +"%') AND Batch LIKE ('" + textBox6.Text +"%'))",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			}	
	
		}
		void Button13Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM nemmegliqip",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM nemmegliqip",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}	
		}
		void Button15Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Batch, Ellenorzo, Ellenorizve FROM nemmegblendip",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM nemmegblendip",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}	
		}
		void Button72Click(object sender, EventArgs e)
		{
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			if(button72.Text == "Lang")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
		    button72.BackgroundImage = myimage;
		    button72.Text = "Nyelv";
			textBox4.Text = " " + weekNum + "week";
			button13.Text = "Non comfort";
			button15.Text = "Non comfort";
			button7.Text = "Search";
			button12.Text = "Search";
			button3.Text = "New";
			button8.Text = "New";
			button2.Text = "Read";
			button6.Text = "Read";
			button5.Text = "Delete";
			button4.Text = "Delete";
		    button42.Text = "All";
		    button41.Text = "Unchecked";
		    button34.Text = "Missing";
			}
			else if(button72.Text == "Nyelv")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
		    button72.BackgroundImage = myimage;
		    button72.Text = "Lang";
			textBox4.Text = " " + weekNum + ". hét";
			button13.Text = "Nem megfelelő";
			button15.Text = "Nem megfelelő";
			button7.Text = "Keres";
			button12.Text = "Keres";
			button3.Text = "Új";
			button8.Text = "Új";
			button2.Text = "Néz";
			button6.Text = "Néz";
			button5.Text = "Törlés";
			button4.Text = "Törlés";
		    button42.Text = "Összes";
		    button41.Text = "Ellenőrizetlen";
		    button34.Text = "Nem felvittek";
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
		DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Register from liquidipqc", MessageBoxButtons.YesNo);
		if(dialogResult == DialogResult.Yes)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd1 = new SqlCommand(@"DELETE FROM dbo.liquidip  WHERE POszam = ('" + textBox1.Text +"') OR Batch = ('" + textBox3.Text +"')",conn);
			cmd1.ExecuteNonQuery();
			conn.Close();
		}
		else{
		}
		Button41Click(null,null);
		}
		void Button4Click(object sender, EventArgs e)
		{
		DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Register from blendipqc", MessageBoxButtons.YesNo);
		if(dialogResult == DialogResult.Yes)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd1 = new SqlCommand(@"DELETE FROM dbo.blendingip  WHERE POszam = ('" + textBox7.Text +"') OR Batch = ('" + textBox6.Text +"')",conn);
			cmd1.ExecuteNonQuery();
			conn.Close();
		}
		else{
		}
		Button41Click(null,null);
		}
		void Button2Click(object sender, EventArgs e)
		{
			Registers.liqip liq = new Registers.liqip(textBox3.Text, textBox1.Text, textBox8.Text);
			liq.Show();	
		}
		void Button6Click(object sender, EventArgs e)
		{
			Registers.blendip bl = new Registers.blendip(textBox6.Text, textBox7.Text, textBox8.Text);
			bl.Show();	
		}
		void Button3Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\Production\14 REGISTER\ellenorzes1.accdb";
			proc.StartInfo.WorkingDirectory = @"V:\Production\14 REGISTER";
			proc.Start();	
		}
		void Button8Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\Production\14 REGISTER\ellenorzes1.accdb";
			proc.StartInfo.WorkingDirectory = @"V:\Production\14 REGISTER";
			proc.Start();	
		}
		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			   	if (this.dataGridView1.Columns[e.ColumnIndex].Name == "POszam")
			    {

			                e.CellStyle.BackColor = Color.Black;
							e.CellStyle.ForeColor = Color.White;			                
			   	}	
		}
		void DataGridView3CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			   	if (this.dataGridView3.Columns[e.ColumnIndex].Name == "POszam")
			    {

			                e.CellStyle.BackColor = Color.Black;
							e.CellStyle.ForeColor = Color.White;			                
			   	}	
		}
		void DataGridView1CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Registers.liqip liqs = new Registers.liqip(textBox3.Text, this.dataGridView1.CurrentCell.Value.ToString(), textBox8.Text);
			liqs.Show();		
		}
		void DataGridView3CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Registers.blendip bl = new Registers.blendip(textBox6.Text, this.dataGridView3.CurrentCell.Value.ToString(), textBox8.Text);
			bl.Show();		
		}
		void Button34Click(object sender, EventArgs e)
		{
			Registers.Nemfelvittipqc nemfelvitt = new Registers.Nemfelvittipqc();
			nemfelvitt.Show();
		}
		void Button80Click(object sender, EventArgs e)
		{
			IPQCQM ip = new IPQCQM();
			ip.Show();
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
			SqlCommand cmd1 = new SqlCommand(@"Update dbo.liquidip set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd1.ExecuteNonQuery();
			SqlCommand cmd2 = new SqlCommand(@"Update dbo.blendingip set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd2.ExecuteNonQuery();
			}
		}
	}
}
