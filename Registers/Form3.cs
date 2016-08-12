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
	/// Ez a bejelentkezés, név+jelszó
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			const string Select = "SELECT UserName FROM LoginUser";
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
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
		void Button1Click(object sender, EventArgs e)
		{
		{
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
				conn.Open();
				SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT count(*) FROM LoginUser WHERE UserName='" + comboBox1.Text + "' and Password ='" + textBox1.Text + "'",conn);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
				DataTable dt = new DataTable();
				dataAdapter.Fill(dt);				
				if(dt.Rows[0][0].ToString() == "1" && comboBox1.Text != "planner" && comboBox1.Text != "warehouse" && comboBox1.Text != "ATI" && comboBox1.Text != "ati" && comboBox1.Text != "ige" && comboBox1.Text != "shipping" && comboBox1.Text != "izsaig" && comboBox1.Text != "tothb1" && comboBox1.Text != "csernusi" && comboBox1.Text != "mazane" && comboBox1.Text != "gen" && comboBox1.Text != "gbu" && comboBox1.Text != "lengyelg" && comboBox1.Text != "elekn" && comboBox1.Text != "kietai" && comboBox1.Text != "kubinyib"){
				Select sc = new Select(this.comboBox1.Text);
				Button3Click(null,null);
				sc.Show();
				}
				else if( comboBox1.Text == "warehouse" && textBox1.Text == "warehouse" || comboBox1.Text == "ATI" && textBox1.Text == "ati007" || comboBox1.Text == "ige" && textBox1.Text == "ige75" || comboBox1.Text == "shipping" && textBox1.Text == "shipping" || comboBox1.Text == "izsaig" && textBox1.Text == "gabyyy" || comboBox1.Text == "tothb1" && textBox1.Text == "tothb1" || comboBox1.Text == "gen" && textBox1.Text == "gen49" || comboBox1.Text == "gbu" && textBox1.Text == "gbu113" || comboBox1.Text == "lengyelg" && textBox1.Text == "gabor74" || comboBox1.Text == "elekn" && textBox1.Text == "elekn" || comboBox1.Text == "kietai" && textBox1.Text == "kietai" || comboBox1.Text == "kubinyib" && textBox1.Text == "Dorina05"){
				Select1 sc1 = new Select1(this.comboBox1.Text);

				sc1.Show();
				}
				else if( comboBox1.Text == "planner" && textBox1.Text == "planner" || comboBox1.Text == "csernusi" && textBox1.Text == "wanted" || comboBox1.Text == "mazane" && textBox1.Text == "mazane"){
				Select2 sc2 = new Select2(this.comboBox1.Text);

				sc2.Show();
				}
				else{
					MessageBox.Show("Nincs jogosultságod", "Üzenet");
				}
				
		}
		}
		void Button1KeyPress(object sender, KeyPressEventArgs e)
		{
			{
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
				conn.Open();
				SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT count(*) FROM LoginUser WHERE UserName='" + comboBox1.Text + "' and Password ='" + textBox1.Text + "'",conn);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
				DataTable dt = new DataTable();
				dataAdapter.Fill(dt);				
				if(dt.Rows[0][0].ToString() == "1" && comboBox1.Text != "planner" && comboBox1.Text != "warehouse" && comboBox1.Text != "ATI" && comboBox1.Text != "ati" && comboBox1.Text != "ige" && comboBox1.Text != "shipping" && comboBox1.Text != "izsaig" && comboBox1.Text != "tothb1" && comboBox1.Text != "csernusi" && comboBox1.Text != "mazane" && comboBox1.Text != "gen" && comboBox1.Text != "gbu" && comboBox1.Text != "lengyelg" && comboBox1.Text != "elekn" && comboBox1.Text != "kietai" && comboBox1.Text != "kubinyib"){
				Select sc = new Select(this.comboBox1.Text);
				Button3Click(null,null);
				sc.Show();
				}
				else if( comboBox1.Text == "warehouse" && textBox1.Text == "warehouse" || comboBox1.Text == "ATI" && textBox1.Text == "ati007" || comboBox1.Text == "ige" && textBox1.Text == "ige75" || comboBox1.Text == "shipping" && textBox1.Text == "shipping" || comboBox1.Text == "izsaig" && textBox1.Text == "gabyyy" || comboBox1.Text == "tothb1" && textBox1.Text == "tothb1" || comboBox1.Text == "gen" && textBox1.Text == "gen49" || comboBox1.Text == "gbu" && textBox1.Text == "gbu113" || comboBox1.Text == "lengyelg" && textBox1.Text == "gabor74" || comboBox1.Text == "elekn" && textBox1.Text == "elekn" || comboBox1.Text == "kietai" && textBox1.Text == "kietai" || comboBox1.Text == "kubinyib" && textBox1.Text == "Dorina05"){
				Select1 sc1 = new Select1(this.comboBox1.Text);

				sc1.Show();
				}
				else if( comboBox1.Text == "planner" && textBox1.Text == "planner" || comboBox1.Text == "csernusi" && textBox1.Text == "wanted" || comboBox1.Text == "mazane" && textBox1.Text == "mazane"){
				Select2 sc2 = new Select2(this.comboBox1.Text);

				sc2.Show();
				}
				else{
					MessageBox.Show("Nincs jogosultságod", "Üzenet");
				}
			}
		}
		void Button1KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter){
			
				SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
				conn.Open();
				SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT count(*) FROM LoginUser WHERE UserName='" + comboBox1.Text + "' and Password ='" + textBox1.Text + "'",conn);
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
				DataTable dt = new DataTable();
				dataAdapter.Fill(dt);				
				if(dt.Rows[0][0].ToString() == "1" && comboBox1.Text != "planner" && comboBox1.Text != "warehouse" && comboBox1.Text != "ATI" && comboBox1.Text != "ati" && comboBox1.Text != "ige" && comboBox1.Text != "shipping" && comboBox1.Text != "izsaig" && comboBox1.Text != "tothb1" && comboBox1.Text != "csernusi" && comboBox1.Text != "mazane" && comboBox1.Text != "gen" && comboBox1.Text != "gbu" && comboBox1.Text != "lengyelg" && comboBox1.Text != "elekn" && comboBox1.Text != "kietai" && comboBox1.Text != "kubinyib"){
				Select sc = new Select(this.comboBox1.Text);
				Button3Click(null,null);
				sc.Show();
				}
				else if( comboBox1.Text == "warehouse" && textBox1.Text == "warehouse" || comboBox1.Text == "ATI" && textBox1.Text == "ati007" || comboBox1.Text == "ige" && textBox1.Text == "ige75" || comboBox1.Text == "shipping" && textBox1.Text == "shipping" || comboBox1.Text == "izsaig" && textBox1.Text == "gabyyy" || comboBox1.Text == "tothb1" && textBox1.Text == "tothb1" || comboBox1.Text == "gen" && textBox1.Text == "gen49" || comboBox1.Text == "gbu" && textBox1.Text == "gbu113" || comboBox1.Text == "lengyelg" && textBox1.Text == "gabor74" || comboBox1.Text == "elekn" && textBox1.Text == "elekn" || comboBox1.Text == "kietai" && textBox1.Text == "kietai" || comboBox1.Text == "kubinyib" && textBox1.Text == "Dorina05"){
				Select1 sc1 = new Select1(this.comboBox1.Text);

				sc1.Show();
				}
				else if( comboBox1.Text == "planner" && textBox1.Text == "planner" || comboBox1.Text == "csernusi" && textBox1.Text == "wanted" || comboBox1.Text == "mazane" && textBox1.Text == "mazane"){
				Select2 sc2 = new Select2(this.comboBox1.Text);

				sc2.Show();
				}
				else{
					MessageBox.Show("Nincs jogosultságod", "Üzenet");
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
		void Label3Click(object sender, EventArgs e)
		{
		MessageBox.Show("1.0 verzió: Production: PepsiCo, Gyártásellenőrzés, Ellenőrzési napló műszakbeosztással, \n Blending Timesheet, Warehouse: PepsiCo, Planning: PepsiCo, RIPORTOK", "Üzenet");
		}
		void Label3MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label3, "1.0 verzió: Production: PepsiCo, Gyártásellenőrzés, Ellenőrzési napló műszakbeosztással, \n Blending Timesheet, Warehouse: PepsiCo, Planning: PepsiCo, RIPORTOK");
		}
		
	}
}
