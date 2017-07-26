using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data;
namespace Clinic_Management_System
{
    static class Program
    {
        public static DataRow LogInRaw;
        public static string user;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmServerSetting());
            if (Properties.Settings.Default.Server == "")
            {
                if (new frmServerSetting().ShowDialog() == DialogResult.OK)
                {
                    if (new Log_in().ShowDialog() == DialogResult.OK)
                    {
                        // Application.Run(new Main_Form(LogInRaw));
                        Application.Run(new Main_Form(user));
                    }
                }
            }
            else
            {
                if (new Log_in().ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Main_Form(LogInRaw));
                }
            }

            //Application.Run(new Frm_add_user());
           // Application.Run(new Frm_users());
            //Application.Run(new frmLoginMoafa());
            //Application.Run(new frmLogin_Mansour());

        }
    }
}
