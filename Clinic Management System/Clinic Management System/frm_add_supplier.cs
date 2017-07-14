using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_add_supplier : Form
    {
        public frm_add_supplier()
        {
            InitializeComponent();
        }

        private void btn_Cancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
