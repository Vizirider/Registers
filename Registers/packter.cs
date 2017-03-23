/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-14
 * Time: 09:09
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
	/// Description of packter.
	/// </summary>
	public partial class packter : Form
	{
		public packter(string mws, string po)
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
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.packkom WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox82.Text = (read["Adminkomment"].ToString());		
				if (!string.IsNullOrWhiteSpace(textBox82.Text))
				{textBox82.BackColor = Color.Yellow;
				}
				}
				read.Close();	
			}
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
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packella set Tisztaszar = @Tisztaszar, Tomitescsatlakozo = @Tomitescsatlakozo, Lugoscsomagmos = @Lugoscsomagmos, Lugoscsomagszar = @Lugoscsomagszar, Savasalkmos = @Savasalkmos, Savasalkszar = @Savasalkszar
			WHERE POszam LIKE ('" + comboBox1.Text + "%')", conn);
			cmd.Parameters.Add(new SqlParameter("@Tisztaszar", 1));
			cmd.Parameters.Add(new SqlParameter("@Tomitescsatlakozo", 1));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagmos", 1));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagszar", 1));
			cmd.Parameters.Add(new SqlParameter("@Savasalkmos", 1));
			cmd.Parameters.Add(new SqlParameter("@Savasalkszar", 1));			
			cmd.ExecuteNonQuery();
			conn.Close();	
			
			Button5Click(null,null);
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packella set Ellenorizve = 1, Ellenorzo='" + comboBox5.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");	
			this.Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.packella WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					comboBox2.Text = (read["Operator1"].ToString());
					textBox4.Text = (read["SOszam"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termeles"]).ToString();
					textBox2.Text = (read["Anyagkod"].ToString());
					textBox1.Text = (read["Anyagnev"].ToString());
					textBox5.Text = (read["Termeleskezd"].ToString());
					textBox3.Text = (read["Termelesveg"].ToString());
					textBox6.Text = (read["Csomagolo"].ToString());
					textBox7.Text = (read["Urit4"].ToString());
					textBox8.Text = (read["Fluidi"].ToString());
					textBox9.Text = (read["Anyagkitoltibc"].ToString());
					textBox10.Text = (read["Anyagleadkitolt"].ToString());
					textBox13.Text = (read["Anyaglassibc"].ToString());
					textBox11.Text = (read["Kevesanyagibc"].ToString());
					textBox12.Text = (read["Folyosanyag"].ToString());
					textBox14.Text = (read["Tisztaszar"].ToString());
					textBox15.Text = (read["Tomitescsatlakozo"].ToString());
					textBox16.Text = (read["Takaritunke"].ToString());
					textBox17.Text = (read["Twisttuck1"].ToString());
					textBox18.Text = (read["Twisttuck2"].ToString());
					textBox19.Text = (read["Cimkejohelyen"].ToString());
					textBox20.Text = (read["Csomagoloanyagtiszta"].ToString());
					textBox21.Text = (read["Zarasmegfelelo"].ToString());
					textBox22.Text = (read["Foliahegesztesjo"].ToString());
					textBox25.Text = (read["Leiras1"].ToString());
					textBox26.Text = (read["Innerliner"].ToString());
					textBox23.Text = (read["Elsodoboz"].ToString());
					textBox24.Text = (read["Utolsodoboz"].ToString());
					dateTimePicker2.Text = Convert.ToDateTime(read["Datum1"]).ToString();
					textBox27.Text = (read["Operator2"].ToString());
					textBox29.Text = (read["Mintavetel"].ToString());
					textBox28.Text = (read["Megfelelocimke"].ToString());
					textBox30.Text = (read["Szitameret"].ToString());
					textBox31.Text = (read["Tisztaszaranyag"].ToString());
					textBox32.Text = (read["Hibatlanszita"].ToString());
					textBox33.Text = (read["Idegenanyag"].ToString());
					textBox34.Text = (read["Operator3"].ToString());
					textBox35.Text = (read["Vase"].ToString());
					textBox36.Text = (read["Nemvase"].ToString());
					textBox37.Text = (read["Rozsdae"].ToString());
					textBox38.Text = (read["Vasu"].ToString());
					textBox39.Text = (read["Nemvasu"].ToString());
					textBox40.Text = (read["Rozsau"].ToString());
					textBox41.Text = (read["Leiras2"].ToString());
					textBox42.Text = (read["Operator4"].ToString());
					textBox43.Text = (read["Lugoscsomagkezd"].ToString());
					textBox44.Text = (read["Lugoscsomagveg"].ToString());
					textBox45.Text = (read["Lugoscsomagcheck"].ToString());
					textBox46.Text = (read["Lugoscsomagms"].ToString());
					textBox47.Text = (read["Lugoscsomagmos"].ToString());
					textBox48.Text = (read["Lugoscsomagszar"].ToString());
					textBox52.Text = (read["Savasalkkezd"].ToString());
					textBox51.Text = (read["Savasalkveg"].ToString());
					textBox50.Text = (read["Savasalkcheck"].ToString());
					textBox49.Text = (read["Savasalkms"].ToString());
					textBox66.Text = (read["Savasalkmos"].ToString());
					textBox65.Text = (read["Savasalkszar"].ToString());
					textBox56.Text = (read["Koshercipkezd"].ToString());
					textBox55.Text = (read["Koshercipveg"].ToString());
					textBox54.Text = (read["Koshercipcheck"].ToString());
					textBox53.Text = (read["Koshercipms"].ToString());
					textBox68.Text = (read["Koshercipmos"].ToString());
					textBox67.Text = (read["Koshercipszar"].ToString());
					textBox60.Text = (read["Csomagkezd"].ToString());
					textBox59.Text = (read["Csomagveg"].ToString());
					textBox58.Text = (read["Csomagcheck"].ToString());
					textBox57.Text = (read["Csomagms"].ToString());
					textBox70.Text = (read["Csomagmos"].ToString());
					textBox69.Text = (read["Csomagszar"].ToString());
					textBox64.Text = (read["Alkatkezd"].ToString());
					textBox63.Text = (read["Alkatveg"].ToString());
					textBox62.Text = (read["Alkatcheck"].ToString());
					textBox61.Text = (read["Alkatms"].ToString());
					textBox72.Text = (read["Alkatmos"].ToString());
					textBox71.Text = (read["Alkatszar"].ToString());
					textBox74.Text = (read["Leiras3"].ToString());
					textBox73.Text = (read["Operator5"].ToString());
					textBox75.Text = (read["Szitabetet"].ToString());
					textBox76.Text = (read["Szita"].ToString());
					textBox77.Text = (read["Csomagkez"].ToString());
					textBox78.Text = (read["Csomagtiszt"].ToString());
					textBox79.Text = (read["Munkakor"].ToString());
					textBox81.Text = (read["Komment"].ToString());
					textBox83.Text = (read["Boxhand"].ToString());
					textBox84.Text = (read["Boxoperator"].ToString());
					comboBox3.Text = (read["Ellenorzo"].ToString());
					
			        if(read["Lugos"] == DBNull.Value){
			        	checkBox4.Checked = false;
			        }
			        else{
			        checkBox4.Checked = (bool)read["Lugos"];			        	
			        }	
			        if(read["Savas"] == DBNull.Value){
			        	checkBox1.Checked = false;
			        }
			        else{
			        checkBox1.Checked = (bool)read["Savas"];			        	
			        }
			        if(read["Kosher"] == DBNull.Value){
			        	checkBox3.Checked = false;
			        }
			        else{
			        checkBox3.Checked = (bool)read["Kosher"];			        	
			        }			        	
			        if(read["Bigbag"] == DBNull.Value){
			        	checkBox2.Checked = false;
			        }
			        else{
			        checkBox2.Checked = true;			        	
			        }


	if (!string.IsNullOrWhiteSpace(textBox43.Text))
	{textBox43.Text = textBox43.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox44.Text))
	{textBox44.Text = textBox44.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox45.Text))
	{textBox45.Text = textBox45.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox52.Text))
	{textBox52.Text = textBox52.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox51.Text))
	{textBox51.Text = textBox51.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox50.Text))
	{textBox50.Text = textBox50.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox56.Text))
	{textBox56.Text = textBox56.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox55.Text))
	{textBox55.Text = textBox55.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox54.Text))
	{textBox54.Text = textBox54.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox60.Text))
	{textBox60.Text = textBox60.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox59.Text))
	{textBox59.Text = textBox59.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox58.Text))
	{textBox58.Text = textBox58.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox64.Text))
	{textBox64.Text = textBox64.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox63.Text))
	{textBox63.Text = textBox63.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox62.Text))
	{textBox62.Text = textBox62.Text.Substring(11);
	}

				}
				panel16.Visible |= textBox14.Text == "1";
				panel2.Visible |= textBox15.Text == "1";
				panel3.Visible |= textBox16.Text == "1";
				panel4.Visible |= textBox19.Text == "1";
				panel5.Visible |= textBox20.Text == "1";
				panel6.Visible |= textBox21.Text == "1";
				panel7.Visible |= textBox22.Text == "1";
				panel8.Visible |= textBox23.Text == "1";
				panel9.Visible |= textBox24.Text == "1";
				panel10.Visible |= textBox29.Text == "1";
				panel11.Visible |= textBox28.Text == "1";
				panel12.Visible |= textBox31.Text == "1";
				panel13.Visible |= textBox32.Text == "1";
				panel14.Visible |= textBox33.Text == "1";
				panel15.Visible |= textBox35.Text == "1";
				panel17.Visible |= textBox36.Text == "1";
				panel18.Visible |= textBox37.Text == "1";
				panel19.Visible |= textBox38.Text == "1";
				panel20.Visible |= textBox39.Text == "1";
				panel21.Visible |= textBox40.Text == "1";
				panel22.Visible |= textBox47.Text == "1";
				panel23.Visible |= textBox66.Text == "1";
				panel24.Visible |= textBox68.Text == "1";
				panel25.Visible |= textBox70.Text == "1";
				panel26.Visible |= textBox72.Text == "1";
				panel27.Visible |= textBox48.Text == "1";
				panel28.Visible |= textBox65.Text == "1";
				panel29.Visible |= textBox67.Text == "1";
				panel30.Visible |= textBox69.Text == "1";
				panel31.Visible |= textBox71.Text == "1";
				panel32.Visible |= textBox75.Text == "1";
				panel33.Visible |= textBox76.Text == "1";
				panel34.Visible |= textBox77.Text == "1";
				panel35.Visible |= textBox78.Text == "1";
				panel36.Visible |= textBox79.Text == "1";
				panel77.Visible |= textBox7.Text == "1";
				panel79.Visible |= textBox8.Text == "1";
				
				panel75.Visible |= textBox14.Text == "2";
				panel74.Visible |= textBox15.Text == "2";
				panel73.Visible |= textBox16.Text == "2";
				panel72.Visible |= textBox19.Text == "2";
				panel71.Visible |= textBox20.Text == "2";
				panel70.Visible |= textBox21.Text == "2";
				panel69.Visible |= textBox22.Text == "2";
				panel68.Visible |= textBox23.Text == "2";
				panel67.Visible |= textBox24.Text == "2";
				panel66.Visible |= textBox29.Text == "2";
				panel65.Visible |= textBox28.Text == "2";
				panel64.Visible |= textBox31.Text == "2";
				panel63.Visible |= textBox32.Text == "2";
				panel62.Visible |= textBox33.Text == "2";
				panel61.Visible |= textBox35.Text == "2";
				panel60.Visible |= textBox36.Text == "2";
				panel59.Visible |= textBox37.Text == "2";
				panel58.Visible |= textBox38.Text == "2";
				panel57.Visible |= textBox39.Text == "2";
				panel56.Visible |= textBox40.Text == "2";
				panel55.Visible |= textBox47.Text == "2";
				panel54.Visible |= textBox66.Text == "2";
				panel53.Visible |= textBox68.Text == "2";
				panel52.Visible |= textBox70.Text == "2";
				panel51.Visible |= textBox72.Text == "2";
				panel50.Visible |= textBox48.Text == "2";
				panel49.Visible |= textBox65.Text == "2";
				panel44.Visible |= textBox67.Text == "2";
				panel43.Visible |= textBox69.Text == "2";
				panel42.Visible |= textBox71.Text == "2";
				panel41.Visible |= textBox75.Text == "2";
				panel40.Visible |= textBox76.Text == "2";
				panel39.Visible |= textBox77.Text == "2";
				panel38.Visible |= textBox78.Text == "2";
				panel37.Visible |= textBox79.Text == "2";
				panel76.Visible |= textBox7.Text == "2";
				panel78.Visible |= textBox8.Text == "2";
				
				panel80.Visible |= textBox6.Text == "1";
				panel81.Visible |= textBox6.Text == "2";
				panel82.Visible |= textBox6.Text == "3";
				panel83.Visible |= textBox6.Text == "4";
				panel84.Visible |= textBox6.Text == "6";
				panel85.Visible |= textBox6.Text == "7";
				
		}
			Button6Click(null,null);
	}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.packkom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox82.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox82.BackColor = Color.Yellow;				
		}
		void Button2MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Elütések javítása");	
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(button9.Visible == false){
			button9.Visible = true;	
			textBox14.Visible = true;
			textBox15.Visible = true;
			textBox16.Visible = true;
			textBox19.Visible = true;
			textBox20.Visible = true;
			textBox21.Visible = true;
			textBox22.Visible = true;
			textBox23.Visible = true;
			textBox24.Visible = true;
			textBox29.Visible = true;
			textBox28.Visible = true;
			textBox31.Visible = true;
			textBox32.Visible = true;
			textBox33.Visible = true;
			textBox35.Visible = true;
			textBox36.Visible = true;
			textBox37.Visible = true;
			textBox38.Visible = true;
			textBox39.Visible = true;
			textBox40.Visible = true;
			textBox47.Visible = true;
			textBox66.Visible = true;
			textBox68.Visible = true;
			textBox70.Visible = true;
			textBox72.Visible = true;
			textBox48.Visible = true;
			textBox65.Visible = true;
			textBox67.Visible = true;
			textBox69.Visible = true;
			textBox71.Visible = true;
			textBox75.Visible = true;
			textBox76.Visible = true;
			textBox77.Visible = true;
			textBox78.Visible = true;
			textBox79.Visible = true;
			
			}
			else if(button9.Visible == true){
			Button5Click(null,null);
			button9.Visible = false;	
			textBox14.Visible = false;
			textBox15.Visible = false;
			textBox16.Visible = false;
			textBox19.Visible = false;
			textBox20.Visible = false;
			textBox21.Visible = false;
			textBox22.Visible = false;
			textBox23.Visible = false;
			textBox24.Visible = false;
			textBox29.Visible = false;
			textBox28.Visible = false;
			textBox31.Visible = false;
			textBox32.Visible = false;
			textBox33.Visible = false;
			textBox35.Visible = false;
			textBox36.Visible = false;
			textBox37.Visible = false;
			textBox38.Visible = false;
			textBox39.Visible = false;
			textBox40.Visible = false;
			textBox47.Visible = false;
			textBox66.Visible = false;
			textBox68.Visible = false;
			textBox70.Visible = false;
			textBox72.Visible = false;
			textBox48.Visible = false;
			textBox65.Visible = false;
			textBox67.Visible = false;
			textBox69.Visible = false;
			textBox71.Visible = false;
			textBox75.Visible = false;
			textBox76.Visible = false;
			textBox77.Visible = false;
			textBox78.Visible = false;
			textBox79.Visible = false;			}	
		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packella set  POszam = @POszam, Operator1 = @Operator1, SOszam = @SOszam, Termeles = @Termeles, Anyagkod = @Anyagkod,
			Anyagnev = @Anyagnev, Termeleskezd = @Termeleskezd, Termelesveg = @Termelesveg, Csomagolo = @Csomagolo, Urit4 = @Urit4, Fluidi = @Fluidi,
			Anyagkitoltibc = @Anyagkitoltibc, Anyagleadkitolt = @Anyagleadkitolt, Anyaglassibc = @Anyaglassibc, Kevesanyagibc = @Kevesanyagibc, Folyosanyag = @Folyosanyag, Tisztaszar = @Tisztaszar,
			Tomitescsatlakozo = @Tomitescsatlakozo, Takaritunke = @Takaritunke, Twisttuck1 = @Twisttuck1, Twisttuck2 = @Twisttuck2, Cimkejohelyen = @Cimkejohelyen,
			Csomagoloanyagtiszta = @Csomagoloanyagtiszta, Zarasmegfelelo = @Zarasmegfelelo, Foliahegesztesjo = @Foliahegesztesjo, Leiras1 = @Leiras1, Innerliner = @Innerliner, Elsodoboz = @Elsodoboz,
			Utolsodoboz = @Utolsodoboz, Datum1 = @Datum1, Operator2 = @Operator2, Mintavetel = @Mintavetel, Megfelelocimke = @Megfelelocimke, Szitameret = @Szitameret,
			Tisztaszaranyag = @Tisztaszaranyag, Hibatlanszita = @Hibatlanszita, Idegenanyag = @Idegenanyag, Operator3 = @Operator3, Vase = @Vase, Nemvase = @Nemvase,
			Rozsdae = @Rozsdae, Vasu = @Vasu, Nemvasu = @Nemvasu, Rozsau = @Rozsau, Leiras2 = @Leiras2, Operator4 = @Operator4,
			Lugoscsomagkezd = @Lugoscsomagkezd, Lugoscsomagveg = @Lugoscsomagveg, Lugoscsomagcheck = @Lugoscsomagcheck, Lugoscsomagms = @Lugoscsomagms, Lugoscsomagmos = @Lugoscsomagmos, Lugoscsomagszar = @Lugoscsomagszar,
			Savasalkkezd = @Savasalkkezd, Savasalkveg = @Savasalkveg, Savasalkcheck = @Savasalkcheck, Savasalkms = @Savasalkms, Savasalkmos = @Savasalkmos,
			Savasalkszar = @Savasalkszar, Koshercipkezd = @Koshercipkezd, Koshercipveg = @Koshercipveg, Koshercipcheck = @Koshercipcheck, Koshercipms = @Koshercipms, Koshercipmos = @Koshercipmos,
			Koshercipszar = @Koshercipszar, Csomagkezd = @Csomagkezd, Csomagveg = @Csomagveg, Csomagcheck = @Csomagcheck, Csomagms = @Csomagms, Csomagmos = @Csomagmos,
			Csomagszar = @Csomagszar, Alkatkezd = @Alkatkezd, Alkatveg = @Alkatveg, Alkatcheck = @Alkatcheck, Alkatms = @Alkatms, Alkatmos = @Alkatmos,
			Alkatszar = @Alkatszar, Leiras3 = @Leiras3, Operator5 = @Operator5, Szitabetet = @Szitabetet, Szita = @Szita, Csomagkez = @Csomagkez,
			Csomagtiszt = @Csomagtiszt, Munkakor = @Munkakor, Komment = @Komment, Lugos = @Lugos, Savas = @Savas, Kosher = @Kosher
			WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeleskezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesveg", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagolo", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Urit4", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Fluidi", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkitoltibc", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagleadkitolt", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyaglassibc", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@Kevesanyagibc", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyosanyag", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@Tisztaszar", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@Tomitescsatlakozo", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@Takaritunke", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@Twisttuck1", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@Twisttuck2", textBox18.Text));
			cmd.Parameters.Add(new SqlParameter("@Cimkejohelyen", textBox19.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagoloanyagtiszta", textBox20.Text));
			cmd.Parameters.Add(new SqlParameter("@Zarasmegfelelo", textBox21.Text));
			cmd.Parameters.Add(new SqlParameter("@Foliahegesztesjo", textBox22.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras1", textBox25.Text));
			cmd.Parameters.Add(new SqlParameter("@Innerliner", textBox26.Text));
			cmd.Parameters.Add(new SqlParameter("@Elsodoboz", textBox23.Text));
			cmd.Parameters.Add(new SqlParameter("@Utolsodoboz", textBox24.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum1", dateTimePicker2.Text));			
			cmd.Parameters.Add(new SqlParameter("@Operator2", textBox27.Text));
			cmd.Parameters.Add(new SqlParameter("@Mintavetel", textBox29.Text));
			cmd.Parameters.Add(new SqlParameter("@Megfelelocimke", textBox28.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitameret", textBox30.Text));
			cmd.Parameters.Add(new SqlParameter("@Tisztaszaranyag", textBox31.Text));
			cmd.Parameters.Add(new SqlParameter("@Hibatlanszita", textBox32.Text));
			cmd.Parameters.Add(new SqlParameter("@Idegenanyag", textBox33.Text));		
			cmd.Parameters.Add(new SqlParameter("@Operator3", textBox34.Text));
			cmd.Parameters.Add(new SqlParameter("@Vase", textBox35.Text));
			cmd.Parameters.Add(new SqlParameter("@Nemvase", textBox36.Text));
			cmd.Parameters.Add(new SqlParameter("@Rozsdae", textBox37.Text));
			cmd.Parameters.Add(new SqlParameter("@Vasu", textBox38.Text));
			cmd.Parameters.Add(new SqlParameter("@Nemvasu", textBox39.Text));
			cmd.Parameters.Add(new SqlParameter("@Rozsau", textBox40.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras2", textBox41.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator4", textBox42.Text));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagkezd", textBox43.Text));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagveg", textBox44.Text));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagcheck", textBox45.Text));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagms", textBox46.Text));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagmos", textBox47.Text));
			cmd.Parameters.Add(new SqlParameter("@Lugoscsomagszar", textBox48.Text));
			cmd.Parameters.Add(new SqlParameter("@Savasalkkezd", textBox52.Text));
			cmd.Parameters.Add(new SqlParameter("@Savasalkveg", textBox51.Text));
			cmd.Parameters.Add(new SqlParameter("@Savasalkcheck", textBox50.Text));
			cmd.Parameters.Add(new SqlParameter("@Savasalkms", textBox49.Text));	
			cmd.Parameters.Add(new SqlParameter("@Savasalkmos", textBox66.Text));
			cmd.Parameters.Add(new SqlParameter("@Savasalkszar", textBox65.Text));
			cmd.Parameters.Add(new SqlParameter("@Koshercipkezd", textBox56.Text));
			cmd.Parameters.Add(new SqlParameter("@Koshercipveg", textBox55.Text));
			cmd.Parameters.Add(new SqlParameter("@Koshercipcheck", textBox54.Text));
			cmd.Parameters.Add(new SqlParameter("@Koshercipms", textBox53.Text));
			cmd.Parameters.Add(new SqlParameter("@Koshercipmos", textBox68.Text));
			cmd.Parameters.Add(new SqlParameter("@Koshercipszar", textBox67.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagkezd", textBox60.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagveg", textBox59.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagcheck", textBox58.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagms", textBox57.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagmos", textBox70.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagszar", textBox69.Text));
			cmd.Parameters.Add(new SqlParameter("@Alkatkezd", textBox64.Text));
			cmd.Parameters.Add(new SqlParameter("@Alkatveg", textBox63.Text));
			cmd.Parameters.Add(new SqlParameter("@Alkatcheck", textBox62.Text));
			cmd.Parameters.Add(new SqlParameter("@Alkatms", textBox61.Text));
			cmd.Parameters.Add(new SqlParameter("@Alkatmos", textBox72.Text));
			cmd.Parameters.Add(new SqlParameter("@Alkatszar", textBox71.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras3", textBox74.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator5", textBox73.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitabetet", textBox75.Text));
			cmd.Parameters.Add(new SqlParameter("@Szita", textBox76.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagkez", textBox77.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagtiszt", textBox78.Text));
			cmd.Parameters.Add(new SqlParameter("@Munkakor", textBox79.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox81.Text));	
			cmd.Parameters.Add(new SqlParameter("@Lugos", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Savas", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kosher", checkBox3.Checked));			

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
