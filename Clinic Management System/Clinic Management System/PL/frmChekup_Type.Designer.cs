namespace Clinic_Management_System
{
    partial class frmChekup_Type
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dgvCheckType = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckType)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الزيارة : ";
            // 
            // txtCode
            // 
            this.txtCode.ForeColor = System.Drawing.Color.Blue;
            this.txtCode.Location = new System.Drawing.Point(390, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCode.Size = new System.Drawing.Size(144, 26);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "إسم الزيارة : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 26);
            this.txtName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "الملاحظات : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "السعر : ";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(21, 51);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(253, 92);
            this.txtNote.TabIndex = 2;
            // 
            // dgvCheckType
            // 
            this.dgvCheckType.AllowUserToAddRows = false;
            this.dgvCheckType.AllowUserToDeleteRows = false;
            this.dgvCheckType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckType.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCheckType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.TypeName,
            this.Price,
            this.Note});
            this.dgvCheckType.Location = new System.Drawing.Point(11, 228);
            this.dgvCheckType.MultiSelect = false;
            this.dgvCheckType.Name = "dgvCheckType";
            this.dgvCheckType.ReadOnly = true;
            this.dgvCheckType.RowHeadersVisible = false;
            this.dgvCheckType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckType.Size = new System.Drawing.Size(637, 147);
            this.dgvCheckType.TabIndex = 1;
            this.dgvCheckType.SelectionChanged += new System.EventHandler(this.dgvCheckType_SelectionChanged);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "كود الزيارة";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "إسم الزيارة";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "الملاحظات";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Visible = false;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.nudPrice);
            this.gbData.Controls.Add(this.txtCode);
            this.gbData.Controls.Add(this.txtNote);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.txtName);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Location = new System.Drawing.Point(7, 14);
            this.gbData.Name = "gbData";
            this.gbData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbData.Size = new System.Drawing.Size(637, 152);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "بيانات الزيارة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(367, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(615, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(615, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "*";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(390, 56);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudPrice.Size = new System.Drawing.Size(144, 26);
            this.nudPrice.TabIndex = 1;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(8, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Clinic_Management_System.Properties.Resources.icons8_Delete_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(137, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 44);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Clinic_Management_System.Properties.Resources.icons8_Edit_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(229, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 44);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Clinic_Management_System.Properties.Resources.icons8_Plus_32;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(413, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 44);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Clinic_Management_System.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(321, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 44);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChekup_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCheckType);
            this.Controls.Add(this.gbData);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChekup_Type";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أنواع الزيارات";
            this.Load += new System.EventHandler(this.frmChekup_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckType)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridView dgvCheckType;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}