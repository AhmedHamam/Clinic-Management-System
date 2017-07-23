using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Clinic_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmServerSetting());
            if (Properties.Settings.Default.Server == "")
            {
                Application.Run(new frmServerSetting());
            }
            else
            {
                Application.Run(new Log_in());
            }

            //Application.Run(new frmLoginMoafa());
            //Application.Run(new frmLogin_Mansour());

        }
        public static void ServerSetting_Closed(object sender, EventArgs e)
        {
            Application.ExitThread();
            Thread t_PerthOut = new Thread(() => Application.Run(new Log_in()));
            t_PerthOut.Start();
        }
    }
}
