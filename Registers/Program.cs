/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2015-12-04
 * Time: 13:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;


namespace Liquidinster
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			new SplashApp().Run(args);
			
		}
        class SplashApp : WindowsFormsApplicationBase
        {
            protected override void OnCreateSplashScreen()
            {
                this.SplashScreen = new Registers.Splash();
            }
            protected override void OnCreateMainForm()
            {
                //Connect to db, remote server or anything you like in here
                System.Threading.Thread.Sleep(2000);
                //create your main form and the SplashForm will close here automatically
                this.MainForm = new Login();
            }
        }
		
	}
}
