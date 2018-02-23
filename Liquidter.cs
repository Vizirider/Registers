/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-26
 * Time: 09:38
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
	/// Description of Liquidter.
	/// </summary>
	public partial class Liquidter : Form
	{
	private readonly Liquidinster.MainForm1 frm1;
		public Liquidter(string mws, string po, MainForm1 frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
//			this.comboBox2.Text = mws;
//			this.comboBox3.Text = mws;
			this.comboBox1.Text = po;
			frm1 = frm;
			
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Name FROM dbo.Admins WHERE ID=('" + mws + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					comboBox3.Text = (read["Name"].ToString());		
				}
				else {
				this.comboBox3.Text = mws;				
				}
				read.Close();
			}
			
			this.Button5Click(null, null); 
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		void LiquidterLoad(object sender, EventArgs e)
		{
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
		CaptureScreen();
        printDocument1.Print();
		}
		Bitmap memoryImage;
    
		private void CaptureScreen()
	    {
	        Graphics myGraphics = this.CreateGraphics();
	        Size s = this.Size;
	        memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
	        Graphics memoryGraphics = Graphics.FromImage(memoryImage);
	        memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
	    }
			void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
			{
	        e.Graphics.DrawImage(memoryImage, 0, 0);
			}
		void Button1Click(object sender, EventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text + "%')", conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text + "%')", conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
		}
		void Combobox1KeyUp(object sender, KeyEventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text + "%')", conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
		}
		void Combobox1KeyPress(object sender, KeyEventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text + "%')", conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
		}
		void ComboBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquidella set Ellenorizve = 1, Ellenorzo='" + comboBox3.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");		
			frm1.Refresh();
			this.Close();

		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.liquidella WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					textBox1.Text = (read["Anyagkod"].ToString());
					textBox2.Text = (read["Anyagnev"].ToString());
					textBox4.Text = (read["SOszam"].ToString());
					comboBox2.Text = (read["Operator1"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termeles"]).ToString();
					textBox5.Text = (read["berendeztiszta"].ToString());
					textBox6.Text = (read["Edenytiszta"].ToString());
					textBox7.Text = (read["Folymel"].ToString());
					textBox8.Text = (read["Folyhom"].ToString());
					textBox9.Text = (read["Csomagtiszta"].ToString());
					textBox10.Text = (read["Tomites"].ToString());
					textBox11.Text = (read["Cimkek"].ToString());
					textBox12.Text = (read["Extracimke"].ToString());
					textBox13.Text = (read["Zaras"].ToString());
					textBox14.Text = (read["Alapanyagtar"].ToString());
					textBox15.Text = (read["Sampling"].ToString());
					textBox16.Text = (read["Samplingcimke"].ToString());
					textBox17.Text = (read["Csomagazon"].ToString());
					textBox18.Text = (read["Leiras"].ToString());
					textBox19.Text = (read["Hanemtakaritunk"].ToString());
					comboBox4.Text = (read["Ellenorzo"].ToString()); 
					textBox20.Text = (read["DG label"].ToString()); 
				}
				read.Close();
				panel1.Visible |= textBox5.Text == "1";
				panel2.Visible |= textBox6.Text == "1";
				panel12.Visible |= textBox9.Text == "1";
				panel11.Visible |= textBox10.Text == "1";
				panel3.Visible |= textBox5.Text == "2";
				panel4.Visible |= textBox6.Text == "2";
				panel10.Visible |= textBox9.Text == "2";
				panel9.Visible |= textBox10.Text == "2";
				panel5.Visible |= textBox5.Text == "3";
				panel6.Visible |= textBox6.Text == "3";
				panel8.Visible |= textBox9.Text == "3";
				panel7.Visible |= textBox10.Text == "3";
				panel16.Visible |= textBox7.Text == "1";
				panel15.Visible |= textBox8.Text == "1";
				panel20.Visible |= textBox11.Text == "1";
				panel19.Visible |= textBox12.Text == "1";
				panel24.Visible |= textBox13.Text == "1";
				panel23.Visible |= textBox14.Text == "1";
				panel28.Visible |= textBox15.Text == "1";
				panel27.Visible |= textBox16.Text == "1";
				panel14.Visible |= textBox7.Text == "2";
				panel13.Visible |= textBox8.Text == "2";
				panel18.Visible |= textBox11.Text == "2";
				panel17.Visible |= textBox12.Text == "2";
				panel22.Visible |= textBox13.Text == "2";
				panel21.Visible |= textBox14.Text == "2";
				panel26.Visible |= textBox15.Text == "2";
				panel25.Visible |= textBox16.Text == "2";
				panel31.Visible |= textBox20.Text == "1";
				panel30.Visible |= textBox20.Text == "2";
				panel29.Visible |= textBox20.Text == "3";
			}
			Button6Click(null,null);
		}
		void Button3Click(object sender, EventArgs e)
		{
			
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.liqkom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox72.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox72.BackColor = Color.Yellow;
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.liqkom WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox72.Text = (read["Adminkomment"].ToString());		
				if (!string.IsNullOrWhiteSpace(textBox72.Text))
				{textBox72.BackColor = Color.Yellow;
				}
				}
				read.Close();
			}
		}
		void Button8Click(object sender, EventArgs e)
		{
			if(button7.Visible == false){
			button7.Visible = true;	
			textBox5.Visible = true;
			textBox6.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox12.Visible = true;
			textBox13.Visible = true;
			textBox14.Visible = true;
			textBox15.Visible = true;
			textBox16.Visible = true;
			textBox17.Visible = true;
			textBox18.Visible = true;
			textBox19.Visible = true;
			textBox20.Visible = true;
			panel1.Visible = false;
			panel2.Visible = false;
			panel16.Visible = false;
			panel15.Visible = false;
			panel12.Visible = false;
			panel11.Visible = false;
			panel20.Visible = false;
			panel19.Visible = false;
			panel24.Visible = false;
			panel23.Visible = false;
			panel28.Visible = false;
			panel27.Visible = false;
			panel31.Visible = false;
			panel30.Visible = false;
			panel29.Visible = false;
			}
			else if(button7.Visible == true){
			Button5Click(null,null);
			button7.Visible = false;
			textBox5.Visible = false;
			textBox6.Visible = false;
			textBox7.Visible = false;
			textBox8.Visible = false;
			textBox9.Visible = false;
			textBox10.Visible = false;
			textBox11.Visible = false;
			textBox12.Visible = false;
			textBox13.Visible = false;
			textBox14.Visible = false;
			textBox15.Visible = false;
			textBox16.Visible = false;
			textBox17.Visible = false;
			textBox18.Visible = false;
			textBox19.Visible = false;
			textBox20.Visible = false;
			}

		}
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquidella set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, SOszam = @SOszam, Operator1 = @Operator1, Ellenorzo = @Ellenorzo, berendeztiszta = @berendeztiszta, Edenytiszta = @Edenytiszta, Folymel = @Folymel, Folyhom = @Folyhom, Csomagtiszta = @Csomagtiszta,
			Tomites = @Tomites, Cimkek = @Cimkek, Extracimke = @Extracimke, Zaras = @Zaras, Alapanyagtar = @Alapanyagtar, Sampling = @Sampling, Samplingcimke = @Samplingcimke, Csomagazon = @Csomagazon, Leiras = @Leiras, Hanemtakaritunk = @Hanemtakaritunk, Ellenorizve = @Ellenorizve, [DG label] = @DG_cimke
			WHERE POszam LIKE ('" + comboBox1.Text + "%')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@berendeztiszta", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Edenytiszta", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Folymel", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyhom", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagtiszta", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Tomites", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@Cimkek", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@Extracimke", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@Zaras", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@Alapanyagtar", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@Sampling", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@Samplingcimke", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagazon", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras", textBox18.Text));
			cmd.Parameters.Add(new SqlParameter("@Hanemtakaritunk", textBox19.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@DG_Cimke", textBox20.Text));

			cmd.ExecuteNonQuery();
			conn.Close();
			Button5Click(null,null);
		}


	}
}
