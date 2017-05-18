/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-10-12
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Registers
{
	/// <summary>
	/// Description of CMS.
	/// </summary>
	public partial class CMS : Form
	{
		public CMS()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Button1Click(null,null);
  	this.timer1.Enabled = true;
    this.timer1.Interval = 600000;
    this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
		}
		void Timer1Tick(object sender, EventArgs e)
		{ 
			Button1Click(null,null);
			Button2Click(null,null);			
		}
		void Button1Click(object sender, EventArgs e)
		{
			OracleConnection con; 
			con = new OracleConnection();
	        con.ConnectionString = "User Id=cms_usr;Password=cmslcmsu;Data Source=huncp.emea.givaudan.com"; 
	        con.Open(); 
			OracleDataAdapter dataAdapter = new OracleDataAdapter("SELECT * FROM CMS_ADM.V_GET_PO_WORK_SUMMARY_AUTO_NEW",con);
			OracleCommandBuilder commandBuilder = new OracleCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;			
			con.Close();	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
 
            conn.Open();
            SqlCommand com = new SqlCommand(@"DELETE FROM dbo.CMS",conn);
 			com.ExecuteNonQuery();           
            for(int i=0; i< dataGridView1.Rows.Count;i++)
            {
                SqlCommand comm = new SqlCommand(@"
				INSERT INTO dbo.CMS (PO_Number, Due_Date, WKS, Material, SO_Number, Qty, PV, AKL, BMP, LIQ, WH, Blend, Pack_Off, PF, SD, Pack_Prealloc,
				PO_Priority, WH_Begin, WH_End, HU_Count, Blend_End, Pack_End, Finish_Date) VALUES
				(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16,
				@p17, @p18, @p19, @p20, @p21, @p22, @p23)
				",conn);
			    comm.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells["PO_Number"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells["Due_Date"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells["WKS"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells["Material"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells["SO_Number"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p6", dataGridView1.Rows[i].Cells["Qty"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p7", dataGridView1.Rows[i].Cells["PV"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p8", dataGridView1.Rows[i].Cells["AKL"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p9", dataGridView1.Rows[i].Cells["BMP"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p10", dataGridView1.Rows[i].Cells["LIQ"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p11", dataGridView1.Rows[i].Cells["WH"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p12", dataGridView1.Rows[i].Cells["Blend"].Value ?? (object)DBNull.Value);		    
			    comm.Parameters.AddWithValue("@p13", dataGridView1.Rows[i].Cells["Pack_Off"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p14", dataGridView1.Rows[i].Cells["PF"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p15", dataGridView1.Rows[i].Cells["SD"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p16", dataGridView1.Rows[i].Cells["Pack_Prealloc"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p17", dataGridView1.Rows[i].Cells["PO_Priority"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p18", dataGridView1.Rows[i].Cells["WH_Begin"].Value ?? (object)DBNull.Value);			    
			    comm.Parameters.AddWithValue("@p19", dataGridView1.Rows[i].Cells["WH_End"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p20", dataGridView1.Rows[i].Cells["HU_Count"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p21", dataGridView1.Rows[i].Cells["Blend_End"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p22", dataGridView1.Rows[i].Cells["Pack_End"].Value ?? (object)DBNull.Value);
			    comm.Parameters.AddWithValue("@p23", dataGridView1.Rows[i].Cells["Finish_Date"].Value ?? (object)DBNull.Value);
                comm.ExecuteNonQuery();
            }
            SqlCommand archiv = new SqlCommand(@"insert into CMSarchiv
    		select *
    		from CMS t1
    		where not exists (select * from CMSarchiv t2 where t2.SO_Number = t1.SO_Number)
			UPDATE A
			   SET [PO_Number] = B.[PO_Number]
			      ,[Due_Date] = B.[Due_Date]
			      ,[WKS] = B.[WKS]
			      ,[Material] = B.[Material]
			      ,[SO_Number] = B.[SO_Number]
			      ,[Qty] = B.[Qty]
			      ,[PV] = B.[PV]
			      ,[AKL] = B.[AKL]
			      ,[BMP] = B.[BMP]
			      ,[LIQ] = B.[LIQ]
			      ,[WH] = B.[WH]
			      ,[Blend] = B.[Blend]
			      ,[Pack_Off] = B.[Pack_Off]
			      ,[PF] = B.[PF]
			      ,[SD] = B.[SD]
			      ,[Pack_Prealloc] = B.[Pack_Prealloc]
			      ,[PO_Priority] = B.[PO_Priority]
			      ,[WH_Begin] = B.[WH_Begin]
			      ,[WH_End] = B.[WH_End]
			      ,[HU_Count] = B.[HU_Count]
			      ,[Blend_End] = B.[Blend_End]
			      ,[Pack_End] = B.[Pack_End]
			      ,[Finish_Date] = B.[Finish_Date] 
			FROM [dbo].[CMSarchiv] A
			INNER JOIN CMS B
			    ON A.SO_Number = B.SO_Number
			",conn);
 			archiv.ExecuteNonQuery();             
		}

	}
}
