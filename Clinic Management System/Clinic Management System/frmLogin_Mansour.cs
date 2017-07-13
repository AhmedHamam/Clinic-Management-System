using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frmLogin_Mansour : Form
    {
        public frmLogin_Mansour()
        {
            InitializeComponent();
            txtUser.GotFocus += new EventHandler(txtUser_GotFocus);
            txtUser.Leave += new EventHandler(txtUser_leave);
            txtpwd.GotFocus += new EventHandler(txtpwd_GotFocus);
            txtpwd.Leave += new EventHandler(txtpwd_leave);
        }

        // focus pour le txtutulisateur 
        public void txtUser_GotFocus(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.GotFocus -= txtUser_GotFocus;
        }
        public void txtUser_leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "اسم المستخدم";
                txtUser.GotFocus += new EventHandler(txtUser_GotFocus);
            }
        }
        // focus pour le txtMotDePasse  
        public void txtpwd_GotFocus(object sender, EventArgs e)
        {
            txtpwd.Text = "";
            txtpwd.GotFocus -= txtpwd_GotFocus;
        }
        public void txtpwd_leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpwd.Text))
            {
                txtpwd.Text = "كلمة المرور";
                txtpwd.GotFocus += new EventHandler(txtpwd_GotFocus);
            }
        }
        private void pic_invisible_Click(object sender, EventArgs e)
        {
            if (pic_invisible.Visible==true)
            {
                txtpwd.UseSystemPasswordChar = false;
                pic_invisible.Visible = false;
                pic_visible.Visible = true;
            }
        }

        private void pic_visible_Click(object sender, EventArgs e)
        {
            if (pic_visible.Visible == true)
            {
                txtpwd.UseSystemPasswordChar = true;
                pic_visible.Visible = false;
                pic_invisible.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد الخروج من البرنامج ", "تنبيه ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
