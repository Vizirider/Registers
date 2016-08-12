/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-26
 * Time: 15:46
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


namespace Liquidinster
{
	/// <summary>
	/// Description of blendr.
	/// </summary>
	public partial class blendr : Form
	{
		public blendr(string mws, string po)
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
			this.Button3Click(null, null);
			
			
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
			        textBox3.Text = (read["Blenderszam"].ToString());
			        checkBox2.Checked = (bool)read["Kitoltvee"];
			        textBox4.Text = (read["IBCszam"].ToString());
			        textBox5.Text = (read["LastIBC"].ToString());
			        checkBox3.Checked = (bool)read["IBCkiurulte"];
			        checkBox5.Checked = (bool)read["Felrazvae"];
			        textBox6.Text = (read["Kannaszam"].ToString());
			        checkBox6.Checked = (bool)read["Urese"];
			        checkBox7.Checked = (bool)read["Automatae"];
			        checkBox8.Checked = (bool)read["Csotisztae"];
			        checkBox9.Checked = (bool)read["Szivarogepor"];
			        textBox8.Text = (read["IBCbatch"].ToString());
			        textBox7.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
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
						this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendinga set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, Tisztae = @Tisztae, Blenderszam = @Blenderszam, Kitoltvee = @Kitoltvee, IBCszam = @IBCszam, LastIBC = @LastIBC, IBCkiurulte = @IBCkiurulte, 
			Felrazvae = @Felrazvae, Kannaszam = @Kannaszam, Urese = @Urese, Automatae = @Automatae, Csotisztae = @Csotisztae,
			Szivarogepor = @Szivarogepor, IBCbatch = @IBCbatch, Szivaroge = @Szivaroge, Komment = @Komment, Datum = @Datum, Ellenorzo = @Ellenorzo, Ellenorizve = @Ellenorizve, Ki = @Ki
			WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Tisztae", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Blenderszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Kitoltvee", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@IBCszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@LastIBC", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCkiurulte", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felrazvae", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kannaszam", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Urese", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Automatae", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Csotisztae", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szivarogepor", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@IBCbatch", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Szivaroge", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen módosítottad a PO-t", "Üzenet"); 
		}
		void BlendrLoad(object sender, EventArgs e)
		{
			if(checkBox1.Checked == false)
			{
				checkBox1.BackColor = Color.Red;
			}
			if(checkBox2.Checked == false)
			{
				checkBox2.BackColor = Color.Red;
			}
			if(checkBox3.Checked == false)
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
			if(checkBox7.Checked == false)
			{
				checkBox7.BackColor = Color.Red;
			}
			if(checkBox8.Checked == false)
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
	
		}
	}
}
