/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-11-21
 * Time: 11:29
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
	/// Description of liqip.
	/// </summary>
	public partial class liqip : Form
	{
		public liqip(string batch, string po, string mws)
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
					comboBox4.Text = (read["Name"].ToString());		
				}
				else {
				this.comboBox4.Text = mws;				
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
	    new SqlCommand("select * FROM liquidip WHERE Batch = ('" + textBox8.Text +"') OR POszam = ('" + textBox6.Text +"')", connection);
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
			        comboBox3.Text = (read["Operator1"].ToString());
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        textBox10.Text = (read["Lebegoreszecske"].ToString());
			        if(read["Ellenorizve"] == DBNull.Value){
			        	checkBox2.Checked = false;
			        }
			        else{
			        checkBox2.Checked = (bool)read["Ellenorizve"];			        	
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
				panel9.Visible |= textBox10.Text == "1";
				panel1.Visible |= textBox7.Text == "2";
				panel2.Visible |= textBox1.Text == "2";
				panel4.Visible |= textBox2.Text == "2";
				panel6.Visible |= textBox3.Text == "2";
				panel8.Visible |= textBox10.Text == "2";
			}	
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquidip set Ellenorizve = 1, Ellenorzo='" + comboBox4.Text + "' WHERE POszam = ('" + textBox6.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted az IPQC regisztert", "Üzenet");	
			this.Close();	
		}
		void Button8Click(object sender, EventArgs e)
		{
			if(button7.Visible == false){
			button7.Visible = true;	
			textBox7.Visible = true;
			textBox1.Visible = true;
			textBox2.Visible = true;
			textBox3.Visible = true;
			textBox10.Visible = true;
			}
			else if(button7.Visible == true){
			Button5Click(null,null);
			button7.Visible = false;	
			textBox7.Visible = false;
			textBox1.Visible = false;
			textBox2.Visible = false;
			textBox3.Visible = false;
			textBox10.Visible = false;
			}	
		
		}
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquidip set  POszam = @POszam, Batch = @Batch, Anyagkod = @Anyagkod, Termeles = @Termeles, Szin = @Szin,
			Arany = @Arany, Csomo = @Csomo, Homogenitas = @Homogenitas, Komment = @Komment, Operator1 = @Operator1,
			Ellenorizve = @Ellenorizve, Telmesidokezd = @Telmesidokezd, Lebegoreszecske = @Lebegoreszecske, Ellenorzo = @Ellenorzo
			WHERE POszam = ('" + textBox6.Text + "')", conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Telmesidokezd", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Szin", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Arany", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomo", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Homogenitas", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Operator1", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Termeles", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox2.Checked));		
			cmd.Parameters.Add(new SqlParameter("@Lebegoreszecske", textBox10.Text));
			cmd.ExecuteNonQuery();
			conn.Close();		
		}
	}
}
