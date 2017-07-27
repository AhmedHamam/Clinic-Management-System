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
    public partial class Form_manage_user : Form
    {
        public Form_manage_user()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_ADD_USER fr = new Form_ADD_USER("add");
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ADD_USER fr = new Form_ADD_USER("edite");
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
