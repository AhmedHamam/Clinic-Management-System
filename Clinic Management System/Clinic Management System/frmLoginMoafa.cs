<<<<<<< HEAD
﻿using System;
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
    public partial class frmLoginMoafa : Form
    {
        public frmLoginMoafa()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
=======
﻿using System;
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
    public partial class frmLoginMoafa : Form
    {
        public frmLoginMoafa()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (PasswordBox.UseSystemPasswordChar) {
                case true:
                    PasswordBox.UseSystemPasswordChar = false;
                    button1.Image = Properties.Resources.Show_32x32;
                    break;
                case false:
                    PasswordBox.UseSystemPasswordChar = true;
                    button1.Image = Properties.Resources.Hide_32x32;
                    break;
            }
        }
    }
}
>>>>>>> origin/master
