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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClinicDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.ClinicDataSet.Patient);
            // TODO: This line of code loads data into the 'ClinicDataSet.Clinic_information' table. You can move, or remove it, as needed.
            this.Clinic_informationTableAdapter.Fill(this.ClinicDataSet.Clinic_information);
            // TODO: This line of code loads data into the 'ClinicDataSet.Supplier' table. You can move, or remove it, as needed.
            this.SupplierTableAdapter.Fill(this.ClinicDataSet.Supplier);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
