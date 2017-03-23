/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-29
 * Time: 09:03
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

namespace Registers
{
	/// <summary>
	/// Description of blendingteruj.
	/// </summary>
	public partial class blendingteruj : Form
	{
		public blendingteruj(string mws, string po)
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
			// Blending production check register (new)
			this.comboBox1.Text = po;
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
					textBox31.Text = (read["mintavetel"].ToString());
					textBox32.Text = (read["vizsgalat"].ToString());
					textBox33.Text = (read["eredmeny"].ToString());
					textBox34.Text = (read["megjegyzes"].ToString());
					comboBox8.Text = (read["Operator4"].ToString());
					textBox49.Text = (read["liqtank"].ToString());
					textBox50.Text = (read["kiurult"].ToString());
					textBox52.Text = (read["cipviz"].ToString());
					textBox53.Text = (read["Operator7"].ToString());
					textBox54.Text = (read["Leiras5"].ToString());
					textBox1.Text = (read["lugkevkezd"].ToString());
					textBox2.Text = (read["lugkevveg"].ToString());
					textBox4.Text = (read["lugkevcheck"].ToString());
					textBox55.Text = (read["lugkevms"].ToString());
					textBox63.Text = (read["koshercujcipkezd"].ToString());
					textBox62.Text = (read["koshercujcipveg"].ToString());
					textBox61.Text = (read["kosherujcipcheck"].ToString());
					textBox60.Text = (read["kosherujcipms"].ToString());
					textBox72.Text = (read["lugkevmos"].ToString());
					textBox74.Text = (read["kosherujcipmos"].ToString());
					textBox81.Text = (read["lugkevszar"].ToString());
					textBox79.Text = (read["kosherujcipszar"].ToString());
					textBox54.Text = (read["Leiras5"].ToString());
					textBox1.Text = (read["lugkevkezd"].ToString());
					textBox2.Text = (read["lugkevveg"].ToString());
					textBox4.Text = (read["lugkevcheck"].ToString());
					textBox84.Text = (read["keverokezzel"].ToString());
					textBox86.Text = (read["munkakor"].ToString());
					textBox88.Text = (read["Komment"].ToString());	
					comboBox2.Text = (read["Ellenorzo"].ToString());
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
				panel16.Visible |= textBox17.Text == "2";
				panel3.Visible |= textBox17.Text == "3";
				panel4.Visible |= textBox17.Text == "4";
				panel5.Visible |= textBox17.Text == "5";
				panel8.Visible |= textBox17.Text == "8";
				
