namespace Clinic_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClinicDataSet = new Clinic_Management_System.ClinicDataSet();
            this.Clinic_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Clinic_informationTableAdapter = new Clinic_Management_System.ClinicDataSetTableAdapters.Clinic_informationTableAdapter();
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierTableAdapter = new Clinic_Management_System.ClinicDataSetTableAdapters.SupplierTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Clinic_Management_System.ClinicDataSetTableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clinic_informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClinicDataSet
            // 
            this.ClinicDataSet.DataSetName = "ClinicDataSet";
            this.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Clinic_informationBindingSource
            // 
            this.Clinic_informationBindingSource.DataMember = "Clinic_information";
            this.Clinic_informationBindingSource.DataSource = this.ClinicDataSet;
            // 
            // Clinic_informationTableAdapter
            // 
            this.Clinic_informationTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataMember = "Supplier";
            this.SupplierBindingSource.DataSource = this.ClinicDataSet;
            // 
            // SupplierTableAdapter
            // 
            this.SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Supplier";
            reportDataSource1.Value = this.SupplierBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinic_Management_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(523, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.ClinicDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clinic_informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Clinic_informationBindingSource;
        private ClinicDataSet ClinicDataSet;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private ClinicDataSetTableAdapters.Clinic_informationTableAdapter Clinic_informationTableAdapter;
        private ClinicDataSetTableAdapters.SupplierTableAdapter SupplierTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private ClinicDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
    }
}