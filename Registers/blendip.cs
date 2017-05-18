/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-11-21
 * Time: 12:04
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
	/// Description of blendip.
	/// </summary>
	public partial class blendip : Form
	{
		public blendip(string batch, string po, string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.textBox8.Text = batch;			
			this.textBox6.Text = po;			
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Name FROM dbo.Admins WHERE ID=('" + mws + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					comboBox2.Text = (read["Name"].ToString());		
				}
				else {
				this.comboBox2.Text = mws;				
				}
				read.Close();
			}
			
			Button5Click(null,null);
		}
		void Button5Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * FROM blendingip WHERE POszam = ('" + textBox6.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox6.Text = (read["POszam"].ToString());
			        textBox8.Text = (read["Batch"].ToString());
			        textBox4.Text = (read["Anyagkod"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termeles"]).ToString();
			        textBox5.Text = (read["Telmesidokezd"].ToString());
			        textBox7.Text = (read["Szin"].ToString());
			        textBox1.Text = (read["Arany"].ToString());
			        textBox2.Text = (read["Csomo"].ToString());
			        textBox3.Text = (read["Homogenitas"].ToString());
			        textBox9.Text = (read["Komment"].ToString());
			        comboBox1.Text = (read["Operator1"].ToString());
			        comboBox6.Text = (read["Ellenorzo"].ToString());
			        if(read["Ellenorizve"] == DBNull.Value){
			        	checkBox1.Checked = false;
			        }
			        else{
			        checkBox1.Checked = (bool)read["Ellenorizve"];			        	
			        }
			    }
			    read.Close();
			if (!string.IsNullOrWhiteSpace(textBox5.Text))
			{textBox5.Text = textBox5.Text.Substring(11);
			}
				panel14.Visible |= textBox7.Text == "1";
				panel3.Visible |= textBox1.Text == "1";
				panel5.Visible |= textBox2.Text == "1";
				panel7.Visible |= textBox3.Text == "1";
				panel1.Visible |= textBox7.Text == "2";
				panel2.Visible |= textBox1.Text == "2";
				panel4.Visible |= textBox2.Text == "2";
				panel6.Visible |= textBox3.Text == "2";


			}	
		}
		void Button8Click(object sender, EventArgs e)
		{
			if(button7.Visible == false){
			button7.Visible = true;	
			textBox7.Visible = true;
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;			
			}
			else if(button7.Visible == true){
			Button5Click(null,null);
			button7.Visible = false;	
			textBox7.Visible = false;
			textBox1.Visible = false;
			textBox2.Visible = false;
			textBox3.Visible = false;
			}	
	
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendingip set Ellenorizve = 1, Ellenorzo='" + comboBox2.Text + "' WHERE POszam = ('" + textBox6.Text + "') OR Batch = ('" + textBox8.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted az IPQC regisztert", "Üzenet");	
			this.Close();	
		}
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendingip set  POszam = @POszam, Batch = @Batch, Anyagkod = @Anyagkod, Termeles = @Termeles, Szin = @Szin,
			Arany = @Arany, Csomo = @Csomo, Homogenitas = @Homogenitas, Komment = @Komment, Operator1 = @Operator1, Ellenorzo = @Ellenorzo,
			Ellenorizve = @Ellenorizve
			WHERE POszam = ('" + textBox6.Text + "') OR Batch = ('" + textBox8.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Telmesidokezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Szin", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Arany", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomo", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Homogenitas", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox1.Checked));		

			cmd.ExecuteNonQuery();
			conn.Close();	
		}
	}
}
