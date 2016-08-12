/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-22
 * Time: 08:20
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
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Liquidinster
{
	/// <summary>
	/// Description of Planning.
	/// </summary>
	public partial class Planning : Form
	{
		private String connectionString = null;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        private string [] List = { "OK", "NOT OK"};
		public Planning(string date, string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.dateTimePicker1.Text = date;
			this.textBox1.Text = mws;
			label1.Font = new Font(label2.Font.FontFamily, 12);
			label2.Font = new Font(label2.Font.FontFamily, 12);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
//			Button1Click(null,null);
			Button2Click(null,null);
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			

		}
		
		void Button1Click(object sender, EventArgs e)
		{

           SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
           SqlCommand command = new SqlCommand("SELECT POszam, KG, HU, PAL FROM Planner WHERE Datum = @Date",con);
           command.Parameters.AddWithValue("@Date",dateTimePicker1.Value.Date);
 
           SqlDataAdapter da = new SqlDataAdapter(command);
           DataTable dt = new DataTable();
           da.Fill(dt);
           dataGridView1.DataSource = dt;
           
           DataGridViewComboBoxColumn dcom = new DataGridViewComboBoxColumn();
           
           if(dcom.HeaderText == "KG")
           {
           	dcom.Items.Add("OK");
           	dcom.Items.Add("NOT OK");
           }
		
		}
		void Button2Click(object sender, EventArgs e)
		{
           
           	try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand command = new SqlCommand("SELECT COUNT(POszam) FROM Planner WHERE Datum = @Date",con))
    		{
       	 	con.Open();
       	 	command.Parameters.AddWithValue("@Date",dateTimePicker1.Value.Date);
        	int result = (int)command.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
		}
		void Button3Click(object sender, EventArgs e)
		{

            try
            {
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
		}
		private void PlanningLoad(object sender, EventArgs e)
		{
            connectionString = "server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI";
            sqlConnection = new SqlConnection(connectionString);
           	selectQueryString = "SELECT POszam, KG, HU, PAL FROM Planner WHERE Datum = ('" + dateTimePicker1.Text +"')";

            sqlConnection.Open();

            dataGridView1.DataSource = bindingSource;            
           	
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
		}
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.dataGridView1.CurrentCell.Value = "ok";
		}
	}
}
