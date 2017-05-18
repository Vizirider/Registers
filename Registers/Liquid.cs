/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-26
 * Time: 13:02
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
	/// Description of Liquid.
	/// </summary>
	public partial class Liquid : Form
	{
		private readonly Liquidinster.MainForm frm1;
		public Liquid(string mws, string po, MainForm frm)
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
		}
		void Button3Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.liquida WHERE POszam=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Anyagkod"].ToString());
			        textBox2.Text = (read["Anyagnev"].ToString());
			        checkBox1.Checked = (bool)read["Kimerve"];
			        checkBox2.Checked = (bool)read["Felrazva"];
			        checkBox3.Checked = (bool)read["Felcimkezve"];
			        textBox5.Text = (read["Kannaszam"].ToString());
			        textBox3.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
			        if(read["Uledeke"] == DBNull.Value){
			        checkBox5.Checked = false;			        	
			        }
			        else{
			        checkBox5.Checked = (bool)read["Uledeke"];			        	
			        }
			        if(read["Idegene"] == DBNull.Value){
			        checkBox6.Checked = false;			        	
			        }
			        else{
			        checkBox6.Checked = (bool)read["Idegene"];			        	
			        }
			        if(read["Megfelelohoe"] == DBNull.Value){
			        checkBox7.Checked = false;			        	
			        }
			        else{
			        checkBox7.Checked = (bool)read["Megfelelohoe"];			        	
			        }		        
			    }
			    read.Close();
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquida set Ellenorizve = 1, Ki='" + comboBox3.Text + "' WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquida set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, Kimerve = @Kimerve, Felrazva = @Felrazva, Felcimkezve = @Felcimkezve, Kannaszam = @Kannaszam, Komment = @Komment, Datum = @Datum, Ellenorzo = @Ellenorzo, Ellenorizve = @Ellenorizve, Ki = @Ki, Uledeke = @Uledeke, Idegene = @Idegene, Megfelelohoe = @Megfelelohoe 
			WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Kimerve", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felrazva", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felcimkezve", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kannaszam", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Uledeke", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Megfelelohoe", checkBox7.Checked));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet"); 
		}
		void LiquidLoad(object sender, EventArgs e)
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
			if(checkBox5.Checked == true)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox6.Checked == true)
			{
				checkBox6.BackColor = Color.Red;
			}
			if(checkBox7.Checked == false)
			{
				checkBox7.BackColor = Color.Red;
			}			
		}
	}
}
