/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-19
 * Time: 11:33
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
	/// Description of blendingter.
	/// </summary>
	public partial class blendingter : Form
	{
		private readonly MainForm1 frm1;
		public blendingter(string mws, string po, MainForm1 frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
//			this.comboBox3.Text = mws;
//			this.comboBox4.Text = mws;
			// blending production check register with instances to check
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
			Button5Click(null, null);
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendella WHERE POszam = ('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					comboBox4.Text = (read["Operator1"].ToString());
					textBox6.Text = (read["SOszam"].ToString());
					dateTimePicker2.Text = Convert.ToDateTime(read["Termeles"]).ToString();
					textBox7.Text = (read["Anyagkod"].ToString());
					textBox8.Text = (read["Anyagnev"].ToString());
					textBox5.Text = (read["Telmesidokezd"].ToString());
					textBox3.Text = (read["Termelesidoveg"].ToString());
					textBox17.Text = (read["kevero"].ToString());
					textBox9.Text = (read["keverotiszta"].ToString());
					textBox10.Text = (read["keverokopas"].ToString());
					textBox11.Text = (read["folyadekbead"].ToString());
					textBox12.Text = (read["tomitescsat"].ToString());
					textBox16.Text = (read["alapanyagelo"].ToString());
					textBox15.Text = (read["ibcell"].ToString());
					textBox14.Text = (read["folymel"].ToString());
					textBox13.Text = (read["folyhom"].ToString());
					textBox18.Text = (read["Leiras1"].ToString());
					comboBox7.Text = (read["Operator2"].ToString());
					textBox19.Text = (read["tisztaszaraz"].ToString());
					textBox20.Text = (read["tomitestiszta"].ToString());
					textBox21.Text = (read["cimkejohely"].ToString());
					textBox22.Text = (read["cimkeadat"].ToString());
					textBox23.Text = (read["csomagtiszta"].ToString());
					textBox24.Text = (read["zarasmegfelel"].ToString());
					textBox25.Text = (read["foliaheg"].ToString());
					textBox26.Text = (read["csomagoloaz"].ToString());
					textBox27.Text = (read["hanemtakaritunk"].ToString());
					textBox28.Text = (read["elsodoboz"].ToString());
					textBox29.Text = (read["utolsodoboz"].ToString());
					comboBox9.Text = (read["Operator3"].ToString());
					textBox30.Text = (read["Leiras2"].ToString());
					textBox31.Text = (read["mintavetel"].ToString());
					textBox32.Text = (read["vizsgalat"].ToString());
					textBox33.Text = (read["eredmeny"].ToString());
					textBox34.Text = (read["megjegyzes"].ToString());
					comboBox8.Text = (read["Operator4"].ToString());
					textBox35.Text = (read["szitameret"].ToString());
					textBox36.Text = (read["szitatiszta"].ToString());
					textBox37.Text = (read["szitahibatlan"].ToString());
					textBox38.Text = (read["idegenanyag"].ToString());
					textBox39.Text = (read["Operator5"].ToString());
					textBox40.Text = (read["Leiras3"].ToString());
					textBox41.Text = (read["vastarte"].ToString());
					textBox42.Text = (read["nemvase"].ToString());
					textBox43.Text = (read["rozsdamente"].ToString());
					textBox44.Text = (read["vastartu"].ToString());
					textBox45.Text = (read["nemvasu"].ToString());
					textBox46.Text = (read["rozsdamentu"].ToString());
					textBox48.Text = (read["Operator6"].ToString());				
					textBox47.Text = (read["Leiras4"].ToString());
					textBox49.Text = (read["liqtank"].ToString());
					textBox50.Text = (read["kiurult"].ToString());
					textBox51.Text = (read["lastphase"].ToString());
					textBox52.Text = (read["cipviz"].ToString());
					textBox53.Text = (read["Operator7"].ToString());
					textBox54.Text = (read["Leiras5"].ToString());
					textBox1.Text = (read["lugkevkezd"].ToString());
					textBox2.Text = (read["lugkevveg"].ToString());
					textBox4.Text = (read["lugkevcheck"].ToString());
					textBox55.Text = (read["lugkevms"].ToString());
					textBox59.Text = (read["savcsomkezd"].ToString());
					textBox58.Text = (read["savcsomveg"].ToString());
					textBox57.Text = (read["savcsomcheck"].ToString());
					textBox56.Text = (read["savcsomms"].ToString());
					textBox63.Text = (read["koshercujcipkezd"].ToString());
					textBox62.Text = (read["koshercujcipveg"].ToString());
					textBox61.Text = (read["kosherujcipcheck"].ToString());
					textBox60.Text = (read["kosherujcipms"].ToString());
					textBox67.Text = (read["blendkezd"].ToString());
					textBox66.Text = (read["blendveg"].ToString());
					textBox65.Text = (read["blendcheck"].ToString());
					textBox64.Text = (read["blendms"].ToString());
					textBox71.Text = (read["csomagkezd"].ToString());
					textBox70.Text = (read["csomagveg"].ToString());
					textBox69.Text = (read["csomagcheck"].ToString());
					textBox68.Text = (read["csomagms"].ToString());
					textBox72.Text = (read["lugkevmos"].ToString());
					textBox73.Text = (read["savcsommos"].ToString());
					textBox74.Text = (read["kosherujcipmos"].ToString());
					textBox75.Text = (read["blendmos"].ToString());
					textBox76.Text = (read["csomagmos"].ToString());
					textBox81.Text = (read["lugkevszar"].ToString());
					textBox80.Text = (read["savcsomszar"].ToString());
					textBox79.Text = (read["kosherujcipszar"].ToString());
					textBox78.Text = (read["blendszar"].ToString());
					textBox77.Text = (read["csomagszar"].ToString());
					textBox54.Text = (read["Leiras5"].ToString());
					textBox87.Text = (read["Leiras6"].ToString());
					textBox82.Text = (read["szitabetet"].ToString());
					textBox83.Text = (read["szita"].ToString());
					textBox84.Text = (read["keverokezzel"].ToString());
					textBox85.Text = (read["csomagolotiszt"].ToString());
					textBox86.Text = (read["munkakor"].ToString());
					textBox88.Text = (read["Komment"].ToString());	
					textBox91.Text = (read["Operator7"].ToString());	
					comboBox2.Text = (read["Ellenorzo"].ToString());
					textBox93.Text = (read["Szitaid1"].ToString());
					textBox92.Text = (read["Szitaid2"].ToString());
					textBox94.Text = (read["szita1504"].ToString());
			        if(read["lugos"] == DBNull.Value){
			        	checkBox1.Checked = false;
			        }
			        else{
			        checkBox1.Checked = (bool)read["lugos"];			        	
			        }	
			        if(read["sav"] == DBNull.Value){
			        	checkBox2.Checked = false;
			        }
			        else{
			        checkBox2.Checked = (bool)read["sav"];			        	
			        }
			        if(read["kosherc"] == DBNull.Value){
			        	checkBox3.Checked = false;
			        }
			        else{
			        checkBox3.Checked = (bool)read["kosherc"];			        	
			        }					
					
				}
				panel106.Visible |= textBox17.Text == "1";
				panel2.Visible |= textBox17.Text == "2";
				panel3.Visible |= textBox17.Text == "3";
				panel4.Visible |= textBox17.Text == "4";
				panel5.Visible |= textBox17.Text == "5";
				panel6.Visible |= textBox17.Text == "6";
				panel7.Visible |= textBox17.Text == "7";
				panel8.Visible |= textBox17.Text == "8";
				panel9.Visible |= textBox17.Text == "9";
				
	if (!string.IsNullOrWhiteSpace(textBox1.Text))
	{textBox1.Text = textBox1.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox2.Text))
	{textBox2.Text = textBox2.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox4.Text))
	{textBox4.Text = textBox4.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox59.Text))
	{textBox59.Text = textBox59.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox58.Text))
	{textBox58.Text = textBox58.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox57.Text))
	{textBox57.Text = textBox57.Text.Substring(11);
	}
