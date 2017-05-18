/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-27
 * Time: 09:05
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

namespace Liquidinster
{
	/// <summary>
	/// Description of lodige.
	/// </summary>
	public partial class lodige : Form
	{
	private readonly Liquidinster.MainForm1 frm1;
		public lodige(string mws, string po, MainForm1 frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
//			this.textBox5.Text = mws;
			this.textBox2.Text = po;
			frm1 = frm;
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Name FROM dbo.Admins WHERE ID=('" + mws + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox5.Text = (read["Name"].ToString());		
				}
				else {
				this.textBox5.Text = mws;				
				}
				read.Close();
			}
			Button1Click(null, null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from lodigea WHERE POszam = ('" + textBox2.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox2.Text = (read["POszam"].ToString());
					textBox4.Text = (read["Operator1"].ToString());
					textBox3.Text = (read["Anyagnev"].ToString());
					textBox1.Text = (read["Anyagkod"].ToString());
					dateTimePicker1.Text = Convert.ToDateTime(read["Termeles"]).ToString();
					textBox6.Text = (read["SOszam1"].ToString());
					textBox7.Text = (read["SOszam2"].ToString());
					textBox8.Text = (read["SOszam3"].ToString());					
					textBox9.Text = (read["SOszam4"].ToString());
					textBox10.Text = (read["SOszam5"].ToString());
					textBox11.Text = (read["SOszam6"].ToString());
					textBox12.Text = (read["SOszam7"].ToString());
					textBox13.Text = (read["SOszam8"].ToString());
					textBox14.Text = (read["Termelesidokezd"].ToString());
					textBox19.Text = (read["Termelesidokezd1"].ToString());
					textBox22.Text = (read["Termelesidokezd2"].ToString());					
					textBox25.Text = (read["Termelesidokezd3"].ToString());
					textBox28.Text = (read["Termelesidokezd4"].ToString());
					textBox31.Text = (read["Termelesidokezd5"].ToString());
					textBox34.Text = (read["Termelesidokezd6"].ToString());
					textBox37.Text = (read["Termelesidokezd7"].ToString());
					textBox15.Text = (read["Termelesidoveg"].ToString());
					textBox18.Text = (read["Termelesidoveg1"].ToString());
					textBox21.Text = (read["Termelesidoveg2"].ToString());					
					textBox24.Text = (read["Termelesidoveg3"].ToString());
					textBox27.Text = (read["Termelesidoveg4"].ToString());
					textBox30.Text = (read["Termelesidoveg5"].ToString());
					textBox33.Text = (read["Termelesidoveg6"].ToString());
					textBox36.Text = (read["Termelesidoveg7"].ToString());		

					textBox41.Text = (read["Lodigecipkezd"].ToString());
					textBox40.Text = (read["Lodigecipveg"].ToString());
					textBox39.Text = (read["Lodigeido"].ToString());
					textBox38.Text = (read["Lodigems"].ToString());
					textBox45.Text = (read["Lodigecipkezd1"].ToString());
					textBox44.Text = (read["Lodigecipveg1"].ToString());
					textBox43.Text = (read["Lodigeido1"].ToString());					
					textBox42.Text = (read["Lodigems1"].ToString());
					textBox49.Text = (read["Lodigecipkezd2"].ToString());
					textBox48.Text = (read["Lodigecipveg2"].ToString());
					textBox47.Text = (read["Lodigeido2"].ToString());
					textBox46.Text = (read["Lodigems2"].ToString());			
					textBox50.Text = (read["Szuromeret"].ToString());	
			        if(read["Lugos"] == DBNull.Value){
			        	checkBox1.Checked = false;
			        }
			        else{
			        checkBox1.Checked = (bool)read["Lugos"];			        	
			        }	
			        if(read["Savas"] == DBNull.Value){
			        	checkBox2.Checked = false;
			        }
			        else{
			        checkBox2.Checked = (bool)read["Savas"];			        	
			        }

					textBox54.Text = (read["Reaktortiszta"].ToString());
					textBox53.Text = (read["BT650tanktiszta"].ToString());
					textBox52.Text = (read["Csorendszerszag"].ToString());
					textBox51.Text = (read["Termekszurok"].ToString());				
					textBox58.Text = (read["Soell"].ToString());
					textBox57.Text = (read["Soell1"].ToString());
					textBox56.Text = (read["Soell2"].ToString());
					textBox55.Text = (read["Soell3"].ToString());
					textBox62.Text = (read["Soell4"].ToString());
					textBox61.Text = (read["Soell5"].ToString());
					textBox60.Text = (read["Soell6"].ToString());
					textBox59.Text = (read["Soell6"].ToString());
					textBox66.Text = (read["Sofolyell"].ToString());
					textBox65.Text = (read["Sofolyell1"].ToString());
					textBox64.Text = (read["Sofolyell2"].ToString());
					textBox63.Text = (read["Sofolyell3"].ToString());
					textBox70.Text = (read["Sofolyell4"].ToString());
					textBox69.Text = (read["Sofolyell5"].ToString());
					textBox68.Text = (read["Sofolyell6"].ToString());
					textBox67.Text = (read["Sofolyell7"].ToString());
					textBox74.Text = (read["Folyfelmel"].ToString());
					textBox73.Text = (read["Folyfelmel1"].ToString());
					textBox72.Text = (read["Folyfelmel2"].ToString());
					textBox71.Text = (read["Folyfelmel3"].ToString());
					textBox78.Text = (read["Folyfelmel4"].ToString());
					textBox77.Text = (read["Folyfelmel5"].ToString());
					textBox76.Text = (read["Folyfelmel6"].ToString());
					textBox75.Text = (read["Folyfelmel7"].ToString());		
					textBox82.Text = (read["Lodigetiszta"].ToString());
					textBox81.Text = (read["Lodigekitap"].ToString());
					textBox80.Text = (read["Lodigekeziszelep"].ToString());
					textBox79.Text = (read["Termekszuro"].ToString());				
					textBox86.Text = (read["M450feed"].ToString());
					textBox85.Text = (read["Panelfal"].ToString());
					textBox84.Text = (read["Vonalakkonyok"].ToString());
					textBox83.Text = (read["Lodigetermekszuro"].ToString());
					textBox87.Text = (read["Szurotiszta"].ToString());
					textBox88.Text = (read["Szuroallapot"].ToString());
					textBox89.Text = (read["Idegenanyag"].ToString());
					textBox93.Text = (read["Mosatasutanszag"].ToString());
					textBox94.Text = (read["Mosatasutanszag1"].ToString());
					textBox95.Text = (read["Mosatasutanszag2"].ToString());
					textBox96.Text = (read["Szurok"].ToString());
					textBox97.Text = (read["Lodigekezzel"].ToString());
					textBox98.Text = (read["BT650puffer"].ToString());
					textBox99.Text = (read["Munkakornyezet"].ToString());
					textBox91.Text = (read["Szuromeret"].ToString());
					textBox50.Text = (read["Mertszaraz"].ToString());
					textBox92.Text = (read["Mertph"].ToString());
					textBox100.Text = (read["Ellenorzo"].ToString());
					
				}
				read.Close();
			}
	if (!string.IsNullOrWhiteSpace(textBox14.Text))
	{textBox14.Text = textBox14.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox19.Text))
	{textBox19.Text = textBox19.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox22.Text))
	{textBox22.Text = textBox22.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox25.Text))
	{textBox25.Text = textBox25.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox28.Text))
	{textBox28.Text = textBox28.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox31.Text))
	{textBox31.Text = textBox31.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox34.Text))
	{textBox34.Text = textBox34.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox37.Text))
	{textBox37.Text = textBox37.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox15.Text))
	{textBox15.Text = textBox15.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox18.Text))
	{textBox18.Text = textBox18.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox21.Text))
	{textBox21.Text = textBox21.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox24.Text))
	{textBox24.Text = textBox24.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox27.Text))
	{textBox27.Text = textBox27.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox30.Text))
	{textBox30.Text = textBox30.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox33.Text))
	{textBox33.Text = textBox33.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox36.Text))
	{textBox36.Text = textBox36.Text.Substring(11);
	}

	if (!string.IsNullOrWhiteSpace(textBox41.Text))
	{textBox41.Text = textBox41.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox40.Text))
	{textBox40.Text = textBox40.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox39.Text))
	{textBox39.Text = textBox39.Text.Substring(11);
	}	
	if (!string.IsNullOrWhiteSpace(textBox45.Text))
	{textBox45.Text = textBox45.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox44.Text))
	{textBox44.Text = textBox44.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox43.Text))
	{textBox43.Text = textBox43.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox49.Text))
	{textBox49.Text = textBox49.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox48.Text))
	{textBox48.Text = textBox48.Text.Substring(11);
	}
	if (!string.IsNullOrWhiteSpace(textBox47.Text))
	{textBox47.Text = textBox47.Text.Substring(11);
	}

				panel10.Visible |= textBox54.Text == "1";
				panel12.Visible |= textBox53.Text == "1";
				panel14.Visible |= textBox52.Text == "1";
				panel17.Visible |= textBox51.Text == "1";
				panel9.Visible |= textBox58.Text == "1";
				panel8.Visible |= textBox57.Text == "1";
				panel6.Visible |= textBox56.Text == "1";
				panel4.Visible |= textBox55.Text == "1";
				panel24.Visible |= textBox62.Text == "1";
				panel23.Visible |= textBox61.Text == "1";
				panel21.Visible |= textBox60.Text == "1";
				panel19.Visible |= textBox59.Text == "1";
				panel32.Visible |= textBox66.Text == "1";
				panel31.Visible |= textBox65.Text == "1";
				panel29.Visible |= textBox64.Text == "1";
				panel27.Visible |= textBox63.Text == "1";
				panel40.Visible |= textBox70.Text == "1";
				panel39.Visible |= textBox69.Text == "1";
				panel37.Visible |= textBox68.Text == "1";
				panel35.Visible |= textBox67.Text == "1";
				panel48.Visible |= textBox74.Text == "1";
				panel47.Visible |= textBox73.Text == "1";
				panel45.Visible |= textBox72.Text == "1";
				panel43.Visible |= textBox71.Text == "1";
				panel56.Visible |= textBox78.Text == "1";
				panel55.Visible |= textBox77.Text == "1";
				panel53.Visible |= textBox76.Text == "1";
				panel51.Visible |= textBox75.Text == "1";
				panel58.Visible |= textBox82.Text == "1";
				panel60.Visible |= textBox81.Text == "1";
				panel62.Visible |= textBox80.Text == "1";
				panel64.Visible |= textBox79.Text == "1";
				panel72.Visible |= textBox86.Text == "1";
				panel71.Visible |= textBox85.Text == "1";
				panel69.Visible |= textBox84.Text == "1";
				panel67.Visible |= textBox83.Text == "1";
				panel74.Visible |= textBox87.Text == "1";
				panel77.Visible |= textBox88.Text == "1";
				panel75.Visible |= textBox89.Text == "1";
				panel81.Visible |= textBox93.Text == "1";
				panel83.Visible |= textBox94.Text == "1";
				panel85.Visible |= textBox95.Text == "1";
				panel87.Visible |= textBox96.Text == "1";
				panel89.Visible |= textBox97.Text == "1";
				panel91.Visible |= textBox98.Text == "1";
				panel93.Visible |= textBox99.Text == "1";

				panel75.Visible |= textBox54.Text == "2";
				panel11.Visible |= textBox53.Text == "2";
				panel13.Visible |= textBox52.Text == "2";
				panel15.Visible |= textBox51.Text == "2";
				panel7.Visible |= textBox58.Text == "2";
				panel5.Visible |= textBox57.Text == "2";
				panel3.Visible |= textBox56.Text == "2";
				panel2.Visible |= textBox55.Text == "2";
				panel22.Visible |= textBox62.Text == "2";
				panel20.Visible |= textBox61.Text == "2";
				panel18.Visible |= textBox60.Text == "2";
				panel16.Visible |= textBox59.Text == "2";
				panel30.Visible |= textBox66.Text == "2";
				panel28.Visible |= textBox65.Text == "2";
				panel26.Visible |= textBox64.Text == "2";
				panel25.Visible |= textBox63.Text == "2";
				panel38.Visible |= textBox70.Text == "2";
				panel36.Visible |= textBox69.Text == "2";
				panel34.Visible |= textBox68.Text == "2";
				panel33.Visible |= textBox67.Text == "2";
				panel46.Visible |= textBox74.Text == "2";
				panel44.Visible |= textBox73.Text == "2";
				panel42.Visible |= textBox72.Text == "2";
				panel41.Visible |= textBox71.Text == "2";
				panel54.Visible |= textBox78.Text == "2";
				panel52.Visible |= textBox77.Text == "2";
				panel50.Visible |= textBox76.Text == "2";
				panel49.Visible |= textBox75.Text == "2";
				panel57.Visible |= textBox82.Text == "2";
				panel59.Visible |= textBox81.Text == "2";
				panel61.Visible |= textBox80.Text == "2";
				panel63.Visible |= textBox79.Text == "2";
				panel70.Visible |= textBox86.Text == "2";
				panel68.Visible |= textBox85.Text == "2";
				panel66.Visible |= textBox84.Text == "2";
				panel68.Visible |= textBox83.Text == "2";
				panel73.Visible |= textBox87.Text == "2";
				panel76.Visible |= textBox88.Text == "2";
				panel78.Visible |= textBox89.Text == "2";
				panel80.Visible |= textBox93.Text == "2";
				panel82.Visible |= textBox94.Text == "2";
				panel84.Visible |= textBox95.Text == "2";
				panel86.Visible |= textBox96.Text == "2";
				panel88.Visible |= textBox97.Text == "2";
				panel90.Visible |= textBox98.Text == "2";
				panel92.Visible |= textBox99.Text == "2";
	
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.lodigea set Ellenorizve = 1, Ellenorzo='" + textBox5.Text + "' WHERE POszam = ('" + textBox2.Text + "')", conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");	
			frm1.Refresh();
			this.Close();	
		}
	}
}
