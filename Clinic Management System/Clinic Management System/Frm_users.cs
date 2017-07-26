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
    public partial class Frm_users : Form
    {
        public Frm_users()
        {
            InitializeComponent();
            Connection con =new Connection();
            dataGridView1.DataSource = con.ReadData("select_users");
        }
    }
}
