/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-03
 * Time: 13:41
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
	/// Description of blendkis.
	/// </summary>
	public partial class blendkis : Form
	{
		public blendkis(string mws, string po)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.comboBox3.Text = mws;
			this.comboBox4.Text = mws;
			this.comboBox1.Text = po;
			Button5Click(null, null);
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendkisella WHERE POszam = ('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					comboBox1.Text = (read["POszam"].ToString());
					comboBox4.Text = (read["Operator1"].ToString());
					textBox6.Text = (read["kevero"].ToString());
					dateTimePicker2.Text = Convert.ToDateTime(read["Termeles"]).ToString();
					textBox7.Text = (read["Anyagkod"].ToString());
					textBox8.Text = (read["Anyagnev"].ToString());
					textBox5.Text = (read["Telmesidokezd"].ToString());
					textBox3.Text = (read["Termelesidoveg"].ToString());
					textBox17.Text = (read["SOszam"].ToString());
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
					textBox53.Text = (read["Operator10"].ToString());
					textBox54.Text = (read["Leiras4"].ToString());
					textBox1.Text = (read["lugosblendstart"].ToString());
					textBox2.Text = (read["lugosblendend"].ToString());
					textBox4.Text = (read["lugosblendtiszt"].ToString());
					textBox55.Text = (read["lugosblendkomm"].ToString());
					textBox59.Text = (read["lugosszitastart"].ToString());
					textBox58.Text = (read["lugosszitaend"].ToString());
					textBox57.Text = (read["lugosszitatiszt"].ToString());
					textBox56.Text = (read["lugosszitakomm"].ToString());
					textBox63.Text = (read["savaspackstart"].ToString());
					textBox62.Text = (read["savaspackend"].ToString());
					textBox61.Text = (read["savaspacktiszt"].ToString());
					textBox60.Text = (read["savaspackkomm"].ToString());
					textBox83.Text = (read["kosherblendstart"].ToString());
					textBox82.Text = (read["kosherblendend"].ToString());
					textBox81.Text = (read["kosherblendtiszt"].ToString());
					textBox80.Text = (read["kosherblendkom"].ToString());
					textBox79.Text = (read["kosherpackstart"].ToString());
					textBox78.Text = (read["kosherpackend"].ToString());
					textBox77.Text = (read["kosherpacktiszt"].ToString());
					textBox76.Text = (read["kosherpackkomm"].ToString());
					textBox75.Text = (read["kosherteljesstart"].ToString());
					textBox74.Text = (read["kosherterljesend"].ToString());
					textBox73.Text = (read["kosherteljestiszt"].ToString());
					textBox72.Text = (read["kosherteljeskom"].ToString());
					textBox67.Text = (read["areastart"].ToString());
					textBox66.Text = (read["areaend"].ToString());
					textBox65.Text = (read["areatiszt"].ToString());
					textBox64.Text = (read["areakomm"].ToString());
					textBox95.Text = (read["lugosblendmos"].ToString());
					textBox90.Text = (read["lugosblendszar"].ToString());
					textBox94.Text = (read["lugosszitamos"].ToString());
					textBox88.Text = (read["lugosszitaszar"].ToString());
					textBox93.Text = (read["savaspackmos"].ToString());
					textBox86.Text = (read["savaspackszar"].ToString());
					textBox91.Text = (read["kosherblendmos"].ToString());
					textBox84.Text = (read["kosherblendszar"].ToString());
					textBox101.Text = (read["kosherpackmos"].ToString());
					textBox98.Text = (read["kosherpackszar"].ToString());
					textBox100.Text = (read["kosherteljesmos"].ToString());
					textBox97.Text = (read["kosherteljesszar"].ToString());
					textBox99.Text = (read["areamos"].ToString());			
					textBox96.Text = (read["areaszar"].ToString());
					textBox87.Text = (read["Operator10"].ToString());

					if(read["lugose"] == DBNull.Value){
			        	checkBox1.Checked = false;
			        }
			        else{
			        checkBox1.Checked = (bool)read["lugose"];			        	
			        }	
			        if(read["savase"] == DBNull.Value){
			        	checkBox2.Checked = false;
			        }
			        else{
			        checkBox2.Checked = (bool)read["savase"];			        	
			        }
			        if(read["koshere"] == DBNull.Value){
			        	checkBox3.Checked = false;
			        }
			        else{
			        checkBox3.Checked = (bool)read["koshere"];			        	
			        }	

					
				}
	if (!string.IsNullOrWhiteSpace(textBox1.Text))
	{textBox1.Text = textBox1.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox2.Text))
	{textBox2.Text = textBox2.Text.Substring(11);
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
	if (!string.IsNullOrWhiteSpace(textBox56.Text))
	{textBox56.Text = textBox56.Text.Substring(11);
	}	
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
	if (!string.IsNullOrWhiteSpace(textBox83.Text))
	{textBox83.Text = textBox83.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox82.Text))
	{textBox82.Text = textBox82.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox81.Text))
	{textBox81.Text = textBox81.Text.Substring(11);
	}
	
	if (!string.IsNullOrWhiteSpace(textBox79.Text))
	{textBox79.Text = textBox79.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox78.Text))
	{textBox78.Text = textBox78.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox75.Text))
	{textBox75.Text = textBox75.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox74.Text))
	{textBox74.Text = textBox74.Text.Substring(11);
	}
				panel2.Visible |= textBox6.Text == "1";
				panel4.Visible |= textBox6.Text == "4";
				panel5.Visible |= textBox6.Text == "7";
				panel6.Visible |= textBox6.Text == "8";
				panel3.Visible |= textBox6.Text == "9";

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
				textBox89.Visible |= textBox31.Text == "1";
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
				panel84.Visible |= textBox76.Text == "1";
				panel94.Visible |= textBox81.Text == "1";
				panel93.Visible |= textBox80.Text == "1";
				panel92.Visible |= textBox79.Text == "1";
				panel87.Visible |= textBox77.Text == "1";
				panel100.Visible |= textBox82.Text == "1";
				panel99.Visible |= textBox83.Text == "1";
				panel97.Visible |= textBox84.Text == "1";


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
				panel83.Visible |= textBox76.Text == "2";
				panel91.Visible |= textBox81.Text == "2";
				panel88.Visible |= textBox80.Text == "2";
				panel89.Visible |= textBox79.Text == "2";
				panel85.Visible |= textBox77.Text == "2";
				panel98.Visible |= textBox82.Text == "2";
				panel96.Visible |= textBox83.Text == "2";
				panel95.Visible |= textBox84.Text == "2";
				panel101.Visible |= textBox86.Text == "2";


			}
			Button6Click(null,null);
		}

		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendkisella set folymel = @folymel, folyhom = @folyhom, keverotiszta = @keverotiszta, keverokopas = @keverokopas,
			folyadekbead = @folyadekbead
			WHERE POszam LIKE ('" + comboBox1.Text + "%')", conn);
			cmd.Parameters.Add(new SqlParameter("@folymel", 1));
			cmd.Parameters.Add(new SqlParameter("@folyhom", 1));
			cmd.Parameters.Add(new SqlParameter("@keverotiszta", 1));
			cmd.Parameters.Add(new SqlParameter("@keverokopas", 1));
			cmd.Parameters.Add(new SqlParameter("@folyadekbead  ", 1));
			
			cmd.ExecuteNonQuery();
			conn.Close();	
			
			Button5Click(null,null);		
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendkisella set Ellenorizve = 1, Ellenorzo='" + comboBox3.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");	
			this.Close();	
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Adminkomment from dbo.blendkiskom WHERE POszam=('" + comboBox1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox85.Text = (read["Adminkomment"].ToString());		
				if (!string.IsNullOrWhiteSpace(textBox85.Text))
				{textBox85.BackColor = Color.Yellow;
				}
				}
				read.Close();	
			}	
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.blendkiskom (POszam, Adminkomment) VALUES (@POszam, @Adminkomment)", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Adminkomment", textBox85.Text));

			cmd.ExecuteNonQuery();
			conn.Close();		
			
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");
			textBox85.BackColor = Color.Yellow;			
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
			}		
	
		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendkisella set  Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, POszam = @POszam, SOszam = @SOszam, Termeles = @Termeles,
			Telmesidokezd = @Telmesidokezd, Termelesidoveg = @Termelesidoveg, kevero = @kevero, keverotiszta = @keverotiszta, keverokopas = @keverokopas, folyadekbead = @folyadekbead,
			tomitescsat = @tomitescsat, alapanyagelo = @alapanyagelo, ibcell = @ibcell, folymel = @folymel, folyhom = @folyhom, Leiras1 = @Leiras1,
			Operator2 = @Operator2, tisztaszaraz = @tisztaszaraz, cimkejohely = @cimkejohely, cimkeadat = @cimkeadat, csomagtiszta = @csomagtiszta,
			zarasmegfelel = @zarasmegfelel, foliaheg = @foliaheg, csomagoloaz = @csomagoloaz, hanemtakaritunk = @hanemtakaritunk, elsodoboz = @elsodoboz, utolsodoboz = @utolsodoboz,
			Operator3 = @Operator3, Leiras2 = @Leiras2, mintavetel = @mintavetel, vizsgalat = @vizsgalat, eredmeny = @eredmeny, megjegyzes = @megjegyzes,
			Operator4 = @Operator4, szitameret = @szitameret, szitatiszta = @szitatiszta, szitahibatlan = @szitahibatlan, idegenanyag = @idegenanyag, Operator5 = @Operator5,
			Leiras3 = @Leiras3, vastarte = @vastarte, nemvase = @nemvase, rozsdamente = @rozsdamente, vastartu = @vastartu, nemvasu = @nemvasu,
			rozsdamentu = @rozsdamentu, Operator6 = @Operator6, Leiras4 = @Leiras4, liqtank = @liqtank, kiurult = @kiurult, lastphase = @lastphase,
			cipviz = @cipviz, Operator10 = @Operator10, lugosblendstart = @lugosblendstart, lugosszitaend = @lugosszitaend,
			lugosblendkomm = @lugosblendkomm, lugosszitastart = @lugosszitastart, lugosszitatiszt = @lugosszitatiszt, lugosszitakomm = @lugosszitakomm, savaspackstart = @savaspackstart,
			savaspackend = @savaspackend, savaspacktiszt = @savaspacktiszt, savaspackkomm = @savaspackkomm, kosherblendstart = @kosherblendstart, kosherblendend = @kosherblendend, kosherblendtiszt = @kosherblendtiszt,
			kosherblendkom = @kosherblendkom, kosherpackstart = @kosherpackstart, kosherpackend = @kosherpackend, kosherpacktiszt = @kosherpacktiszt, kosherpackkomm = @kosherpackkomm, kosherteljesstart = @kosherteljesstart,
			kosherterljesend = @kosherterljesend, kosherteljestiszt = @kosherteljestiszt, kosherteljeskom = @kosherteljeskom, areastart = @areastart, areaend = @areaend, areatiszt = @areatiszt,
			areakomm = @areakomm, lugosblendmos = @lugosblendmos, lugosblendszar = @lugosblendszar, lugosszitamos = @lugosszitamos, lugosszitaszar = @lugosszitaszar, savaspackmos = @savaspackmos,
			savaspackszar = @savaspackszar, kosherblendmos = @kosherblendmos, kosherblendszar = @kosherblendszar, kosherpackmos = @kosherpackmos, kosherpackszar = @kosherpackszar,
			kosherteljesmos = @kosherteljesmos, kosherteljesszar = @kosherteljesszar, areamos = @areamos, areaszar = @areaszar
			WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@kevero", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker2.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Telmesidokezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Termelesidoveg", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@SOszam", textBox17.Text));
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
			cmd.Parameters.Add(new SqlParameter("@lugosblendstart", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosblendend", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosblendtiszt", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosblendkomm", textBox55.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosszitastart", textBox59.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosszitaend", textBox58.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosszitatiszt", textBox57.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosszitakomm", textBox56.Text));
			cmd.Parameters.Add(new SqlParameter("@savaspackstart", textBox63.Text));
			cmd.Parameters.Add(new SqlParameter("@savaspackend", textBox62.Text));
			cmd.Parameters.Add(new SqlParameter("@savaspacktiszt", textBox61.Text));
			cmd.Parameters.Add(new SqlParameter("@savaspackkomm", textBox60.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherblendstart", textBox83.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherblendend", textBox82.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherblendtiszt", textBox81.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherblendkom", textBox80.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherpackstart", textBox79.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherpackend", textBox78.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherpacktiszt", textBox77.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherpackkomm", textBox76.Text));	
			cmd.Parameters.Add(new SqlParameter("@kosherteljesstart", textBox75.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherterljesend", textBox74.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherteljestiszt", textBox73.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherteljeskom", textBox72.Text));
			cmd.Parameters.Add(new SqlParameter("@areastart", textBox67.Text));
			cmd.Parameters.Add(new SqlParameter("@areaend", textBox66.Text));
			cmd.Parameters.Add(new SqlParameter("@areatiszt", textBox65.Text));
			cmd.Parameters.Add(new SqlParameter("@areakomm", textBox64.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosblendmos", textBox95.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosblendszar", textBox90.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosszitamos", textBox94.Text));
			cmd.Parameters.Add(new SqlParameter("@lugosszitaszar", textBox88.Text));
			cmd.Parameters.Add(new SqlParameter("@savaspackmos", textBox93.Text));
			cmd.Parameters.Add(new SqlParameter("@savaspackszar", textBox86.Text));	
			cmd.Parameters.Add(new SqlParameter("@kosherblendmos", textBox91.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherblendszar", textBox84.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherpackmos", textBox101.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherpackszar", textBox98.Text));	
			cmd.Parameters.Add(new SqlParameter("@kosherteljesmos", textBox100.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherteljesszar", textBox97.Text));
			cmd.Parameters.Add(new SqlParameter("@areamos", textBox99.Text));	
			cmd.Parameters.Add(new SqlParameter("@areaszar", textBox96.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator10", textBox87.Text));			

			cmd.ExecuteNonQuery();
			conn.Close();

			Button5Click(null,null);	
	
		}
	}
}
