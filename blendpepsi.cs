/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2017-03-25
 * Time: 08:01
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
	/// Description of blendpepsi.
	/// </summary>
	public partial class blendpepsi : Form
	{
		private readonly Liquidinster.MainForm frm1;
		public blendpepsi(string mws, string po, Liquidinster.MainForm frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.comboBox2.Text = mws;
			this.comboBox3.Text = mws;
			this.comboBox1.Text = po;
			frm1 = frm;
			this.Button3Click(null, null);
			
			// blender register with instances 
			
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.blendinga WHERE POszam=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();
	    
			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Anyagkod"].ToString());
			        textBox2.Text = (read["Anyagnev"].ToString());
			        checkBox1.Checked = (bool)read["Tisztae"];
			        checkBox2.Checked = (bool)read["Felrazvae"];
			        checkBox3.Checked = (bool)read["Felrazvahoe"];
			        checkBox5.Checked = (bool)read["Jerrycane"];
			        checkBox6.Checked = (bool)read["Urese"];
			        checkBox7.Checked = (bool)read["Szivarogepor"];
			        checkBox8.Checked = (bool)read["Szivaroge"];
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
			        checkBox9.Checked = (bool)read["Muszakie"];
			        checkBox10.Checked = (bool)read["Idegene"];			        
			        checkBox11.Checked = (bool)read["Kitoltvee"];
			        checkBox12.Checked = (bool)read["IBCkiurulte"];
			        checkBox13.Checked = (bool)read["Prepordere"];
			        checkBox14.Checked = (bool)read["Csotisztae"];
			        checkBox15.Checked = (bool)read["Pore"];
			        checkBox16.Checked = (bool)read["Szitaellazone"];
			        checkBox17.Checked = (bool)read["Serulese"];
			        checkBox18.Checked = (bool)read["Szinhomogene"];
			        checkBox19.Checked = (bool)read["Automatae"];
			        checkBox20.Checked = (bool)read["Idegenepack"];
			        checkBox21.Checked = (bool)read["Vizfolye"];
			        checkBox22.Checked = (bool)read["Beleszsake"];		
			        checkBox23.Checked = (bool)read["Kitoltofej"];
			        checkBox24.Checked = (bool)read["Hidegviz"];
			        checkBox25.Checked = (bool)read["Vegan"];
			        checkBox26.Checked = (bool)read["Pihentetes"];
			        checkBox27.Checked = (bool)read["Rabbipecset"];
			        checkBox4.Checked = (bool)read["Rabbijelenlet"];
			        checkBox28.Checked = (bool)read["Szitaserules"];
			        
			        textBox3.Text = (read["Kannaszam"].ToString());
			        if(read["IBCbatch"].ToString() != "Kattints bele, ha nem azonos")
			        {
			        textBox4.Text = (read["IBCbatch"].ToString());
			        }
			        else{
			        	textBox4.Text = " ";
			        }
			        textBox5.Text = (read["Komment"].ToString());
			        textBox6.Text = (read["IBCszam"].ToString());	
			        textBox7.Text = (read["LastIBC"].ToString());			        
			    }
			    read.Close();
			}
		}
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendinga set Ellenorizve = 1, Ki='" + comboBox3.Text + "' WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendinga set
			POszam = @POszam,
			Anyagkod = @Anyagkod,
			Anyagnev = @Anyagnev,
			Tisztae = @Tisztae,
			Kitoltvee = @Kitoltvee,
			IBCszam = @IBCszam,
			LastIBC = @LastIBC,
			IBCkiurulte = @IBCkiurulte,
			Csotisztae = @Csotisztae,
			Prepordere = @Prepordere,
			Felrazvae = @Felrazvae,
			Kannaszam = @Kannaszam,
			Urese = @Urese,
			Automatae = @Automatae,
			Szivarogepor = @Szivarogepor,
			IBCbatch = @IBCbatch,
			Szivaroge = @Szivaroge,
			Komment = @Komment,
			Ellenorzo = @Ellenorzo,
			Felrazvahoe = @Felrazvahoe,
			Jerrycane = @Jerrycane,
			Muszakie = @Muszakie,
			Idegene = @Idegene,
			Szinhomogene = @Szinhomogene,
			Pore = @Pore,
			Idegenepack = @Idegenepack,
			Szitaellazone = @Szitaellazone,
			Vizfolye = @Vizfolye,
			Serulese = @Serulese,
			Beleszsake = @Beleszsake,
			Kitoltofej = @Kitoltofej,
			Hidegviz = @Hidegviz,
			Vegan = @Vegan,
			Pihentetes = @Pihentetes,
			Rabbipecset = @Rabbipecset,
			Rabbijelenlet = Rabbijelenlet,
			Szitaserules = @Szitaserules
			
			WHERE POszam = ('" + comboBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Tisztae", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felrazvae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felrazvahoe", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Jerrycane", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Urese", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szivarogepor", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szivaroge", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Muszakie", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kitoltvee", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@IBCkiurulte", checkBox12.Checked));
			cmd.Parameters.Add(new SqlParameter("@Prepordere", checkBox13.Checked));
			cmd.Parameters.Add(new SqlParameter("@Csotisztae", checkBox14.Checked));
			cmd.Parameters.Add(new SqlParameter("@Pore", checkBox15.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitaellazone", checkBox16.Checked));
			cmd.Parameters.Add(new SqlParameter("@Serulese", checkBox17.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szinhomogene", checkBox18.Checked));
			cmd.Parameters.Add(new SqlParameter("@Automatae", checkBox19.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegenepack", checkBox20.Checked));
			cmd.Parameters.Add(new SqlParameter("@Vizfolye", checkBox21.Checked));
			cmd.Parameters.Add(new SqlParameter("@Beleszsake", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kannaszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCbatch", textBox4.Text));	
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCszam", textBox6.Text));			
			cmd.Parameters.Add(new SqlParameter("@LastIBC", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("Ellenorzo", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Kitoltofej", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Hidegviz", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Vegan", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Pihentetes", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Rabbipecset", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Rabbijelenlet", checkBox22.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitaserules", checkBox28.Checked));
			
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen módosítottad a PO-t", "Üzenet"); 
		}
		void BlendrLoad(object sender, EventArgs e)
		{
			// if non comfort event background is red
			if(checkBox1.Checked == false)
			{
				checkBox1.BackColor = Color.Red;
			}
			if(checkBox2.Checked == false)
			{
				checkBox2.BackColor = Color.Red;
			}
			if(checkBox3.Checked == true)
			{
				checkBox3.BackColor = Color.Red;
			}
			if(checkBox5.Checked == false)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox6.Checked == false)
			{
				checkBox6.BackColor = Color.Red;
			}
			if(checkBox7.Checked == true)
			{
				checkBox7.BackColor = Color.Red;
			}
			if(checkBox8.Checked == true)
			{
				checkBox8.BackColor = Color.Red;
			}
			if(checkBox9.Checked == true)
			{
				checkBox9.BackColor = Color.Red;
			}
			if(checkBox10.Checked == true)
			{
				checkBox10.BackColor = Color.Red;
			}
			if(checkBox11.Checked == false)
			{
				checkBox11.BackColor = Color.Red;
			}			
			if(checkBox12.Checked == false)
			{
				checkBox12.BackColor = Color.Red;
			}
			if(checkBox13.Checked == false)
			{
				checkBox13.BackColor = Color.Red;
			}
			if(checkBox14.Checked == false)
			{
				checkBox14.BackColor = Color.Red;
			}
			if(checkBox15.Checked == true)
			{
				checkBox15.BackColor = Color.Red;
			}
			if(checkBox16.Checked == false && string.IsNullOrWhiteSpace(textBox4.Text))
			{
				checkBox16.BackColor = Color.Red;
			}
			if(checkBox17.Checked == true)
			{
				checkBox17.BackColor = Color.Red;
			}
			if(checkBox18.Checked == false)
			{
				checkBox18.BackColor = Color.Red;
			}
			if(checkBox19.Checked == false)
			{
				checkBox19.BackColor = Color.Red;
			}
			if(checkBox20.Checked == true)
			{
				checkBox20.BackColor = Color.Red;
			}
			if(checkBox21.Checked == true)
			{
				checkBox21.BackColor = Color.Red;
			}
			if(checkBox22.Checked == false)
			{
				checkBox22.BackColor = Color.Red;
			}	
			if(checkBox28.Checked == false)
			{
				checkBox28.BackColor = Color.Red;
			}	
			if(checkBox25.Checked == false)
			{
				checkBox25.BackColor = Color.Red;
			}
			if(checkBox26.Checked == false)
			{
				checkBox26.BackColor = Color.Red;
			}
			if(checkBox27.Checked == false)
			{
				checkBox27.BackColor = Color.Red;
			}
			if(checkBox4.Checked == false)
			{
				checkBox4.BackColor = Color.Red;
			}	
			if(checkBox23.Checked == false)
			{
				checkBox23.BackColor = Color.Red;
			}
			if(checkBox24.Checked == false)
			{
				checkBox24.BackColor = Color.Red;
			}			
		}
	}
}
