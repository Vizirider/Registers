/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-14
 * Time: 10:07
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
	/// Description of pf.
	/// </summary>
	public partial class pf : Form
	{
		public pf(string mws, string po)
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
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();	
		}
		void Button5Click(object sender, EventArgs e)
		{
		using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.pfella WHERE POszam = ('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					comboBox2.Text = (read["Operator1"].ToString());
					textBox4.Text = (read["SOszam"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termeles"]).ToString();	
					textBox1.Text = (read["Anyagkod"].ToString());
					textBox2.Text = (read["Anyagnev"].ToString());
					textBox5.Text = (read["Termelesidokezd"].ToString());
					textBox6.Text = (read["Termelesidoveg"].ToString());
					textBox3.Text = (read["reaktor"].ToString());
					textBox7.Text = (read["Reaktortiszta"].ToString());
					textBox8.Text = (read["Lodigetiszta"].ToString());
					textBox9.Text = (read["Puffer1tiszta"].ToString());
					textBox10.Text = (read["Puffer2tiszta"].ToString());
					textBox11.Text = (read["Csorendszertiszta"].ToString());
					textBox12.Text = (read["Folyadekbeatiszta"].ToString());
					textBox13.Text = (read["Panelfoltiszta"].ToString());
					textBox14.Text = (read["Soell"].ToString());
					textBox15.Text = (read["Sofolyell"].ToString());
					textBox16.Text = (read["Folyfelmel"].ToString());
					textBox17.Text = (read["Folyhom"].ToString());
					textBox18.Text = (read["Leiras1"].ToString());
					textBox19.Text = (read["Vonalatszerel"].ToString());
					textBox20.Text = (read["Vonalhasznal"].ToString());
					textBox21.Text = (read["Csatlakozohelyes"].ToString());
					textBox22.Text = (read["Vonalkonyok"].ToString());
					textBox47.Text = (read["Leiras2"].ToString());
					textBox23.Text = (read["Folytiszta"].ToString());
					textBox24.Text = (read["Folytomit"].ToString());
					textBox25.Text = (read["Folytak"].ToString());
					textBox26.Text = (read["Csomagazon"].ToString());
					textBox27.Text = (read["Cimkejo"].ToString());
					textBox28.Text = (read["Csomagtiszta"].ToString());
					textBox29.Text = (read["Zarasmegfelel"].ToString());
					textBox30.Text = (read["Elsodoboz"].ToString());
					textBox31.Text = (read["Utolsodoboz"].ToString());
					textBox32.Text = (read["Elteresleir"].ToString());
					textBox33.Text = (read["szitameret"].ToString());
					textBox34.Text = (read["folytak"].ToString());
					textBox45.Text = (read["elteresszuro"].ToString());
					textBox46.Text = (read["elteresall"].ToString());
					textBox37.Text = (read["mintavetel"].ToString());
					textBox43.Text = (read["mintavetelmegjegy"].ToString());
					textBox44.Text = (read["cimkezesmegj"].ToString());
					textBox39.Text = (read["gyartaskozivizs"].ToString());
					textBox40.Text = (read["szarazanyag"].ToString());
					textBox41.Text = (read["phmert"].ToString());
					textBox42.Text = (read["vizsgalatmegjegy"].ToString());
					textBox48.Text = (read["reaktorstart"].ToString());
					textBox49.Text = (read["reaktorveg"].ToString());
					textBox50.Text = (read["reaktoridopont"].ToString());
					textBox51.Text = (read["msertekreaktor"].ToString());
					textBox52.Text = (read["mosasutanreaktor"].ToString());
					textBox57.Text = (read["r601start"].ToString());
					textBox56.Text = (read["r601veg"].ToString());
					textBox55.Text = (read["r601idopont"].ToString());
					textBox54.Text = (read["r601ms"].ToString());
					textBox53.Text = (read["r601mosutan"].ToString());
					textBox62.Text = (read["pufferstart"].ToString());
					textBox61.Text = (read["pufferveg"].ToString());
					textBox60.Text = (read["pufferidopont"].ToString());
					textBox59.Text = (read["pufferms"].ToString());
					textBox58.Text = (read["pufferutan"].ToString());
					textBox67.Text = (read["folystart"].ToString());
					textBox66.Text = (read["folyveg"].ToString());
					textBox65.Text = (read["folyidopont"].ToString());
					textBox64.Text = (read["folyms"].ToString());
					textBox63.Text = (read["folyutan"].ToString());
					textBox68.Text = (read["ciputan"].ToString());
					textBox69.Text = (read["szuroe"].ToString());
					textBox70.Text = (read["kulsokor"].ToString());
					textBox71.Text = (read["ciputane"].ToString());
					textBox72.Text = (read["reaktore"].ToString());
					textBox73.Text = (read["csomage"].ToString());
					textBox74.Text = (read["puffere"].ToString());
					textBox96.Text = (read["munkakor"].ToString());
					textBox75.Text = (read["szurocomm"].ToString());
					textBox76.Text = (read["kulsokorcomm"].ToString());
					textBox77.Text = (read["ciputancomm"].ToString());
					textBox78.Text = (read["reaktorcomm"].ToString());
					textBox79.Text = (read["csomagcomm"].ToString());
					textBox80.Text = (read["puffercomm"].ToString());
					textBox81.Text = (read["munkakorcomm"].ToString());
					textBox82.Text = (read["szurodatum"].ToString());
					textBox83.Text = (read["szuroop"].ToString());
					textBox94.Text = (read["kulsodatum"].ToString());
					textBox89.Text = (read["kulsoop"].ToString());
					textBox95.Text = (read["ciputandatum"].ToString());
					textBox90.Text = (read["ciputanop"].ToString());
					textBox85.Text = (read["reaktordatum"].ToString());
					textBox91.Text = (read["reaktorop"].ToString());
					textBox86.Text = (read["csomagdatum"].ToString());
					textBox84.Text = (read["csomagop"].ToString());
					textBox87.Text = (read["pufferdatum"].ToString());
					textBox92.Text = (read["pufferop"].ToString());
					textBox88.Text = (read["munkakordatum"].ToString());
					textBox93.Text = (read["munkakorop"].ToString());
					comboBox4.Text = (read["Ellenorzo"].ToString());
					
		}
	if (!string.IsNullOrWhiteSpace(textBox5.Text))
	{textBox5.Text = textBox5.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox6.Text))
	{textBox6.Text = textBox6.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox48.Text))
	{textBox48.Text = textBox48.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox49.Text))
	{textBox49.Text = textBox49.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox50.Text))
	{textBox50.Text = textBox50.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox57.Text))
	{textBox57.Text = textBox57.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox56.Text))
	{textBox56.Text = textBox56.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox55.Text))
	{textBox55.Text = textBox55.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox62.Text))
	{textBox62.Text = textBox62.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox61.Text))
	{textBox61.Text = textBox61.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox60.Text))
	{textBox60.Text = textBox60.Text.Substring(11);
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

				panel16.Visible |= textBox7.Text == "1";
				panel3.Visible |= textBox8.Text == "1";
				panel7.Visible |= textBox9.Text == "1";
				panel6.Visible |= textBox10.Text == "1";
				panel11.Visible |= textBox11.Text == "1";
				panel10.Visible |= textBox12.Text == "1";
				panel13.Visible |= textBox13.Text == "1";
				panel22.Visible |= textBox14.Text == "1";
				panel20.Visible |= textBox15.Text == "1";
				panel21.Visible |= textBox16.Text == "1";
				panel19.Visible |= textBox17.Text == "1";
				panel24.Visible |= textBox19.Text == "1";
				panel26.Visible |= textBox20.Text == "1";
				panel28.Visible |= textBox21.Text == "1";
				panel30.Visible |= textBox22.Text == "1";
				panel32.Visible |= textBox23.Text == "1";
				panel34.Visible |= textBox24.Text == "1";
				panel36.Visible |= textBox25.Text == "1";
				panel38.Visible |= textBox27.Text == "1";
				panel40.Visible |= textBox28.Text == "1";
				panel42.Visible |= textBox29.Text == "1";
				panel44.Visible |= textBox30.Text == "1";
				panel46.Visible |= textBox31.Text == "1";
				panel49.Visible |= textBox34.Text == "1";
				panel50.Visible |= textBox35.Text == "1";
				panel52.Visible |= textBox36.Text == "1";
				panel54.Visible |= textBox37.Text == "1";
				panel56.Visible |= textBox38.Text == "1";
				panel58.Visible |= textBox52.Text == "1";
				panel60.Visible |= textBox53.Text == "1";
				panel62.Visible |= textBox58.Text == "1";
				panel64.Visible |= textBox63.Text == "1";
				panel66.Visible |= textBox68.Text == "1";
				panel68.Visible |= textBox69.Text == "1";
				panel70.Visible |= textBox70.Text == "1";
				panel72.Visible |= textBox71.Text == "1";
				panel74.Visible |= textBox72.Text == "1";
				panel77.Visible |= textBox73.Text == "1";
				panel79.Visible |= textBox74.Text == "1";
				panel81.Visible |= textBox96.Text == "1";

				panel75.Visible |= textBox7.Text == "2";
				panel2.Visible |= textBox8.Text == "2";
				panel5.Visible |= textBox9.Text == "2";
				panel4.Visible |= textBox10.Text == "2";
				panel9.Visible |= textBox11.Text == "2";
				panel8.Visible |= textBox12.Text == "2";
				panel12.Visible |= textBox13.Text == "2";
				panel18.Visible |= textBox14.Text == "2";
				panel15.Visible |= textBox15.Text == "2";
				panel17.Visible |= textBox16.Text == "2";
				panel14.Visible |= textBox17.Text == "2";
				panel23.Visible |= textBox19.Text == "2";
				panel25.Visible |= textBox20.Text == "2";
				panel27.Visible |= textBox21.Text == "2";
				panel29.Visible |= textBox22.Text == "2";
				panel31.Visible |= textBox23.Text == "2";
				panel33.Visible |= textBox24.Text == "2";
				panel35.Visible |= textBox25.Text == "2";
				panel37.Visible |= textBox27.Text == "2";
				panel39.Visible |= textBox28.Text == "2";
				panel41.Visible |= textBox29.Text == "2";
				panel43.Visible |= textBox30.Text == "2";
				panel45.Visible |= textBox31.Text == "2";
				panel47.Visible |= textBox34.Text == "2";
				panel49.Visible |= textBox35.Text == "2";
				panel51.Visible |= textBox36.Text == "2";
				panel53.Visible |= textBox37.Text == "2";
				panel55.Visible |= textBox38.Text == "2";
				panel57.Visible |= textBox52.Text == "2";
				panel59.Visible |= textBox53.Text == "2";
				panel61.Visible |= textBox58.Text == "2";
				panel63.Visible |= textBox63.Text == "2";
				panel65.Visible |= textBox68.Text == "2";
				panel67.Visible |= textBox69.Text == "2";
				panel69.Visible |= textBox70.Text == "2";
				panel71.Visible |= textBox71.Text == "2";
				panel73.Visible |= textBox72.Text == "2";
				panel76.Visible |= textBox73.Text == "2";
				panel78.Visible |= textBox74.Text == "2";
				panel80.Visible |= textBox96.Text == "2";
				
		}
			Button6Click(null,null);
	}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.pfella set Ellenorizve = 1, Ellenorzo='" + comboBox5.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			this.Close();
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.pfkom WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox97.Text = (read["Adminkomment"].ToString());		
				if (!string.IsNullOrWhiteSpace(textBox97.Text))
				{textBox97.BackColor = Color.Yellow;
				}
				}
				read.Close();	
			}		
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.pfkom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox97.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox97.BackColor = Color.Yellow;			
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.pfella set Reaktortiszta = @Reaktortiszta, Lodigetiszta = @Lodigetiszta, Puffer1tiszta = @Puffer1tiszta, Puffer2tiszta = @Puffer2tiszta,
			Csorendszertiszta = @Csorendszertiszta, Folyadekbeatiszta = @Folyadekbeatiszta, Panelfoltiszta = @Panelfoltiszta, Folytiszta = @Folytiszta
			WHERE POszam LIKE ('" + comboBox1.Text + "%')", conn);
			cmd.Parameters.Add(new SqlParameter("@Reaktortiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Lodigetiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Puffer1tiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Puffer2tiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Csorendszertiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Folyadekbeatiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Panelfoltiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@Folytiszta", 1));		
			
			cmd.ExecuteNonQuery();
			conn.Close();	
			
			Button5Click(null,null);	
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(button9.Visible == false){
			button9.Visible = true;	
			textBox7.Visible = true;
			textBox8.Visible = true;
			textBox9.Visible = true;
			textBox10.Visible = true;
			textBox11.Visible = true;
			textBox12.Visible = true;
			textBox13.Visible = true;
			textBox14.Visible = true;
			textBox16.Visible = true;
			textBox17.Visible = true;
			textBox19.Visible = true;
			textBox20.Visible = true;
			textBox21.Visible = true;
			textBox22.Visible = true;
			textBox23.Visible = true;
			textBox24.Visible = true;
			textBox25.Visible = true;
			textBox27.Visible = true;
			textBox28.Visible = true;
			textBox29.Visible = true;
			textBox30.Visible = true;
			textBox31.Visible = true;
			textBox34.Visible = true;
			textBox35.Visible = true;
			textBox36.Visible = true;
			textBox37.Visible = true;
			textBox38.Visible = true;
			textBox52.Visible = true;
			textBox53.Visible = true;
			textBox58.Visible = true;
			textBox63.Visible = true;
			textBox68.Visible = true;
			textBox69.Visible = true;
			textBox70.Visible = true;
			textBox71.Visible = true;
			textBox72.Visible = true;
			textBox73.Visible = true;
			textBox74.Visible = true;
			textBox96.Visible = true;
			
			}
			else if(button9.Visible == true){
			button9.Visible = false;	
			textBox7.Visible = false;
			textBox8.Visible = false;
			textBox9.Visible = false;
			textBox10.Visible = false;
			textBox11.Visible = false;
			textBox12.Visible = false;
			textBox13.Visible = false;
			textBox14.Visible = false;
			textBox16.Visible = false;
			textBox17.Visible = false;
			textBox19.Visible = false;
			textBox20.Visible = false;
			textBox21.Visible = false;
			textBox22.Visible = false;
			textBox23.Visible = false;
			textBox24.Visible = false;
			textBox25.Visible = false;
			textBox27.Visible = false;
			textBox28.Visible = false;
			textBox29.Visible = false;
			textBox30.Visible = false;
			textBox31.Visible = false;
			textBox34.Visible = false;
			textBox35.Visible = false;
			textBox36.Visible = false;
			textBox37.Visible = false;
			textBox38.Visible = false;
			textBox52.Visible = false;
			textBox53.Visible = false;
			textBox58.Visible = false;
			textBox63.Visible = false;
			textBox68.Visible = false;
			textBox69.Visible = false;
			textBox70.Visible = false;
			textBox71.Visible = false;
			textBox72.Visible = false;
			textBox73.Visible = false;
			textBox74.Visible = false;
			textBox96.Visible = false;		}
	
		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.pfella set  POszam = @POszam, Operator1 = @Operator1, SOszam = @SOszam, Termeles = @Termeles, Anyagkod = @Anyagkod,
			Anyagnev = @Anyagnev, Termelesidokezd = @Termelesidokezd, Termelesidoveg = @Termelesidoveg, reaktor = @reaktor, Reaktortiszta = @Reaktortiszta, Lodigetiszta = @Lodigetiszta,
			Puffer1tiszta = @Puffer1tiszta, Puffer2tiszta = @Puffer2tiszta, Csorendszertiszta = @Csorendszertiszta, Folyadekbeatiszta = @Folyadekbeatiszta, Panelfoltiszta = @Panelfoltiszta, Soell = @Soell,
			Sofolyell = @Sofolyell, Folyfelmel = @Folyfelmel, Folyhom = @Folyhom, Leiras1 = @Leiras1, Vonalatszerel = @Vonalatszerel,
			Vonalhasznal = @Vonalhasznal, Csatlakozohelyes = @Csatlakozohelyes, Vonalkonyok = @Vonalkonyok, Leiras2 = @Leiras2, Folytiszta = @Folytiszta, Folytomit = @Folytomit,
			Folytak = @Folytak, Csomagazon = @Csomagazon, Cimkejo = @Cimkejo, Csomagtiszta = @Csomagtiszta, Zarasmegfelel = @Zarasmegfelel, Elsodoboz = @Elsodoboz,
			Utolsodoboz = @Utolsodoboz, Elteresleir = @Elteresleir, szitameret = @szitameret, elteresszuro = @elteresszuro, elteresall = @elteresall, mintavetel = @mintavetel,
			mintavetelmegjegy = @mintavetelmegjegy, cimkezesmegj = @cimkezesmegj, gyartaskozivizs = @gyartaskozivizs, szarazanyag = @szarazanyag, phmert = @phmert,
			vizsgalatmegjegy = @vizsgalatmegjegy, reaktorstart = @reaktorstart, reaktorveg = @reaktorveg, reaktoridopont = @reaktoridopont, msertekreaktor = @msertekreaktor, mosasutanreaktor = @mosasutanreaktor,
			r601start = @r601start, r601veg = @r601veg, r601idopont = @r601idopont, r601ms = @r601ms,
			r601mosutan = @r601mosutan, pufferstart = @pufferstart, pufferveg = @pufferveg, pufferidopont = @pufferidopont, pufferms = @pufferms,
			pufferutan = @pufferutan, folystart = @folystart, folyveg = @folyveg, folyidopont = @folyidopont, folyms = @folyms, folyutan = @folyutan,
			puffere = @puffere, munkakor = @munkakor, szurocomm = @szurocomm, kulsokorcomm = @kulsokorcomm, ciputancomm = @ciputancomm, reaktorcomm = @reaktorcomm,
			csomagcomm = @csomagcomm, puffercomm = @puffercomm, munkakorcomm = @munkakorcomm, szurodatum = @szurodatum, szuroop = @szuroop, kulsodatum = @kulsodatum,
			kulsoop = @kulsoop, ciputandatum = @ciputandatum, ciputanop = @ciputanop, reaktordatum = @reaktordatum, reaktorop = @reaktorop, csomagdatum = @csomagdatum,
			csomagop = @csomagop, pufferdatum = @pufferdatum, pufferop = @pufferop, munkakordatum = @munkakordatum, munkakorop = @munkakorop
			WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesidokezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesidoveg", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktor", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Reaktortiszta", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Lodigetiszta", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Puffer1tiszta", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Puffer2tiszta", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@Csorendszertiszta", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyadekbeatiszta", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@Panelfoltiszta", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@Soell", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@Sofolyell", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyfelmel", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@Folyhom", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras1", textBox18.Text));
			cmd.Parameters.Add(new SqlParameter("@Vonalatszerel", textBox19.Text));
			cmd.Parameters.Add(new SqlParameter("@Vonalhasznal", textBox20.Text));
			cmd.Parameters.Add(new SqlParameter("@Csatlakozohelyes", textBox21.Text));
			cmd.Parameters.Add(new SqlParameter("@Vonalkonyok", textBox22.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras2", textBox47.Text));
			cmd.Parameters.Add(new SqlParameter("@Folytiszta", textBox23.Text));
			cmd.Parameters.Add(new SqlParameter("@Folytomit", textBox24.Text));
			cmd.Parameters.Add(new SqlParameter("@Folytak", textBox25.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagazon", textBox26.Text));			
			cmd.Parameters.Add(new SqlParameter("@Cimkejo", textBox27.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomagtiszta", textBox28.Text));
			cmd.Parameters.Add(new SqlParameter("@Zarasmegfelel", textBox29.Text));
			cmd.Parameters.Add(new SqlParameter("@Elsodoboz", textBox30.Text));
			cmd.Parameters.Add(new SqlParameter("@Utolsodoboz", textBox31.Text));
			cmd.Parameters.Add(new SqlParameter("@Elteresleir", textBox32.Text));
			cmd.Parameters.Add(new SqlParameter("@szitameret", textBox33.Text));		
			cmd.Parameters.Add(new SqlParameter("@elteresszuro", textBox45.Text));
			cmd.Parameters.Add(new SqlParameter("@elteresall", textBox46.Text));
			cmd.Parameters.Add(new SqlParameter("@mintavetel", textBox37.Text));
			cmd.Parameters.Add(new SqlParameter("@mintavetelmegjegy", textBox43.Text));
			cmd.Parameters.Add(new SqlParameter("@cimkezesmegj", textBox44.Text));
			cmd.Parameters.Add(new SqlParameter("@gyartaskozivizs", textBox39.Text));
			cmd.Parameters.Add(new SqlParameter("@szarazanyag", textBox40.Text));
			cmd.Parameters.Add(new SqlParameter("@phmert", textBox41.Text));
			cmd.Parameters.Add(new SqlParameter("@vizsgalatmegjegy", textBox42.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktorstart", textBox48.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktorveg", textBox49.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktoridopont", textBox50.Text));
			cmd.Parameters.Add(new SqlParameter("@msertekreaktor", textBox51.Text));
			cmd.Parameters.Add(new SqlParameter("@mosasutanreaktor", textBox52.Text));
			cmd.Parameters.Add(new SqlParameter("@r601start", textBox57.Text));
			cmd.Parameters.Add(new SqlParameter("@r601veg", textBox56.Text));
			cmd.Parameters.Add(new SqlParameter("@r601idopont", textBox55.Text));	
			cmd.Parameters.Add(new SqlParameter("@r601ms", textBox54.Text));
			cmd.Parameters.Add(new SqlParameter("@r601mosutan", textBox53.Text));
			cmd.Parameters.Add(new SqlParameter("@pufferstart", textBox62.Text));
			cmd.Parameters.Add(new SqlParameter("@pufferveg", textBox61.Text));
			cmd.Parameters.Add(new SqlParameter("@pufferidopont", textBox60.Text));
			cmd.Parameters.Add(new SqlParameter("@pufferms", textBox59.Text));
			cmd.Parameters.Add(new SqlParameter("@pufferutan", textBox58.Text));
			cmd.Parameters.Add(new SqlParameter("@folystart", textBox67.Text));
			cmd.Parameters.Add(new SqlParameter("@folyveg", textBox66.Text));
			cmd.Parameters.Add(new SqlParameter("@folyidopont", textBox65.Text));
			cmd.Parameters.Add(new SqlParameter("@folyms", textBox64.Text));
			cmd.Parameters.Add(new SqlParameter("@folyutan", textBox63.Text));
			cmd.Parameters.Add(new SqlParameter("@ciputan", textBox68.Text));
			cmd.Parameters.Add(new SqlParameter("@szuroe", textBox69.Text));
			cmd.Parameters.Add(new SqlParameter("@kulsokor", textBox70.Text));
			cmd.Parameters.Add(new SqlParameter("@ciputane", textBox71.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktore", textBox72.Text));
			cmd.Parameters.Add(new SqlParameter("@csomage", textBox73.Text));
			cmd.Parameters.Add(new SqlParameter("@puffere", textBox74.Text));
			cmd.Parameters.Add(new SqlParameter("@munkakor", textBox96.Text));	
			cmd.Parameters.Add(new SqlParameter("@szurocomm", textBox75.Text));
			cmd.Parameters.Add(new SqlParameter("@kulsokorcomm", textBox76.Text));
			cmd.Parameters.Add(new SqlParameter("@ciputancomm", textBox77.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktorcomm", textBox78.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagcomm", textBox79.Text));
			cmd.Parameters.Add(new SqlParameter("@puffercomm", textBox80.Text));
			cmd.Parameters.Add(new SqlParameter("@munkakorcomm", textBox81.Text));
			cmd.Parameters.Add(new SqlParameter("@szurodatum", textBox82.Text));
			cmd.Parameters.Add(new SqlParameter("@szuroop", textBox83.Text));
			cmd.Parameters.Add(new SqlParameter("@kulsodatum", textBox94.Text));
			cmd.Parameters.Add(new SqlParameter("@kulsoop", textBox89.Text));
			cmd.Parameters.Add(new SqlParameter("@ciputandatum", textBox95.Text));	
			cmd.Parameters.Add(new SqlParameter("@ciputanop", textBox90.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktordatum", textBox85.Text));
			cmd.Parameters.Add(new SqlParameter("@reaktorop", textBox91.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagdatum", textBox86.Text));
			cmd.Parameters.Add(new SqlParameter("@csomagop", textBox84.Text));
			cmd.Parameters.Add(new SqlParameter("@pufferdatum", textBox87.Text));	
			cmd.Parameters.Add(new SqlParameter("@pufferop", textBox92.Text));
			cmd.Parameters.Add(new SqlParameter("@munkakordatum", textBox88.Text));
			cmd.Parameters.Add(new SqlParameter("@munkakorop", textBox93.Text));

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
