/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-21
 * Time: 09:17
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
	/// Description of paletta.
	/// </summary>
	public partial class paletta : Form
	{
		public paletta(string batch)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.comboBox1.Text = batch;
			Button1Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
		SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
		conn.Open();
		SqlCommand cmd = new SqlCommand("select * from packingoffpal where Batch = ('" + comboBox1.Text + "')", conn);
		cmd.Parameters.AddWithValue("@Datum",dateTimePicker1.Text);
		
		 SqlDataReader read = cmd.ExecuteReader();
		            if(read.Read())
		            {
		            textBox1.Text = (read["Operator2"].ToString());
			        textBox2.Text = (read["Megjegyz"].ToString());
			        textBox3.Text = (read["Operator1"].ToString());
		            comboBox2.Text = (read["Muszak"].ToString());
			        comboBox1.Text = (read["Batch"].ToString());
			        textBox5.Text = (read["OD"].ToString());
		            textBox6.Text = (read["HUcimkeinf"].ToString());
			        textBox7.Text = (read["HUcimkehely"].ToString());
			        textBox8.Text = (read["Egybatch"].ToString());
		            textBox9.Text = (read["Vantobbhu"].ToString());
			        textBox10.Text = (read["Talalhatofelig"].ToString());
			        textBox11.Text = (read["Cimkehely"].ToString());
		            textBox12.Text = (read["Vonalkodolv"].ToString());
			        textBox13.Text = (read["Dobozsertet"].ToString());
			        textBox14.Text = (read["Megfelelo"].ToString());			        
			        checkBox1.Checked = (bool)read["Cimkezvee"];
			        checkBox2.Checked = (bool)read["Raklapone"];
			        checkBox3.Checked = (bool)read["Tullogvae"];
			        checkBox4.Checked = (bool)read["Papirtulloge"];
			        checkBox5.Checked = (bool)read["Foliafeszese"];
		            }
				panel1.Visible |= textBox6.Text == "1";
				panel4.Visible |= textBox7.Text == "1";
				panel7.Visible |= textBox8.Text == "1";
				panel10.Visible |= textBox9.Text == "1";
				panel13.Visible |= textBox10.Text == "1";
				panel16.Visible |= textBox11.Text == "1";
				panel19.Visible |= textBox12.Text == "1";
				panel22.Visible |= textBox13.Text == "1";
				panel25.Visible |= textBox14.Text == "1";
				panel47.Visible |= textBox6.Text == "2";
				panel5.Visible |= textBox7.Text == "2";
				panel8.Visible |= textBox8.Text == "2";
				panel11.Visible |= textBox9.Text == "2";
				panel14.Visible |= textBox10.Text == "2";
				panel17.Visible |= textBox11.Text == "2";
				panel20.Visible |= textBox12.Text == "2";
				panel23.Visible |= textBox13.Text == "2";
				panel26.Visible |= textBox14.Text == "2";
				panel2.Visible |= textBox6.Text == "3";
				panel3.Visible |= textBox7.Text == "3";
				panel6.Visible |= textBox8.Text == "3";
				panel9.Visible |= textBox9.Text == "3";
				panel12.Visible |= textBox10.Text == "3";
				panel15.Visible |= textBox11.Text == "3";
				panel18.Visible |= textBox12.Text == "3";
				panel21.Visible |= textBox13.Text == "3";
				panel24.Visible |= textBox14.Text == "3";
				
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
			if(checkBox4.Checked == true)
			{
				checkBox4.BackColor = Color.Red;
			}	
		}
	}
}
