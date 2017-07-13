namespace Clinic_Management_System
{
    partial class ucManageStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_contact_no2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_date_of_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "بحث عن موظف";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(92, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(173, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 210);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_name,
            this.staff_birth_date,
            this.staff_address,
            this.staff_contact_no,
            this.staff_contact_no2,
            this.staff_gender,
            this.staff_position,
            this.staff_status,
            this.staff_email,
            this.staff_date_of_employee,
            this.staff_picture});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "كودالموظف";
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "اسم الموظف";
            this.staff_name.Name = "staff_name";
            // 
            // staff_birth_date
            // 
            this.staff_birth_date.DataPropertyName = "staff_birth_date";
            this.staff_birth_date.HeaderText = "staff_birth_date";
            this.staff_birth_date.Name = "staff_birth_date";
            this.staff_birth_date.Visible = false;
            // 
            // staff_address
            // 
            this.staff_address.DataPropertyName = "staff_address";
            this.staff_address.HeaderText = "العنوان";
            this.staff_address.Name = "staff_address";
            // 
            // staff_contact_no
            // 
            this.staff_contact_no.DataPropertyName = "staff_contact_no";
            this.staff_contact_no.HeaderText = "staff_contact_no";
            this.staff_contact_no.Name = "staff_contact_no";
            this.staff_contact_no.Visible = false;
            // 
            // staff_contact_no2
            // 
            this.staff_contact_no2.DataPropertyName = "staff_contact_no2";
            this.staff_contact_no2.HeaderText = "staff_contact_no2";
            this.staff_contact_no2.Name = "staff_contact_no2";
            this.staff_contact_no2.Visible = false;
            // 
            // staff_gender
            // 
            this.staff_gender.DataPropertyName = "staff_gender";
            this.staff_gender.HeaderText = "الجنس";
            this.staff_gender.Name = "staff_gender";
            // 
            // staff_position
            // 
            this.staff_position.DataPropertyName = "staff_position";
            this.staff_position.HeaderText = "الوظيفة";
            this.staff_position.Name = "staff_position";
            // 
            // staff_status
            // 
            this.staff_status.DataPropertyName = "staff_status";
            this.staff_status.HeaderText = "الحالة الاجتماعية";
            this.staff_status.Name = "staff_status";
            // 
            // staff_email
            // 
            this.staff_email.DataPropertyName = "staff_email";
            this.staff_email.HeaderText = "staff_email";
            this.staff_email.Name = "staff_email";
            this.staff_email.Visible = false;
            // 
            // staff_date_of_employee
            // 
            this.staff_date_of_employee.DataPropertyName = "staff_date_of_employee";
            this.staff_date_of_employee.HeaderText = "تاريخ التعيين";
            this.staff_date_of_employee.Name = "staff_date_of_employee";
            // 
            // staff_picture
            // 
            this.staff_picture.DataPropertyName = "staff_picture";
            this.staff_picture.HeaderText = "staff_picture";
            this.staff_picture.Name = "staff_picture";
            this.staff_picture.Visible = false;
            // 
            // ucManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucManageStaff";
            this.Size = new System.Drawing.Size(711, 276);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_contact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_contact_no2;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_date_of_employee;
        private System.Windows.Forms.DataGridViewImageColumn staff_picture;
    }
}
