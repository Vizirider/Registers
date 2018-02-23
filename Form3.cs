/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-01-21
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Liquidinster
{
	/// <summary>
	/// Description of Form3.
	/// This is login with Username, Password by Area
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			// Excection error handling server
			const string Select = "SELECT UserName, Password FROM LoginUser";
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, conn);			
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
//			comboBox1.DataSource = ds.Tables[0];
//			comboBox1.DisplayMember = "UserName";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to access! Turn to the local IT group", "Warning");	    	
	    }
		}
		}
		void Button1Click(object sender, EventArgs e)
		{
			// Login to 3 area (Production, Warehouse, Planning)
			if(string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
			{
			MessageBox.Show("Missing information to enter!", "Message");				
			}
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
				conn.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM LoginUser WHERE UserName='" + comboBox1.Text + "' and Password ='" + textBox1.Text + "'",conn);
				SqlDataReader read= command.ExecuteReader();
				if(read.Read())
				{
				if(textBox1.Text != (read["Password"].ToString())){
				MessageBox.Show("Wrong Password!", "Message");
				}
				if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Production"){
				Select sc = new Select(this.comboBox1.Text);
				Button3Click(null,null);
				sc.Show();
				}
				else if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Warehouse"){
				Select1 sc1 = new Select1(this.comboBox1.Text);
				Button3Click(null,null);
				sc1.Show();
				}
				else if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Planning"){
				Select2 sc2 = new Select2(this.comboBox1.Text);
				Button3Click(null,null);
				sc2.Show();
				}
				}
			else{
			MessageBox.Show("Wrong Username or Password!", "Warning");	
			
			}
		}
		void Button1KeyPress(object sender, KeyPressEventArgs e)
		{
			// Login to 3 area (Production, Warehouse, Planning)
			if(string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
			{
			MessageBox.Show("Missing information to enter!", "Message");				
			}
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
				conn.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM LoginUser WHERE UserName='" + comboBox1.Text + "' and Password ='" + textBox1.Text + "'",conn);
				SqlDataReader read= command.ExecuteReader();
				if(read.Read())
				{
				if(textBox1.Text != (read["Password"].ToString())){
				MessageBox.Show("Wrong Password!", "Message");
				}
				if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Production"){
				Select sc = new Select(this.comboBox1.Text);
				Button3Click(null,null);
				sc.Show();
				}
				else if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Warehouse"){
				Select1 sc1 = new Select1(this.comboBox1.Text);
				Button3Click(null,null);
				sc1.Show();
				}
				else if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Planning"){
				Select2 sc2 = new Select2(this.comboBox1.Text);
				Button3Click(null,null);
				sc2.Show();
				}
				}
			else{
			MessageBox.Show("Wrong Username or Password!", "Warning");		
			}	
		}
		void Button1KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		{
			// Login to 3 area (Production, Warehouse, Planning)
			if(string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
			{
			MessageBox.Show("Missing information to enter!", "Message");				
			}
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
				conn.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM LoginUser WHERE UserName='" + comboBox1.Text + "' and Password ='" + textBox1.Text + "'",conn);
				SqlDataReader read= command.ExecuteReader();
				if(read.Read())
				{
				if(textBox1.Text != (read["Password"].ToString())){
				MessageBox.Show("Wrong Password!", "Message");
				}
				if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Production"){
				Select sc = new Select(this.comboBox1.Text);
				Button3Click(null,null);
				sc.Show();
				}
				else if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Warehouse"){
				Select1 sc1 = new Select1(this.comboBox1.Text);
				Button3Click(null,null);
				sc1.Show();
				}
				else if(comboBox1.Text == (read["UserName"].ToString()) && textBox1.Text == (read["Password"].ToString()) && (read["Area"].ToString()) == "Planning"){
				Select2 sc2 = new Select2(this.comboBox1.Text);
				Button3Click(null,null);
				sc2.Show();
				}
				}
			else{
			MessageBox.Show("Wrong Username or Password!", "Warning");				
			}
		}
								
		}
		public string MWS{
			get { return comboBox1.Text; }
		}
		void Button2Click(object sender, EventArgs e)
		{
			Regist reg = new Regist();
			reg.Show();
		}
		// Log file
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.LoginReg ([User], [Date])  VALUES 
			(@User, @Date)",conn);
			cmd.Parameters.Add(new SqlParameter("@User", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Date", DateTime.Now));
			cmd.ExecuteNonQuery();
		}
		// About 
		void Label3Click(object sender, EventArgs e)
		{
		MessageBox.Show("1.0 version: Production: PepsiCo, Production check, Audit log with shift handover, \n Blending Timesheet, Warehouse: PepsiCo, Planning: PepsiCo, Riports", "Message");
		}
		void Label3MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label3, "1.0 version: Production: PepsiCo, Production check, Audit log with shift handover, \n Blending Timesheet, Warehouse: PepsiCo, Planning: PepsiCo, Riports");
		}

		
	}
}
