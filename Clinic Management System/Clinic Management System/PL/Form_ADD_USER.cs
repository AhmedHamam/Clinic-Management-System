using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System.PL
{
    public partial class Form_ADD_USER : Form
    { string status;
        public Form_ADD_USER(string  check)
        {
            InitializeComponent();
            //this.status = check;
            if (check=="add")
            {
                this.Text = "إضاقة مستخدم جديد";
                button1.Text = "إضافة";
                   
            }
            else
            {

                this.Text = "تعديل بيانات المستخدم";
                button1.Text = "تعديل";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
