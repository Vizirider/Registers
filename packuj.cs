/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2017-10-12
 * Time: 05:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Registers
{
	/// <summary>
	/// Description of packuj.
	/// </summary>
	public partial class packuj : Form
	{
		private readonly Liquidinster.MainForm frm1;		
		public packuj(string mws, string po, Liquidinster.MainForm frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.comboBox2.Text = mws;
			this.comboBox3.Text = mws;
			this.comboBox1.Text = po;
			frm1 = frm;
			this.Button3Click(null, null);
		}
		void Button3Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.packingoffa WHERE POszam=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Anyagkod"].ToString());
			        textBox2.Text = (read["Anyagnev"].ToString());
			        textBox4.Text = (read["IBCdok"].ToString());
			        checkBox10.Checked = (bool)read["Prepordere"];
			        checkBox2.Checked = (bool)read["Szitae"];		
			        checkBox5.Checked = (bool)read["Pore"];
			        checkBox11.Checked = (bool)read["Szitaellazone"];
			        textBox7.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
			        checkBox4.Checked = (bool)read["Serulese"];
			        textBox5.Text = (read["Mintaedenyszame"].ToString());
			        textBox6.Text = (read["Mintaedenyszamu"].ToString());
			        checkBox3.Checked = (bool)read["Beleszsake"];
			        checkBox6.Checked = (bool)read["Porszeny"];
			        checkBox8.Checked = (bool)read["Szinhomogene"];
			        checkBox9.Checked = (bool)read["Beleszsakzare"];
			        checkBox12.Checked = (bool)read["Packofffolye"];
			        checkBox13.Checked = (bool)read["Idegene"];
			        checkBox14.Checked = (bool)read["Vizfolye"];			        
			        if(read["Komment1"].ToString() != "Kattints bele, ha nem azonos")
			        {
			        textBox8.Text = (read["Komment1"].ToString());
			        }
			        else{
			        	textBox8.Text = " ";
			        }
			    	textBox3.Text = (read["Preporderenem"].ToString());
			    	textBox9.Text = (read["Szitaenem"].ToString());
			    	textBox10.Text = (read["Porenem"].ToString());
			    	textBox11.Text = (read["Szitaellazonenem"].ToString());
			    	textBox12.Text = (read["Serulesenem"].ToString());
			    	textBox13.Text = (read["Beleszsakenem"].ToString());
			    	textBox14.Text = (read["Porszenynem"].ToString());
			    	textBox15.Text = (read["Szinhomogenem"].ToString());
			    	textBox16.Text = (read["Beleszsakzarenem"].ToString());
			    	textBox17.Text = (read["Packofffolyenem"].ToString());
			    	textBox18.Text = (read["Idegenem"].ToString());
			    	textBox19.Text = (read["Vizfolyenem"].ToString());
			    }
			    read.Close();
			}	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packingoffa set Ellenorizve = 1, Ki='" + comboBox3.Text + "' WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			frm1.Refresh();
						this.Close();	
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packingoffa Set Prepordere = @Prepordere, Szitae = @Szitae, Pore = @Pore, Szitaellazone = @Szitaellazone, 
			Serulese = @Serulese, Mintaedenyszame = @Mintaedenyszame, Mintaedenyszamu = @Mintaedenyszamu, Beleszsake = @Beleszsake, Porszeny = @Porszeny, Szinhomogene = @Szinhomogene,
			Beleszsakzare = @Beleszsakzare, Packofffolye = @Packofffolye, Idegene = @Idegene, Vizfolye = @Vizfolye, Komment1 = @Komment1, Preporderenem = @Preporderenem, 
			Szitaenem = @Szitaenem, Porenem = @Porenem, Szitaellazonenem = @Szitaellazonenem, Serulesenem = @Serulesenem, Beleszsakenem = @Beleszsakenem, Porszenynem = @Porszenynem, Szinhomogenem = @Szinhomogenem,
			Beleszsakzarenem =  @Beleszsakzarenem, Packofffolyenem = @Packofffolyenem, Idegenem = @Idegenem, Vizfolyenem = @Vizfolyenem
			WHERE POszam = ('" + comboBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@Prepordere", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Pore", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitaellazone", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@Serulese", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Mintaedenyszame", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Mintaedenyszamu", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Beleszsake", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Porszeny", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szinhomogene", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Beleszsakzare", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Packofffolye", checkBox12.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox13.Checked));
			cmd.Parameters.Add(new SqlParameter("@Vizfolye", checkBox14.Checked));
			cmd.Parameters.Add(new SqlParameter("@Komment1", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Preporderenem", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitaenem", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Porenem", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@Szitaellazonenem", textBox11.Text));
			cmd.Parameters.Add(new SqlParameter("@Serulesenem", textBox12.Text));
			cmd.Parameters.Add(new SqlParameter("@Beleszsakenem", textBox13.Text));
			cmd.Parameters.Add(new SqlParameter("@Porszenynem", textBox14.Text));
			cmd.Parameters.Add(new SqlParameter("@Szinhomogenem", textBox15.Text));
			cmd.Parameters.Add(new SqlParameter("@Beleszsakzarenem", textBox16.Text));
			cmd.Parameters.Add(new SqlParameter("@Packofffolyenem", textBox17.Text));
			cmd.Parameters.Add(new SqlParameter("@Idegenem", textBox18.Text));		
			cmd.Parameters.Add(new SqlParameter("@Vizfolyenem", textBox19.Text));			
			
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen módosítottad a PO-t", "Üzenet"); 	
		}
		void PackujLoad(object sender, EventArgs e)
		{
			if(checkBox2.Checked == false)
			{
				checkBox2.BackColor = Color.Red;
			}
			if(checkBox3.Checked == false)
			{
				checkBox3.BackColor = Color.Red;
			}
			if(checkBox4.Checked == false)
			{
				checkBox4.BackColor = Color.Red;
			}
			if(checkBox5.Checked == true)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox5.Checked == true)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox10.Checked == false)
			{
				checkBox10.BackColor = Color.Red;
			}
			if(checkBox11.Checked == false)
			{
				checkBox11.BackColor = Color.Red;
			}	
			if(checkBox6.Checked == true)
			{
				checkBox6.BackColor = Color.Red;
			}
			if(checkBox8.Checked == false)
			{
				checkBox8.BackColor = Color.Red;
			}
			if(checkBox9.Checked == false)
			{
				checkBox9.BackColor = Color.Red;
			}
			if(checkBox12.Checked == false)
			{
				checkBox12.BackColor = Color.Red;
			}
			if(checkBox13.Checked == true)
			{
				checkBox13.BackColor = Color.Red;
			}
			if(checkBox14.Checked == true)
			{
				checkBox14.BackColor = Color.Red;
			}
			if(checkBox11.Checked == false && string.IsNullOrWhiteSpace(textBox8.Text))
			{
				checkBox11.BackColor = Color.Red;
			}	
		}
	}
}