//	if (!string.IsNullOrWhiteSpace(textBox56.Text))
//	{textBox56.Text = textBox56.Text.Substring(11);
//	}	
	if (!string.IsNullOrWhiteSpace(textBox63.Text))
	{textBox63.Text = textBox63.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox62.Text))
	{textBox62.Text = textBox62.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox61.Text))
	{textBox61.Text = textBox61.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox67.Text))
	{textBox67.Text = textBox67.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox66.Text))
	{textBox66.Text = textBox66.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox65.Text))
	{textBox65.Text = textBox65.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox71.Text))
	{textBox71.Text = textBox71.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox70.Text))
	{textBox70.Text = textBox70.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox69.Text))
	{textBox69.Text = textBox69.Text.Substring(11);
	}

				panel10.Visible |= textBox9.Text == "1";
				panel12.Visible |= textBox10.Text == "1";
				panel14.Visible |= textBox11.Text == "1";
				panel17.Visible |= textBox12.Text == "1";
				panel25.Visible |= textBox16.Text == "1";
				panel24.Visible |= textBox15.Text == "1";
				panel22.Visible |= textBox14.Text == "1";
				panel20.Visible |= textBox13.Text == "1";
				panel29.Visible |= textBox19.Text == "1";
				panel28.Visible |= textBox20.Text == "1";
				panel33.Visible |= textBox21.Text == "1";
				panel32.Visible |= textBox22.Text == "1";
				panel37.Visible |= textBox23.Text == "1";
				panel36.Visible |= textBox24.Text == "1";
				panel39.Visible |= textBox25.Text == "1";
				panel41.Visible |= textBox28.Text == "1";
				panel43.Visible |= textBox29.Text == "1";
				panel89.Visible |= textBox31.Text == "1";
				panel49.Visible |= textBox36.Text == "1";
				panel51.Visible |= textBox37.Text == "1";
				panel53.Visible |= textBox38.Text == "1";
				panel55.Visible |= textBox41.Text == "1";
				panel57.Visible |= textBox42.Text == "1";
				panel59.Visible |= textBox43.Text == "1";
				panel65.Visible |= textBox44.Text == "1";
				panel64.Visible |= textBox45.Text == "1";
				panel62.Visible |= textBox46.Text == "1";
				panel69.Visible |= textBox49.Text == "1";
				panel68.Visible |= textBox50.Text == "1";
				panel73.Visible |= textBox51.Text == "1";
				panel72.Visible |= textBox52.Text == "1";
				panel78.Visible |= textBox72.Text == "1";
				panel77.Visible |= textBox73.Text == "1";
				panel82.Visible |= textBox74.Text == "1";
				panel81.Visible |= textBox75.Text == "1";
				panel84.Visible |= textBox76.Text == "1";
				panel94.Visible |= textBox81.Text == "1";
				panel93.Visible |= textBox80.Text == "1";
				panel92.Visible |= textBox79.Text == "1";
				panel90.Visible |= textBox78.Text == "1";
				panel87.Visible |= textBox77.Text == "1";
				panel100.Visible |= textBox82.Text == "1";
				panel99.Visible |= textBox83.Text == "1";
				panel97.Visible |= textBox84.Text == "1";
				panel102.Visible |= textBox85.Text == "1";
				panel103.Visible |= textBox86.Text == "1";
				panel108.Visible |= textBox94.Text == "1";				


				panel75.Visible |= textBox9.Text == "2";
				panel11.Visible |= textBox10.Text == "2";
				panel13.Visible |= textBox11.Text == "2";
				panel15.Visible |= textBox12.Text == "2";
				panel23.Visible |= textBox16.Text == "2";
				panel21.Visible |= textBox15.Text == "2";
				panel19.Visible |= textBox14.Text == "2";
				panel18.Visible |= textBox13.Text == "2";
				panel27.Visible |= textBox19.Text == "2";
				panel26.Visible |= textBox20.Text == "2";
				panel31.Visible |= textBox21.Text == "2";
				panel30.Visible |= textBox22.Text == "2";
				panel35.Visible |= textBox23.Text == "2";
				panel34.Visible |= textBox24.Text == "2";
				panel38.Visible |= textBox25.Text == "2";
				panel40.Visible |= textBox28.Text == "2";
				panel42.Visible |= textBox29.Text == "2";
				panel105.Visible |= textBox31.Text == "2";
				panel44.Visible |= textBox36.Text == "2";
				panel50.Visible |= textBox37.Text == "2";
				panel52.Visible |= textBox38.Text == "2";
				panel54.Visible |= textBox41.Text == "2";
				panel56.Visible |= textBox42.Text == "2";
				panel58.Visible |= textBox43.Text == "2";
				panel63.Visible |= textBox44.Text == "2";
				panel61.Visible |= textBox45.Text == "2";
				panel60.Visible |= textBox46.Text == "2";
				panel67.Visible |= textBox49.Text == "2";
				panel66.Visible |= textBox50.Text == "2";
				panel71.Visible |= textBox51.Text == "2";
				panel70.Visible |= textBox52.Text == "2";
				panel76.Visible |= textBox72.Text == "2";
				panel74.Visible |= textBox73.Text == "2";
				panel80.Visible |= textBox74.Text == "2";
				panel79.Visible |= textBox75.Text == "2";
				panel83.Visible |= textBox76.Text == "2";
				panel91.Visible |= textBox81.Text == "2";
				panel88.Visible |= textBox80.Text == "2";
				panel89.Visible |= textBox79.Text == "2";
				panel86.Visible |= textBox78.Text == "2";
				panel85.Visible |= textBox77.Text == "2";
				panel98.Visible |= textBox82.Text == "2";
				panel96.Visible |= textBox83.Text == "2";
				panel95.Visible |= textBox84.Text == "2";
				panel104.Visible |= textBox85.Text == "2";
				panel101.Visible |= textBox86.Text == "2";
				panel107.Visible |= textBox94.Text == "2";
		}
				Button6Click(null,null);			
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendella set Ellenorizve = 1, Ellenorzo='" + comboBox3.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			frm1.Refresh();			
			this.Close();
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
			textBox7.Text = frstcol;
			textBox8.Text = scndcol;
			conn.Close();
		}
		void ComboBox1KeyPress(object sender, KeyPressEventArgs e)
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
			textBox7.Text = frstcol;
			textBox8.Text = scndcol;
			conn.Close();	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendella set folymel = @folymel, folyhom = @folyhom, keverotiszta = @keverotiszta, liqtank = @liqtank,
			kiurult = @kiurult, tomitescsat = @tomitescsat, folyadekbead = @foyadekbead, lugkevmos = @lugkevmos, lugkevszar = @lugkevszar
			WHERE POszam LIKE ('" + comboBox1.Text + "%')", conn);
			cmd.Parameters.Add(new SqlParameter("@folymel", 1));
			cmd.Parameters.Add(new SqlParameter("@folyhom", 1));
			cmd.Parameters.Add(new SqlParameter("@keverotiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@liqtank", 1));
			cmd.Parameters.Add(new SqlParameter("@kiurult", 1));
			cmd.Parameters.Add(new SqlParameter("@tomitescsat", 1));
			cmd.Parameters.Add(new SqlParameter("@foyadekbead", 1));
			cmd.Parameters.Add(new SqlParameter("@lugkevmos", 1));
			cmd.Parameters.Add(new SqlParameter("@lugkevszar", 1));
			
			cmd.ExecuteNonQuery();
			conn.Close();	
			
			Button5Click(null,null);	
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.blendkom WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox90.Text = (read["Adminkomment"].ToString());		
				if (!string.IsNullOrWhiteSpace(textBox90.Text))
				{textBox90.BackColor = Color.Yellow;
				}
				}
				read.Close();	
			}	
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.blendkom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox90.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			Button1Click(null,null);
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox90.BackColor = Color.Yellow;	
		}
		void Button2MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Elütések javítása");			
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendella set lugkevveg = @lugkevveg, lugkevcheck = @lugkevcheck, lugkevms = @lugkevms WHERE POszam =('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@lugkevveg", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevcheck", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevms", textBox55.Text));
			cmd.ExecuteNonQuery();
			conn.Close();			
		}
		void Button8Click(object sender, EventArgs e)
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
		void Button7Click(object sender, EventArgs e)
		{
			if(button9.Visible == false){
			button9.Visible = true;	
			textBox17.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox12.Visible = true;
			textBox13.Visible = true;
			textBox14.Visible = true;
			textBox15.Visible = true;
			textBox16.Visible = true;
			textBox19.Visible = true;
			textBox20.Visible = true;
			textBox21.Visible = true;
			textBox22.Visible = true;
			textBox23.Visible = true;
			textBox24.Visible = true;
			textBox25.Visible = true;
			textBox28.Visible = true;
			textBox29.Visible = true;
			textBox31.Visible = true;
			textBox36.Visible = true;
			textBox37.Visible = true;
			textBox38.Visible = true;
			textBox39.Visible = true;
			textBox41.Visible = true;
			textBox42.Visible = true;
			textBox43.Visible = true;
			textBox44.Visible = true;
			textBox45.Visible = true;
			textBox46.Visible = true;
			textBox49.Visible = true;
			textBox50.Visible = true;
			textBox51.Visible = true;
			textBox52.Visible = true;
			textBox72.Visible = true;
			textBox73.Visible = true;
			textBox74.Visible = true;
			textBox75.Visible = true;
			textBox76.Visible = true;
			textBox81.Visible = true;
			textBox80.Visible = true;
			textBox79.Visible = true;
			textBox78.Visible = true;
			textBox77.Visible = true;
			textBox82.Visible = true;
			textBox83.Visible = true;
			textBox84.Visible = true;
			textBox85.Visible = true;
			textBox86.Visible = true;
			textBox94.Visible = true;
			
			}
			else if(button9.Visible == true){
			Button5Click(null,null);
			button9.Visible = false;
			textBox17.Visible = false;
			textBox9.Visible = false;
			textBox10.Visible = false;
			textBox11.Visible = false;
			textBox12.Visible = false;
			textBox13.Visible = false;
			textBox14.Visible = false;
			textBox15.Visible = false;
			textBox16.Visible = false;
			textBox19.Visible = false;
			textBox20.Visible = false;
			textBox21.Visible = false;
			textBox22.Visible = false;
			textBox23.Visible = false;
			textBox24.Visible = false;
			textBox25.Visible = false;
			textBox28.Visible = false;
			textBox29.Visible = false;
			textBox31.Visible = false;
			textBox36.Visible = false;
			textBox37.Visible = false;
			textBox38.Visible = false;
			textBox39.Visible = false;
			textBox41.Visible = false;
			textBox42.Visible = false;
			textBox43.Visible = false;
			textBox44.Visible = false;
			textBox45.Visible = false;
			textBox46.Visible = false;
			textBox49.Visible = false;
			textBox50.Visible = false;
			textBox51.Visible = false;
			textBox52.Visible = false;
			textBox72.Visible = false;
			textBox73.Visible = false;
			textBox74.Visible = false;
			textBox75.Visible = false;
			textBox76.Visible = false;
			textBox81.Visible = false;
			textBox80.Visible = false;
			textBox79.Visible = false;
			textBox78.Visible = false;
			textBox77.Visible = false;
			textBox82.Visible = false;
			textBox83.Visible = false;
			textBox84.Visible = false;
			textBox85.Visible = false;
			textBox86.Visible = false;
			textBox94.Visible = false;
			}		
		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendella set  Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, POszam = @POszam, SOszam = @SOszam, Termeles = @Termeles,
			Telmesidokezd = @Telmesidokezd, Termelesidoveg = @Termelesidoveg, kevero = @kevero, keverotiszta = @keverotiszta, keverokopas = @keverokopas, folyadekbead = @folyadekbead,
			tomitescsat = @tomitescsat, alapanyagelo = @alapanyagelo, ibcell = @ibcell, folymel = @folymel, folyhom = @folyhom, Leiras1 = @Leiras1,
			Operator2 = @Operator2, tisztaszaraz = @tisztaszaraz, cimkejohely = @cimkejohely, cimkeadat = @cimkeadat, csomagtiszta = @csomagtiszta,
			zarasmegfelel = @zarasmegfelel, foliaheg = @foliaheg, csomagoloaz = @csomagoloaz, hanemtakaritunk = @hanemtakaritunk, elsodoboz = @elsodoboz, utolsodoboz = @utolsodoboz,
			Operator3 = @Operator3, Leiras2 = @Leiras2, mintavetel = @mintavetel, vizsgalat = @vizsgalat, eredmeny = @eredmeny, megjegyzes = @megjegyzes,
			Operator4 = @Operator4, szitameret = @szitameret, szitatiszta = @szitatiszta, szitahibatlan = @szitahibatlan, idegenanyag = @idegenanyag, Operator5 = @Operator5,
			Leiras3 = @Leiras3, vastarte = @vastarte, nemvase = @nemvase, rozsdamente = @rozsdamente, vastartu = @vastartu, nemvasu = @nemvasu,
			rozsdamentu = @rozsdamentu, Operator6 = @Operator6, Leiras4 = @Leiras4, liqtank = @liqtank, kiurult = @kiurult, lastphase = @lastphase,
			cipviz = @cipviz, Operator7 = @Operator7, lugkevkezd = @lugkevkezd, lugkevcheck = @lugkevcheck,
			lugkevms = @lugkevms, savcsomkezd = @savcsomkezd, savcsomveg = @savcsomveg, savcsomcheck = @savcsomcheck, savcsomms = @savcsomms, koshercujcipkezd = @koshercujcipkezd,
			koshercujcipveg = @koshercujcipveg, kosherujcipcheck = @kosherujcipcheck, kosherujcipms = @kosherujcipms, blendkezd = @blendkezd, blendveg = @blendveg, blendcheck = @blendcheck,
			blendms = @blendms, csomagkezd = @csomagkezd, csomagveg = @csomagveg, csomagcheck = @csomagcheck, csomagms = @csomagms, lugkevmos = @lugkevmos,
			savcsommos = @savcsommos, kosherujcipmos = @kosherujcipmos, blendmos = @blendmos, csomagmos = @csomagmos, lugkevszar = @lugkevszar, savcsomszar = @savcsomszar,
			kosherujcipszar = @kosherujcipszar, blendszar = @blendszar, csomagszar = @csomagszar, Leiras5 = @Leiras5, Leiras6 = @Leiras6, szitabetet = @szitabetet, tomitestiszta = @tomitestiszta,
			szita = @szita, keverokezzel = @keverokezzel, csomagolotiszt = @csomagolotiszt, munkakor = @munkakor, Komment = @Komment,  lugos = @lugos, sav = @sav, kosherc = @kosherc, lugkevveg = @lugkevveg,
			Szitaid1 = @Szitaid1, Szitaid2 = @Szitaid2, szita1504 = @szita1504
			WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker2.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Telmesidokezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesidoveg", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@kevero", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@keverotiszta", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@keverokopas", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@folyadekbead", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@tomitescsat", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@alapanyagelo", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@ibcell", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@folymel", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@folyhom", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras1", textBox18.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator2", comboBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@tisztaszaraz", textBox19.Text));
			cmd.Parameters.Add(new SqlParameter("@tomitestiszta", textBox20.Text));
			cmd.Parameters.Add(new SqlParameter("@cimkejohely", textBox21.Text));
			cmd.Parameters.Add(new SqlParameter("@cimkeadat", textBox22.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagtiszta", textBox23.Text));
			cmd.Parameters.Add(new SqlParameter("@zarasmegfelel", textBox24.Text));
			cmd.Parameters.Add(new SqlParameter("@foliaheg", textBox25.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagoloaz", textBox26.Text));
			cmd.Parameters.Add(new SqlParameter("@hanemtakaritunk", textBox27.Text));
			cmd.Parameters.Add(new SqlParameter("@elsodoboz", textBox28.Text));
			cmd.Parameters.Add(new SqlParameter("@utolsodoboz", textBox29.Text));			
			cmd.Parameters.Add(new SqlParameter("@Operator3", comboBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras2", textBox30.Text));
			cmd.Parameters.Add(new SqlParameter("@mintavetel", textBox31.Text));
			cmd.Parameters.Add(new SqlParameter("@vizsgalat", textBox32.Text));
			cmd.Parameters.Add(new SqlParameter("@eredmeny", textBox33.Text));
			cmd.Parameters.Add(new SqlParameter("@megjegyzes", textBox34.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator4", comboBox8.Text));		
			cmd.Parameters.Add(new SqlParameter("@szitameret", textBox35.Text));
			cmd.Parameters.Add(new SqlParameter("@szitatiszta", textBox36.Text));
			cmd.Parameters.Add(new SqlParameter("@szitahibatlan", textBox37.Text));
			cmd.Parameters.Add(new SqlParameter("@idegenanyag", textBox38.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator5", textBox39.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras3", textBox40.Text));
			cmd.Parameters.Add(new SqlParameter("@vastarte", textBox41.Text));
			cmd.Parameters.Add(new SqlParameter("@nemvase", textBox42.Text));
			cmd.Parameters.Add(new SqlParameter("@rozsdamente", textBox43.Text));
			cmd.Parameters.Add(new SqlParameter("@vastartu", textBox44.Text));
			cmd.Parameters.Add(new SqlParameter("@nemvasu", textBox45.Text));
			cmd.Parameters.Add(new SqlParameter("@rozsdamentu", textBox46.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator6", textBox48.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras4", textBox47.Text));
			cmd.Parameters.Add(new SqlParameter("@liqtank", textBox49.Text));
			cmd.Parameters.Add(new SqlParameter("@kiurult", textBox50.Text));
			cmd.Parameters.Add(new SqlParameter("@lastphase", textBox51.Text));
			cmd.Parameters.Add(new SqlParameter("@cipviz", textBox52.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator7", textBox53.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevkezd", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevveg", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevcheck", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevms", textBox55.Text));
			cmd.Parameters.Add(new SqlParameter("@savcsomveg", textBox58.Text));
			cmd.Parameters.Add(new SqlParameter("@savcsomkezd", textBox59.Text));
			cmd.Parameters.Add(new SqlParameter("@savcsomcheck", textBox57.Text));
			cmd.Parameters.Add(new SqlParameter("@savcsomms", textBox56.Text));
			cmd.Parameters.Add(new SqlParameter("@koshercujcipkezd", textBox63.Text));
			cmd.Parameters.Add(new SqlParameter("@koshercujcipveg", textBox62.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipcheck", textBox61.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipms", textBox60.Text));
			cmd.Parameters.Add(new SqlParameter("@blendkezd", textBox67.Text));
			cmd.Parameters.Add(new SqlParameter("@blendveg", textBox66.Text));
			cmd.Parameters.Add(new SqlParameter("@blendcheck", textBox65.Text));
			cmd.Parameters.Add(new SqlParameter("@blendms", textBox64.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagkezd", textBox71.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagveg", textBox70.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagcheck", textBox69.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagms", textBox68.Text));	
			cmd.Parameters.Add(new SqlParameter("@lugkevmos", textBox72.Text));
			cmd.Parameters.Add(new SqlParameter("@savcsommos", textBox73.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipmos", textBox74.Text));
			cmd.Parameters.Add(new SqlParameter("@blendmos", textBox75.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagmos", textBox76.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevszar", textBox81.Text));
			cmd.Parameters.Add(new SqlParameter("@savcsomszar", textBox80.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipszar", textBox79.Text));
			cmd.Parameters.Add(new SqlParameter("@blendszar", textBox78.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagszar", textBox77.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras5", textBox54.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras6", textBox87.Text));
			cmd.Parameters.Add(new SqlParameter("@szitabetet", textBox82.Text));
			cmd.Parameters.Add(new SqlParameter("@szita", textBox83.Text));	
			cmd.Parameters.Add(new SqlParameter("@keverokezzel", textBox84.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagolotiszt", textBox85.Text));
			cmd.Parameters.Add(new SqlParameter("@munkakor", textBox86.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox88.Text));	
			cmd.Parameters.Add(new SqlParameter("@lugos", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@sav", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@kosherc", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitaid1", textBox93.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitaid2", textBox92.Text));			
			cmd.Parameters.Add(new SqlParameter("@szita1504", textBox94.Text));	
			
			cmd.ExecuteNonQuery();
			
			SqlCommand cmd1 = new SqlCommand(@"Update dbo.blendella set [lugkevkezd] = null ,[lugkevveg] = null WHERE POszam = ('" + comboBox1.Text + "') AND lugkevveg = '0:00'", conn);
			cmd1.ExecuteNonQuery();
			conn.Close();

			Button5Click(null,null);	
		}

		}
	}

