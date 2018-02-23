/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-14
 * Time: 10:01
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
	/// Description of sd.
	/// </summary>
	///  SD Production check register with select sql 
	public partial class sd : Form
	{
	private readonly Liquidinster.MainForm1 frm1;
		public sd(string mws, string po, MainForm1 frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
			Button5Click(null,null);
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
			textBox2.Text = frstcol;
			textBox1.Text = scndcol;
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
			textBox2.Text = frstcol;
			textBox1.Text = scndcol;
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
			textBox2.Text = frstcol;
			textBox1.Text = scndcol;
			conn.Close();	
		}
		void Button5Click(object sender, EventArgs e)
		{
		using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.sdella WHERE POszam = ('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					comboBox2.Text = (read["Operator1"].ToString());
					textBox4.Text = (read["SOszam"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termeles"]).ToString();
					textBox2.Text = (read["Anyagkod"].ToString());
					textBox1.Text = (read["Anyagnev"].ToString());
					textBox5.Text = (read["Termelesidokezd"].ToString());
					textBox3.Text = (read["Termelesidoveg"].ToString());
					textBox6.Text = (read["M20M60"].ToString());
					textBox17.Text = (read["Emulzio"].ToString());
					textBox7.Text = (read["Feed"].ToString());
					textBox8.Text = (read["Csorend"].ToString());
					textBox9.Text = (read["Folyadek"].ToString());
					textBox10.Text = (read["Panel"].ToString());
					textBox11.Text = (read["Soell"].ToString());
					textBox12.Text = (read["Sofoly"].ToString());
					textBox13.Text = (read["Folymel"].ToString());
					textBox14.Text = (read["Folyhom"].ToString());
					textBox15.Text = (read["Leiras"].ToString());
					textBox16.Text = (read["Tiszta"].ToString());
					textBox18.Text = (read["Tomites"].ToString());
					textBox19.Text = (read["Csomag"].ToString());
					textBox20.Text = (read["Cimkek"].ToString());
					textBox21.Text = (read["Csomagtiszta"].ToString());
					textBox22.Text = (read["Foliaheg"].ToString());
					textBox23.Text = (read["Hanemtakarit"].ToString());
					textBox24.Text = (read["Foldob1"].ToString());
					textBox25.Text = (read["Foldob2"].ToString());
					textBox26.Text = (read["sampdb"].ToString());
					textBox27.Text = (read["sampsuly"].ToString());
					textBox28.Text = (read["szitameret"].ToString());
					textBox29.Text = (read["tisztaszaraz"].ToString());
					textBox30.Text = (read["szitahibatlan"].ToString());
					textBox31.Text = (read["idegenanyag"].ToString());
					textBox32.Text = (read["Leiras1"].ToString());
					textBox34.Text = (read["vas"].ToString());
					textBox35.Text = (read["nemvas"].ToString());
					textBox36.Text = (read["rozsda"].ToString());
					textBox37.Text = (read["vasu"].ToString());
					textBox38.Text = (read["nemvasu"].ToString());
					textBox39.Text = (read["rozsdau"].ToString());
					textBox40.Text = (read["Leiras2"].ToString());
					textBox41.Text = (read["mixtankkezdl"].ToString());
					textBox42.Text = (read["mixtankvegl"].ToString());
					textBox43.Text = (read["mixtankelll"].ToString());
					textBox44.Text = (read["mixtankmsl"].ToString());
					textBox48.Text = (read["sdkezdl"].ToString());
					textBox47.Text = (read["sdvegl"].ToString());
					textBox46.Text = (read["sdelll"].ToString());
					textBox45.Text = (read["sdmsl"].ToString());
					textBox52.Text = (read["kiszaritaskezds"].ToString());
					textBox51.Text = (read["kiszaritasvegs"].ToString());
					textBox54.Text = (read["mixtankkezdk"].ToString());
					textBox53.Text = (read["mixtankvegk"].ToString());
					textBox50.Text = (read["mixtankellk"].ToString());
					textBox49.Text = (read["mixtankmsk"].ToString());
					textBox58.Text = (read["sdkezdk"].ToString());
					textBox57.Text = (read["sdkvegk"].ToString());
					textBox56.Text = (read["sdellk"].ToString());
					textBox55.Text = (read["sdms"].ToString());
					textBox60.Text = (read["kiszaritaskezdc"].ToString());
					textBox59.Text = (read["kiszaritasvegc"].ToString());
					textBox62.Text = (read["mixtankmosl"].ToString());
					textBox61.Text = (read["sdmosl"].ToString());
					textBox64.Text = (read["mixtankmosk"].ToString());
					textBox63.Text = (read["sdmosk"].ToString());
					textBox65.Text = (read["kiszaritasszars"].ToString());
					textBox66.Text = (read["kiszaritasszarc"].ToString());
					textBox67.Text = (read["Labor"].ToString());
					textBox68.Text = (read["Leiras3"].ToString());
					textBox69.Text = (read["Keztermek"].ToString());
					textBox70.Text = (read["Kezszita"].ToString());
					textBox71.Text = (read["Kezsd"].ToString());
					textBox73.Text = (read["Kezcsomag"].ToString());
					textBox74.Text = (read["Kezemul"].ToString());
					textBox75.Text = (read["Kezkorny"].ToString());
					textBox76.Text = (read["Leiras4"].ToString());
					textBox77.Text = (read["Datumd"].ToString());
					textBox78.Text = (read["Kezjegy"].ToString());				
					textBox72.Text = (read["Datum1"].ToString());
					textBox79.Text = (read["Datum2"].ToString());
					textBox80.Text = (read["Datum3"].ToString());
					textBox81.Text = (read["Datum4"].ToString());
					textBox82.Text = (read["Datum5"].ToString());
					textBox83.Text = (read["Datum6"].ToString());
					textBox89.Text = (read["Ido1"].ToString());
					textBox88.Text = (read["Ido2"].ToString());
					textBox87.Text = (read["Ido3"].ToString());
					textBox86.Text = (read["Ido4"].ToString());
					textBox85.Text = (read["Ido5"].ToString());
					textBox84.Text = (read["Ido6"].ToString());
					textBox96.Text = (read["Emulzio1"].ToString());
					textBox95.Text = (read["Emulzio1"].ToString());
					textBox94.Text = (read["Emulzio1"].ToString());
					textBox93.Text = (read["Emulzio1"].ToString());
					textBox92.Text = (read["Emulzio1"].ToString());
					textBox91.Text = (read["Emulzio1"].ToString());
					textBox102.Text = (read["Egettszem1"].ToString());
					textBox101.Text = (read["Egettszem2"].ToString());
					textBox100.Text = (read["Egettszem3"].ToString());
					textBox99.Text = (read["Egettszem4"].ToString());
					textBox98.Text = (read["Egettszem5"].ToString());
					textBox97.Text = (read["Egettszem6"].ToString());
					textBox108.Text = (read["Mertned1"].ToString());
					textBox107.Text = (read["Mertned2"].ToString());
					textBox106.Text = (read["Mertned3"].ToString());
					textBox105.Text = (read["Mertned4"].ToString());
					textBox104.Text = (read["Mertned5"].ToString());
					textBox103.Text = (read["Mertned6"].ToString());
					textBox114.Text = (read["Comment1"].ToString());
					textBox113.Text = (read["Comment2"].ToString());
					textBox112.Text = (read["Comment3"].ToString());
					textBox111.Text = (read["Comment4"].ToString());
					textBox110.Text = (read["Comment5"].ToString());
					textBox109.Text = (read["Comment6"].ToString());
					textBox120.Text = (read["Karton1"].ToString());
					textBox119.Text = (read["Karton2"].ToString());
					textBox118.Text = (read["Karton3"].ToString());
					textBox117.Text = (read["Karton4"].ToString());
					textBox116.Text = (read["Karton5"].ToString());
					textBox115.Text = (read["Karton6"].ToString());
					comboBox3.Text = (read["Ellenorzo"].ToString());
					textBox121.Text = (read["etalon"].ToString());
					textBox33.Text = (read["detszam"].ToString());
					textBox123.Text = (read["Szitaid1"].ToString());
					textBox122.Text = (read["Szitaid2"].ToString());
					
					if(read["lugos"] == DBNull.Value){
			        	checkBox4.Checked = false;
			        }
			        else{
			        checkBox4.Checked = (bool)read["lugos"];			        	
			        }	
			        if(read["savas"] == DBNull.Value){
			        	checkBox5.Checked = false;
			        }
			        else{
			        checkBox5.Checked = (bool)read["savas"];			        	
			        }
			        if(read["kosher"] == DBNull.Value){
			        	checkBox6.Checked = false;
			        }
			        else{
			        checkBox6.Checked = (bool)read["kosher"];			        	
			        }
			        if(read["mintavetel"] == DBNull.Value){
			        	checkBox3.Checked = false;
			        }
			        else{
			        checkBox3.Checked = (bool)read["mintavetel"];			        	
			        }	
					

					
	if (!string.IsNullOrWhiteSpace(textBox54.Text))
	{textBox54.Text = textBox54.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox53.Text))
	{textBox53.Text = textBox53.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox50.Text))
	{textBox50.Text = textBox50.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox58.Text))
	{textBox58.Text = textBox58.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox57.Text))
	{textBox57.Text = textBox57.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox56.Text))
	{textBox56.Text = textBox56.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox60.Text))
	{textBox60.Text = textBox60.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox59.Text))
	{textBox59.Text = textBox59.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox41.Text))
	{textBox41.Text = textBox41.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox42.Text))
	{textBox42.Text = textBox42.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox43.Text))
	{textBox43.Text = textBox43.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox48.Text))
	{textBox48.Text = textBox48.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox47.Text))
	{textBox47.Text = textBox47.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox46.Text))
	{textBox46.Text = textBox46.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox52.Text))
	{textBox52.Text = textBox52.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox51.Text))
	{textBox51.Text = textBox51.Text.Substring(11);
	}

	if (!string.IsNullOrWhiteSpace(textBox89.Text))
	{textBox89.Text = textBox89.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox88.Text))
	{textBox88.Text = textBox88.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox87.Text))
	{textBox87.Text = textBox87.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox86.Text))
	{textBox86.Text = textBox86.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox85.Text))
	{textBox85.Text = textBox85.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox84.Text))
	{textBox84.Text = textBox84.Text.Substring(11);
	}
				}
				
				panel82.Visible |= textBox6.Text == "1";
				panel81.Visible |= textBox6.Text == "2";
				panel80.Visible |= textBox6.Text == "3";

				panel16.Visible |= textBox17.Text == "1";
				panel2.Visible |= textBox7.Text == "1";
				panel3.Visible |= textBox8.Text == "1";
				panel4.Visible |= textBox9.Text == "1";
				panel5.Visible |= textBox10.Text == "1";
				panel6.Visible |= textBox11.Text == "1";
				panel7.Visible |= textBox12.Text == "1";
				panel8.Visible |= textBox13.Text == "1";
				panel9.Visible |= textBox14.Text == "1";
				panel10.Visible |= textBox16.Text == "1";
				panel11.Visible |= textBox18.Text == "1";
				panel12.Visible |= textBox20.Text == "1";
				panel13.Visible |= textBox21.Text == "1";
				panel14.Visible |= textBox22.Text == "1";
				panel15.Visible |= textBox24.Text == "1";
				panel17.Visible |= textBox25.Text == "1";
				panel18.Visible |= textBox29.Text == "1";
				panel19.Visible |= textBox30.Text == "1";
				panel20.Visible |= textBox31.Text == "1";
				panel21.Visible |= textBox34.Text == "1";
				panel22.Visible |= textBox35.Text == "1";
				panel23.Visible |= textBox36.Text == "1";
				panel24.Visible |= textBox37.Text == "1";
				panel25.Visible |= textBox38.Text == "1";
				panel26.Visible |= textBox39.Text == "1";
				panel27.Visible |= textBox62.Text == "1";
				panel28.Visible |= textBox61.Text == "1";
				panel29.Visible |= textBox64.Text == "1";
				panel30.Visible |= textBox63.Text == "1";
				panel31.Visible |= textBox69.Text == "1";
				panel32.Visible |= textBox70.Text == "1";
				panel33.Visible |= textBox71.Text == "1";
				panel34.Visible |= textBox73.Text == "1";
				panel35.Visible |= textBox74.Text == "1";
				panel36.Visible |= textBox75.Text == "1";
				panel77.Visible |= textBox65.Text == "1";
				panel79.Visible |= textBox66.Text == "1";
				panel88.Visible |= textBox121.Text == "1";
				
				panel75.Visible |= textBox17.Text == "2";
				panel74.Visible |= textBox7.Text == "2";
				panel73.Visible |= textBox8.Text == "2";
				panel72.Visible |= textBox9.Text == "2";
				panel71.Visible |= textBox10.Text == "2";
				if(textBox6.Text == "1")
				{
					panel72.BackColor = Color.White;
					panel71.BackColor = Color.White;
				}
				panel70.Visible |= textBox11.Text == "2";
				panel69.Visible |= textBox12.Text == "2";
				panel68.Visible |= textBox13.Text == "2";
				panel67.Visible |= textBox14.Text == "2";
				panel66.Visible |= textBox16.Text == "2";
				panel65.Visible |= textBox20.Text == "2";
				panel63.Visible |= textBox18.Text == "2";
				panel62.Visible |= textBox21.Text == "2";
				panel61.Visible |= textBox22.Text == "2";
				panel60.Visible |= textBox24.Text == "2";
				panel59.Visible |= textBox25.Text == "2";
				panel58.Visible |= textBox30.Text == "2";
				panel57.Visible |= textBox31.Text == "2";
				panel56.Visible |= textBox34.Text == "2";
				panel55.Visible |= textBox35.Text == "2";
				panel54.Visible |= textBox36.Text == "2";
				panel53.Visible |= textBox37.Text == "2";
				panel52.Visible |= textBox38.Text == "2";
				panel51.Visible |= textBox39.Text == "2";
				panel50.Visible |= textBox62.Text == "2";
				panel49.Visible |= textBox61.Text == "2";
				panel44.Visible |= textBox64.Text == "2";
				panel43.Visible |= textBox63.Text == "2";
				panel42.Visible |= textBox69.Text == "2";
				panel41.Visible |= textBox70.Text == "2";
				panel40.Visible |= textBox71.Text == "2";
				panel39.Visible |= textBox73.Text == "2";
				panel38.Visible |= textBox74.Text == "2";
				panel37.Visible |= textBox75.Text == "2";
				panel76.Visible |= textBox65.Text == "2";
				panel78.Visible |= textBox66.Text == "2";
				panel87.Visible |= textBox121.Text == "2";


		}
			Button6Click(null,null);
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.sdella set Ellenorizve = 1, Ellenorzo='" + comboBox5.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
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
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.sdkom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox90.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox90.BackColor = Color.Yellow;		
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.sdkom WHERE POszam=('" + comboBox1.Text + "')", connection);
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
		void Button2MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Elütések javítása");				
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.sdella set Emulzio = @Emulzio, Feed = @Feed, Csorend = @Csorend, Panel = @Panel,
			Tiszta = @Tiszta, Tomites = @Tomites, Cimkek = @Cimkek, tisztaszaraz = @tisztaszaraz, szitahibatlan = @szitahibatlan, Folyadek = @Folyadek,
			mixtankmosl = @mixtankmosl, sdmosl = @sdmosl
			WHERE POszam LIKE ('" + comboBox1.Text + "%')", conn);
			cmd.Parameters.Add(new SqlParameter("@Emulzio", 1));
			cmd.Parameters.Add(new SqlParameter("@Feed", 1));
			cmd.Parameters.Add(new SqlParameter("@Csorend", 1));
			cmd.Parameters.Add(new SqlParameter("@Panel", 1));
			cmd.Parameters.Add(new SqlParameter("@Tiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Tomites", 1));
			cmd.Parameters.Add(new SqlParameter("@Cimkek", 1));
			cmd.Parameters.Add(new SqlParameter("@tisztaszaraz", 1));
			cmd.Parameters.Add(new SqlParameter("@szitahibatlan", 1));
			cmd.Parameters.Add(new SqlParameter("@Folyadek", 1));
			cmd.Parameters.Add(new SqlParameter("@mixtankmosl", 1));
			cmd.Parameters.Add(new SqlParameter("@sdmosl", 1));

			cmd.ExecuteNonQuery();
			conn.Close();	
			
			Button5Click(null,null);	
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(button9.Visible == false){
			button9.Visible = true;	
			textBox17.Visible = true;
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox12.Visible = true;
			textBox13.Visible = true;
			textBox14.Visible = true;
			textBox16.Visible = true;
			textBox18.Visible = true;
			textBox20.Visible = true;
			textBox21.Visible = true;
			textBox22.Visible = true;
			textBox24.Visible = true;
			textBox25.Visible = true;
			textBox29.Visible = true;
			textBox30.Visible = true;
			textBox31.Visible = true;
			textBox34.Visible = true;
			textBox35.Visible = true;
			textBox36.Visible = true;
			textBox37.Visible = true;
			textBox38.Visible = true;
			textBox39.Visible = true;
			textBox62.Visible = true;
			textBox61.Visible = true;
			textBox65.Visible = true;
			textBox64.Visible = true;
			textBox63.Visible = true;
			textBox66.Visible = true;
			textBox69.Visible = true;
			textBox70.Visible = true;
			textBox71.Visible = true;
			textBox73.Visible = true;
			textBox74.Visible = true;
			textBox75.Visible = true;
			textBox121.Visible = true;
			
			}
			else if(button9.Visible == true){
			Button5Click(null,null);
			button9.Visible = false;			
			textBox17.Visible = false;
			textBox7.Visible = false;
			textBox8.Visible = false;
			textBox9.Visible = false;
			textBox10.Visible = false;
			textBox11.Visible = false;
			textBox12.Visible = false;
			textBox13.Visible = false;
			textBox14.Visible = false;
			textBox16.Visible = false;
			textBox18.Visible = false;
			textBox20.Visible = false;
			textBox21.Visible = false;
			textBox22.Visible = false;
			textBox24.Visible = false;
			textBox25.Visible = false;
			textBox29.Visible = false;
			textBox30.Visible = false;
			textBox31.Visible = false;
			textBox34.Visible = false;
			textBox35.Visible = false;
			textBox36.Visible = false;
			textBox37.Visible = false;
			textBox38.Visible = false;
			textBox39.Visible = false;
			textBox62.Visible = false;
			textBox61.Visible = false;
			textBox65.Visible = false;
			textBox64.Visible = false;
			textBox63.Visible = false;
			textBox66.Visible = false;
			textBox69.Visible = false;
			textBox70.Visible = false;
			textBox71.Visible = false;
			textBox73.Visible = false;
			textBox74.Visible = false;
			textBox75.Visible = false;
			textBox121.Visible = false;
			}
		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.sdella set  POszam = @POszam, Operator1 = @Operator1, SOszam = @SOszam, Termeles = @Termeles, Anyagkod = @Anyagkod,
			Anyagnev = @Anyagnev, Termelesidokezd = @Termelesidokezd, Termelesidoveg = @Termelesidoveg, M20M60 = @M20M60, Emulzio = @Emulzio, Feed = @Feed,
			Csorend = @Csorend, Folyadek = @Folyadek, Panel = @Panel, Soell = @Soell, Sofoly = @Sofoly, Folymel = @Folymel,
			Folyhom = @Folyhom, Leiras = @Leiras, Tiszta = @Tiszta, Tomites = @Tomites, Csomag = @Csomag,
			Cimkek = @Cimkek, Csomagtiszta = @Csomagtiszta, Foliaheg = @Foliaheg, Hanemtakarit = @Hanemtakarit, Foldob1 = @Foldob1, Foldob2 = @Foldob2,
			sampdb = @sampdb, sampsuly = @sampsuly, szitameret = @szitameret, tisztaszaraz = @tisztaszaraz, szitahibatlan = @szitahibatlan, idegenanyag = @idegenanyag,
			Leiras1 = @Leiras1, vas = @vas, nemvas = @nemvas, rozsda = @rozsda, vasu = @vasu, nemvasu = @nemvasu,
			rozsdau = @rozsdau, Leiras2 = @Leiras2, mixtankkezdl = @mixtankkezdl, mixtankvegl = @mixtankvegl, mixtankelll = @mixtankelll, mixtankmsl = @mixtankmsl,
			sdkezdl = @sdkezdl, sdvegl = @sdvegl, sdelll = @sdelll, sdmsl = @sdmsl, kiszaritaskezds = @kiszaritaskezds, kiszaritasvegs = @kiszaritasvegs,
			mixtankkezdk = @mixtankkezdk, mixtankvegk = @mixtankvegk, mixtankellk = @mixtankellk, mixtankmsk = @mixtankmsk,
			sdkezdk = @sdkezdk, sdkvegk = @sdkvegk, sdellk = @sdellk, sdms = @sdms, kiszaritaskezdc = @kiszaritaskezdc,
			kiszaritasvegc = @kiszaritasvegc, mixtankmosl = @mixtankmosl, sdmosl = @sdmosl, mixtankmosk = @mixtankmosk, sdmosk = @sdmosk, kiszaritasszars = @kiszaritasszars,
			kiszaritasszarc = @kiszaritasszarc, Labor = @Labor, Leiras3 = @Leiras3, Keztermek = @Keztermek, Kezszita = @Kezszita, Kezsd = @Kezsd,
			Kezcsomag = @Kezcsomag, Kezemul = @Kezemul, Kezkorny = @Kezkorny, Leiras4 = @Leiras4, Datumd = @Datumd, Kezjegy = @Kezjegy, lugos = @lugos, savas = @savas, kosher = @kosher, etalon = @etalon, detszam = @detszam,
			Szitaid1 = @Szitaid1, Szitaid2 = @Szitaid2
			WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesidokezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesidoveg", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@M20M60", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Emulzio", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@Feed", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Csorend", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyadek", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Panel", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@Soell", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@Sofoly", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@Folymel", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyhom", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@Tiszta", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@Tomites", textBox18.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomag", textBox19.Text));
			cmd.Parameters.Add(new SqlParameter("@Cimkek", textBox20.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagtiszta", textBox21.Text));
			cmd.Parameters.Add(new SqlParameter("@Foliaheg", textBox22.Text));
			cmd.Parameters.Add(new SqlParameter("@Hanemtakarit", textBox23.Text));
			cmd.Parameters.Add(new SqlParameter("@Foldob1", textBox24.Text));
			cmd.Parameters.Add(new SqlParameter("@Foldob2", textBox25.Text));
			cmd.Parameters.Add(new SqlParameter("@sampdb", textBox26.Text));
			cmd.Parameters.Add(new SqlParameter("@sampsuly", textBox27.Text));			
			cmd.Parameters.Add(new SqlParameter("@szitameret", textBox28.Text));
			cmd.Parameters.Add(new SqlParameter("@tisztaszaraz", textBox29.Text));
			cmd.Parameters.Add(new SqlParameter("@szitahibatlan", textBox30.Text));
			cmd.Parameters.Add(new SqlParameter("@idegenanyag", textBox31.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras1", textBox32.Text));
			cmd.Parameters.Add(new SqlParameter("@vas", textBox34.Text));
			cmd.Parameters.Add(new SqlParameter("@nemvas", textBox35.Text));		
			cmd.Parameters.Add(new SqlParameter("@rozsda", textBox36.Text));
			cmd.Parameters.Add(new SqlParameter("@vasu", textBox37.Text));
			cmd.Parameters.Add(new SqlParameter("@nemvasu", textBox38.Text));
			cmd.Parameters.Add(new SqlParameter("@rozsdau", textBox39.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras2", textBox40.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankkezdl", textBox41.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankvegl", textBox42.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankelll", textBox43.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankmsl", textBox44.Text));
			cmd.Parameters.Add(new SqlParameter("@sdkezdl", textBox48.Text));
			cmd.Parameters.Add(new SqlParameter("@sdvegl", textBox47.Text));
			cmd.Parameters.Add(new SqlParameter("@sdelll", textBox46.Text));
			cmd.Parameters.Add(new SqlParameter("@sdmsl", textBox45.Text));
			cmd.Parameters.Add(new SqlParameter("@kiszaritaskezds", textBox52.Text));
			cmd.Parameters.Add(new SqlParameter("@kiszaritasvegs", textBox51.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankkezdk", textBox54.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankvegk", textBox53.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankellk", textBox50.Text));	
			cmd.Parameters.Add(new SqlParameter("@mixtankmsk", textBox49.Text));
			cmd.Parameters.Add(new SqlParameter("@sdkezdk", textBox58.Text));
			cmd.Parameters.Add(new SqlParameter("@sdkvegk", textBox57.Text));
			cmd.Parameters.Add(new SqlParameter("@sdellk", textBox56.Text));
			cmd.Parameters.Add(new SqlParameter("@sdms", textBox55.Text));
			cmd.Parameters.Add(new SqlParameter("@kiszaritaskezdc", textBox60.Text));
			cmd.Parameters.Add(new SqlParameter("@kiszaritasvegc", textBox59.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankmosl", textBox62.Text));
			cmd.Parameters.Add(new SqlParameter("@sdmosl", textBox61.Text));
			cmd.Parameters.Add(new SqlParameter("@mixtankmosk", textBox64.Text));
			cmd.Parameters.Add(new SqlParameter("@sdmosk", textBox63.Text));
			cmd.Parameters.Add(new SqlParameter("@kiszaritasszars", textBox65.Text));
			cmd.Parameters.Add(new SqlParameter("@kiszaritasszarc", textBox66.Text));
			cmd.Parameters.Add(new SqlParameter("@Labor", textBox67.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras3", textBox68.Text));
			cmd.Parameters.Add(new SqlParameter("@Keztermek", textBox69.Text));
			cmd.Parameters.Add(new SqlParameter("@Kezszita", textBox70.Text));
			cmd.Parameters.Add(new SqlParameter("@Kezsd", textBox71.Text));
			cmd.Parameters.Add(new SqlParameter("@Kezcsomag", textBox73.Text));
			cmd.Parameters.Add(new SqlParameter("@Kezemul", textBox74.Text));	
			cmd.Parameters.Add(new SqlParameter("@Kezkorny", textBox75.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras4", textBox76.Text));
			cmd.Parameters.Add(new SqlParameter("@Datumd", textBox77.Text));
			cmd.Parameters.Add(new SqlParameter("@Kezjegy", textBox78.Text));
			cmd.Parameters.Add(new SqlParameter("@lugos", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@savas", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@kosher", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@etalon", textBox121.Text));
			cmd.Parameters.Add(new SqlParameter("@detszam", textBox33.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitaid1", textBox123.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitaid2", textBox122.Text));	
			cmd.ExecuteNonQuery();
			conn.Close();

			Button5Click(null,null);	
		
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
	}
}
