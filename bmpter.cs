/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-29
 * Time: 15:40
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
	/// Description of bmpter.
	/// </summary>
	/// 
	
	public partial class bmpter : Form
	{
		private readonly MainForm1 frm1;
		public bmpter(string mws, string po, MainForm1 frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
//			this.comboBox2.Text = mws;
//			this.comboBox5.Text = mws;
			this.comboBox1.Text = po;
			frm1 = frm;
			
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Name FROM dbo.Admins WHERE ID=('" + mws + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					comboBox5.Text = (read["Name"].ToString());		
				}
				else {
				this.comboBox5.Text = mws;				
				}
				read.Close();
			}
			
			this.Button5Click(null, null);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.bmpella WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					comboBox2.Text = (read["Operator1"].ToString());
					textBox4.Text = (read["SOszam"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termelesdatum"]).ToString();
					textBox1.Text = (read["Termekkod"].ToString());
					textBox2.Text = (read["Termeknev"].ToString());
					textBox5.Text = (read["Termeleskezd"].ToString());
					textBox3.Text = (read["Termelesveg"].ToString());
					textBox6.Text = (read["BMP"].ToString());
					textBox7.Text = (read["Berendezestiszta"].ToString());
					textBox8.Text = (read["BMPtiszta"].ToString());
					textBox9.Text = (read["Tomitescsattiszta"].ToString());
					textBox10.Text = (read["Megfelelobetolto"].ToString());
					textBox11.Text = (read["IBCkontenertiszta"].ToString());
					textBox12.Text = (read["Szitaep"].ToString());
					textBox13.Text = (read["Alapanyagelo"].ToString());
					textBox14.Text = (read["SOell"].ToString());
					textBox15.Text = (read["Elszivorendszer"].ToString());
					textBox18.Text = (read["Keselezes1"].ToString());
					textBox19.Text = (read["Keselezes2"].ToString());
					textBox16.Text = (read["Keselezeseloy"].ToString());
					textBox17.Text = (read["Keselezesutay"].ToString());
					textBox20.Text = (read["Bmpall"].ToString());
					textBox21.Text = (read["Munkakornyezet"].ToString());
					textBox22.Text = (read["Leiras1"].ToString());
					textBox23.Text = (read["Megjegyzes"].ToString());
					comboBox4.Text = (read["Operator2"].ToString());
					textBox24.Text = (read["Operator4"].ToString());
					comboBox6.Text = (read["Ellenorzo"].ToString()); 
					comboBox7.Text = (read["Beskocsi"].ToString());
					textBox25.Text = (read["szitatiszta"].ToString());
					
				}
				panel16.Visible |= textBox7.Text == "1";
				panel15.Visible |= textBox8.Text == "1";
				panel4.Visible |= textBox9.Text == "1";
				panel3.Visible |= textBox10.Text == "1";
				panel8.Visible |= textBox11.Text == "1";
				panel7.Visible |= textBox12.Text == "1";
				panel12.Visible |= textBox13.Text == "1";
				panel11.Visible |= textBox14.Text == "1";
				panel20.Visible |= textBox15.Text == "1";
				panel19.Visible |= textBox16.Text == "1";
				panel22.Visible |= textBox17.Text == "1";
				panel36.Visible |= textBox20.Text == "1";
				panel44.Visible |= textBox21.Text == "1";
				panel37.Visible |= textBox25.Text == "1";
				panel14.Visible |= textBox7.Text == "2";
				panel13.Visible |= textBox8.Text == "2";
				panel2.Visible |= textBox9.Text == "2";
				panel1.Visible |= textBox10.Text == "2";
				panel6.Visible |= textBox11.Text == "2";
				panel5.Visible |= textBox12.Text == "2";
				panel10.Visible |= textBox13.Text == "2";
				panel9.Visible |= textBox14.Text == "2";
				panel18.Visible |= textBox15.Text == "2";
				panel17.Visible |= textBox16.Text == "2";
				panel24.Visible |= textBox17.Text == "2";
				panel31.Visible |= textBox20.Text == "2";
				panel39.Visible |= textBox21.Text == "2";
				panel35.Visible |= textBox25.Text == "2";
				
				panel21.Visible |= textBox6.Text == "9";
				panel23.Visible |= textBox6.Text == "7";
				panel29.Visible |= textBox6.Text == "6";
				panel30.Visible |= textBox6.Text == "5";
				panel32.Visible |= textBox6.Text == "4";
				panel33.Visible |= textBox6.Text == "3";
				panel34.Visible |= textBox6.Text == "2";
		}
		Button6Click(null,null);

	}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.bmpella set Ellenorizve = 1, Ellenorzo='" + comboBox5.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");	

			frm1.Refresh();
			
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.bmpkom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox72.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox72.BackColor = Color.Yellow;
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
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.bmpkom WHERE POszam=('" + comboBox1.Text + "')", connection);
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
			textBox20.Visible = true;
			textBox21.Visible = true;
			panel25.Visible = false;
			panel27.Visible = false;
			
			}
			else if(button7.Visible == true){
			Button5Click(null,null);
			button7.Visible = false;
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
			textBox20.Visible = false;
			textBox21.Visible = false;
			panel25.Visible = false;
			panel27.Visible = false;
			}	
		}
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.bmpella set  Termekkod = @Termekkod, Termeknev = @Termeknev, POszam = @POszam, SOszam = @SOszam, Termelesdatum = @Termelesdatum,
			Termeleskezd = @Termeleskezd, Termelesveg = @Termelesveg, BMP = @BMP, Operator1 = @Operator1, Berendezestiszta = @Berendezestiszta, BMPtiszta = @BMPtiszta,
			Tomitescsattiszta = @Tomitescsattiszta, Megfelelobetolto = @Megfelelobetolto, IBCkontenertiszta = @IBCkontenertiszta, Szitaep = @Szitaep, Alapanyagelo = @Alapanyagelo, SOell = @SOell,
			Elszivorendszer = @Elszivorendszer, Keselezeseloy = @Keselezeseloy, Keselezesutay = @Keselezesutay, Keselezes1 = @Keselezes1, Keselezes2 = @Keselezes2, Operator2 = @Operator2,
			Leiras1 = @Leiras1, Datum1 = @Datum1, Bmpall = @Bmpall, Munkakornyezet = @Munkakornyezet, Megjegyzes = @Megjegyzes,
			Ellenorizve = @Ellenorizve, Ellenorzo = @Ellenorzo
			WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesdatum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Termekkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeknev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeleskezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesveg", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@BMP", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Berendezestiszta", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@BMPtiszta", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Tomitescsattiszta", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Megfelelobetolto", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCkontenertiszta", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitaep", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@Alapanyagelo", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@SOell", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@Elszivorendszer", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@Keselezes1", textBox18.Text));
			cmd.Parameters.Add(new SqlParameter("@Keselezes2", textBox19.Text));
			cmd.Parameters.Add(new SqlParameter("@Keselezeseloy", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@Keselezesutay", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum1", dateTimePicker2.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Bmpall", textBox20.Text));
			cmd.Parameters.Add(new SqlParameter("@Munkakornyezet", textBox21.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras1", textBox22.Text));
			cmd.Parameters.Add(new SqlParameter("@Megjegyzes", textBox23.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator2", comboBox4.Text));			

			cmd.ExecuteNonQuery();
			conn.Close();

			Button5Click(null,null);	
		}

}
}
