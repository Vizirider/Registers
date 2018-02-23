/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2017-09-11
 * Time: 02:06
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
	/// Description of Liquidnew.
	/// </summary>
	public partial class Liquidnew : Form
	{
		private readonly Liquidinster.MainForm frm1;
		public Liquidnew(string mws, string po, Liquidinster.MainForm frm)
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
			        checkBox2.Checked = (bool)read["Felcimkezve"];
			        checkBox3.Checked = (bool)read["Uledeke"];
			        textBox5.Text = (read["Kannaszam"].ToString());
			        textBox3.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
			        if(read["Idegene"] == DBNull.Value){
			        checkBox5.Checked = false;			        	
			        }
			        else{
			        checkBox5.Checked = (bool)read["Idegene"];			        	
			        }
			        if(read["Megfelelohoe"] == DBNull.Value){
			        checkBox6.Checked = false;			        	
			        }
			        else{
			        checkBox6.Checked = (bool)read["Megfelelohoe"];			        	
			        }
			        if(read["Felrazva"] == DBNull.Value){
			        checkBox7.Checked = false;			        	
			        }
			        else{
			        checkBox7.Checked = (bool)read["Felrazva"];				        
			        }
			        textBox4.Text = (read["Kimervenoncom"].ToString());
			        textBox6.Text = (read["Felcimkezvenoncom"].ToString());	
			        textBox7.Text = (read["Uledekenoncom"].ToString());
			        textBox8.Text = (read["Idegenenoncom"].ToString());
			        textBox9.Text = (read["Megfelelohoenoncom"].ToString());
			        textBox10.Text = (read["Felrazvanoncom"].ToString());			        
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquida set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, Kimerve = @Kimerve, Felcimkezve = @Felcimkezve, Uledeke = @Uledeke, Kannaszam = @Kannaszam, Komment = @Komment, Datum = @Datum, Ellenorzo = @Ellenorzo, Ellenorizve = @Ellenorizve, Ki = @Ki, Idegene = @Idegene, Megfelelohoe = @Megfelelohoe, Felrazva = @Felrazva,
			Kimervenoncom = @Kimervenoncom, Felcimkezvenoncom = @Felcimkezvenoncom, Uledekenoncom = @Uledekenoncom, Idegenenoncom = @Idegenenoncom, Megfelelohoenoncom = @Megfelelohoenoncom, Felrazvanoncom = @Felrazvanoncom
			WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Kimerve", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felcimkezve", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Uledeke", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kannaszam", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Megfelelohoe", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felrazva", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter ("@Kimervenoncom", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter ("@Felcimkezvenoncom", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter ("@Uledekenoncom", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter ("@Idegenenoncom", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter ("@Megfelelohoenoncom", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter ("@Felrazvanoncom", textBox10.Text));
			
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet"); 	
		}
		void LiquidnewLoad(object sender, EventArgs e)
		{

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
		}
	}
}
