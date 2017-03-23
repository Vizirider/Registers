/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-07
 * Time: 13:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Liquidinster
{
	/// <summary>
	/// Description of Regist.
	/// </summary>
	public partial class Regist : Form
	{
		public Regist()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		Button2Click(null, null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
			{
			MessageBox.Show("Missing information to registration!", "Message");				
			}
			else{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.LoginUser (UserName, Password, Area)  VALUES 
			(@UserName, @Password, @Area)",conn);
			cmd.Parameters.Add(new SqlParameter("@UserName", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Password", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Area", comboBox1.Text));
			
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Succesful registration, you're the " +textBox3.Text+ ". User ", "Message");  
			this.Close();	
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(UserID) FROM LoginUser", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar() +1;
        	textBox3.Text = result.ToString();
		}
		}
		void RegistKeyPress(object sender, KeyPressEventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
			{
			MessageBox.Show("Missing information to registration!", "Message");				
			}
			else{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.LoginUser (UserName, Password, Area)  VALUES 
			(@UserName, @Password, @Area)",conn);
			cmd.Parameters.Add(new SqlParameter("@UserName", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Password", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Area", comboBox1.Text));
			
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Succesful registration, you're the " +textBox3.Text+ ". User ", "Message");  
			this.Close();	
			}
		}
	}
}