	if (!string.IsNullOrWhiteSpace(textBox1.Text))
	{textBox1.Text = textBox1.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox2.Text))
	{textBox2.Text = textBox2.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox4.Text))
	{textBox4.Text = textBox4.Text.Substring(11);
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

				panel10.Visible |= textBox9.Text == "1";
				panel12.Visible |= textBox10.Text == "1";
				panel14.Visible |= textBox11.Text == "1";
				panel17.Visible |= textBox12.Text == "1";
				panel25.Visible |= textBox16.Text == "1";
				panel24.Visible |= textBox15.Text == "1";
				panel22.Visible |= textBox14.Text == "1";
				panel20.Visible |= textBox13.Text == "1";
				panel89.Visible |= textBox31.Text == "1";
				panel69.Visible |= textBox49.Text == "1";
				panel68.Visible |= textBox50.Text == "1";
				panel72.Visible |= textBox52.Text == "1";
				panel78.Visible |= textBox72.Text == "1";
				panel82.Visible |= textBox74.Text == "1";
				panel94.Visible |= textBox81.Text == "1";
				panel92.Visible |= textBox79.Text == "1";
				panel97.Visible |= textBox84.Text == "1";
				panel103.Visible |= textBox86.Text == "1";


				panel75.Visible |= textBox9.Text == "2";
				panel11.Visible |= textBox10.Text == "2";
				panel13.Visible |= textBox11.Text == "2";
				panel15.Visible |= textBox12.Text == "2";
				panel23.Visible |= textBox16.Text == "2";
				panel21.Visible |= textBox15.Text == "2";
				panel19.Visible |= textBox14.Text == "2";
				panel18.Visible |= textBox13.Text == "2";
				panel105.Visible |= textBox31.Text == "2";
				panel67.Visible |= textBox49.Text == "2";
				panel66.Visible |= textBox50.Text == "2";
				panel70.Visible |= textBox52.Text == "2";
				panel76.Visible |= textBox72.Text == "2";
				panel80.Visible |= textBox74.Text == "2";
				panel91.Visible |= textBox81.Text == "2";
				textBox89.Visible |= textBox79.Text == "2";
				panel101.Visible |= textBox86.Text == "2";
		}
				Button6Click(null,null);			
	
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
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendella set Ellenorizve = 1, Ellenorzo='" + comboBox3.Text + "' WHERE POszam = ('" + comboBox1.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");	
			this.Close();	
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
			textBox31.Visible = true;
			textBox49.Visible = true;
			textBox50.Visible = true;
			textBox52.Visible = true;
			textBox72.Visible = true;
			textBox74.Visible = true;
			textBox81.Visible = true;
			textBox79.Visible = true;
			textBox84.Visible = true;
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
			textBox31.Visible = false;
			textBox49.Visible = false;
			textBox50.Visible = false;
			textBox52.Visible = false;
			textBox72.Visible = false;
			textBox74.Visible = false;
			textBox81.Visible = false;
			textBox79.Visible = false;
			textBox84.Visible = false;
			textBox86.Visible = false;
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
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendella set POszam = @POszam, Operator1 = @Operator1, SOszam = @SOszam, Termeles = @Termeles, Anyagkod = @Anyagkod, 
			Anyagnev = @Anyagnev, Telmesidokezd = @Telmesidokezd, Termelesidoveg = @Termelesidoveg, kevero = @kevero, keverotiszta = @keverotiszta, keverokopas = @keverokopas,
			folyadekbead = @folyadekbead, tomitescsat = @tomitescsat, alapanyagelo = @alapanyagelo, ibcell = @ibcell, folymel = @folymel, folyhom = @folyhom, Leiras1 = @Leiras1, mintavetel = @mintavetel,
			vizsgalat = @vizsgalat, eredmeny = @eredmeny, megjegyzes = @megjegyzes, Operator4 = @Operator4, liqtank = @liqtank, kiurult = @kiurult, cipviz = @cipviz, Operator7 = Operator7,
			lugkevkezd = @lugkevkezd, lugkevveg = @lugkevveg, lugkevcheck = @lugkevcheck, lugkevms = @lugkevms, koshercujcipkezd = @koshercujcipkezd, koshercujcipveg = @koshercujcipveg,
			kosherujcipcheck = @kosherujcipcheck, kosherujcipms = @kosherujcipms, lugkevmos = @lugkevmos, kosherujcipmos = @kosherujcipmos, kosherujcipszar = @kosherujcipszar,
			Leiras5 = @Leiras5, keverokezzel = @keverokezzel, lugos = @lugos, sav = @sav, kosherc = kosherc
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
			cmd.Parameters.Add(new SqlParameter("@mintavetel", textBox31.Text));
			cmd.Parameters.Add(new SqlParameter("@vizsgalat", textBox32.Text));
			cmd.Parameters.Add(new SqlParameter("@eredmeny", textBox33.Text));
			cmd.Parameters.Add(new SqlParameter("@megjegyzes", textBox34.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator4", comboBox8.Text));		
			cmd.Parameters.Add(new SqlParameter("@liqtank", textBox49.Text));
			cmd.Parameters.Add(new SqlParameter("@kiurult", textBox50.Text));
			cmd.Parameters.Add(new SqlParameter("@cipviz", textBox52.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator7", textBox53.Text));	
			cmd.Parameters.Add(new SqlParameter("@lugkevkezd", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevveg", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevcheck", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevms", textBox55.Text));
			cmd.Parameters.Add(new SqlParameter("@koshercujcipkezd", textBox63.Text));
			cmd.Parameters.Add(new SqlParameter("@koshercujcipveg", textBox62.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipcheck", textBox61.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipms", textBox60.Text));	
			cmd.Parameters.Add(new SqlParameter("@lugkevmos", textBox72.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipmos", textBox74.Text));
			cmd.Parameters.Add(new SqlParameter("@lugkevszar", textBox81.Text));
			cmd.Parameters.Add(new SqlParameter("@kosherujcipszar", textBox79.Text));
			cmd.Parameters.Add(new SqlParameter("@Leiras5", textBox54.Text));
			cmd.Parameters.Add(new SqlParameter("@keverokezzel", textBox84.Text));
			cmd.Parameters.Add(new SqlParameter("@munkakor", textBox86.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox88.Text));
			cmd.Parameters.Add(new SqlParameter("@lugos", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@sav", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@kosherc", checkBox3.Checked));			

			cmd.ExecuteNonQuery();
			conn.Close();

			Button5Click(null,null);		
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
	}
}
