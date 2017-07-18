namespace Clinic_Management_System.PL
{
    partial class StaffSearchForm
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
            this.StaffListBox = new System.Windows.Forms.GroupBox();
            this.StaffTable = new System.Windows.Forms.DataGridView();
            this.OpreationsBox = new System.Windows.Forms.GroupBox();
            this.RefreshStaffBtn = new System.Windows.Forms.Button();
            this.DeleteStaffbtn = new System.Windows.Forms.Button();
            this.EditStaffBtn = new System.Windows.Forms.Button();
            this.AddStaffBtn = new System.Windows.Forms.Button();
            this.StaffListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).BeginInit();
            this.OpreationsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffListBox
            // 
            this.StaffListBox.Controls.Add(this.StaffTable);
            this.StaffListBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StaffListBox.Location = new System.Drawing.Point(8, 8);
            this.StaffListBox.Margin = new System.Windows.Forms.Padding(2);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Padding = new System.Windows.Forms.Padding(2);
            this.StaffListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffListBox.Size = new System.Drawing.Size(1157, 308);
            this.StaffListBox.TabIndex = 0;
            this.StaffListBox.TabStop = false;
            this.StaffListBox.Text = "قائمة الموظفين";
            // 
            // StaffTable
            // 
            this.StaffTable.AllowUserToAddRows = false;
            this.StaffTable.AllowUserToDeleteRows = false;
            this.StaffTable.AllowUserToResizeRows = false;
            this.StaffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffTable.Location = new System.Drawing.Point(4, 20);
            this.StaffTable.Margin = new System.Windows.Forms.Padding(2);
            this.StaffTable.MultiSelect = false;
            this.StaffTable.Name = "StaffTable";
            this.StaffTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StaffTable.Size = new System.Drawing.Size(1143, 284);
            this.StaffTable.TabIndex = 5;
            // 
            // OpreationsBox
            // 
            this.OpreationsBox.Controls.Add(this.RefreshStaffBtn);
            this.OpreationsBox.Controls.Add(this.DeleteStaffbtn);
            this.OpreationsBox.Controls.Add(this.EditStaffBtn);
            this.OpreationsBox.Controls.Add(this.AddStaffBtn);
            this.OpreationsBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OpreationsBox.Location = new System.Drawing.Point(11, 320);
            this.OpreationsBox.Margin = new System.Windows.Forms.Padding(2);
            this.OpreationsBox.Name = "OpreationsBox";
            this.OpreationsBox.Padding = new System.Windows.Forms.Padding(2);
            this.OpreationsBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpreationsBox.Size = new System.Drawing.Size(1154, 59);
            this.OpreationsBox.TabIndex = 1;
            this.OpreationsBox.TabStop = false;
            this.OpreationsBox.Text = "العمليات";
            // 
            // RefreshStaffBtn
            // 
            this.RefreshStaffBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.RefreshStaffBtn.Location = new System.Drawing.Point(372, 21);
            this.RefreshStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshStaffBtn.Name = "RefreshStaffBtn";
            this.RefreshStaffBtn.Size = new System.Drawing.Size(55, 28);
            this.RefreshStaffBtn.TabIndex = 5;
            this.RefreshStaffBtn.Text = "تحديث";
            this.RefreshStaffBtn.UseVisualStyleBackColor = true;
            this.RefreshStaffBtn.Click += new System.EventHandler(this.RefreshStaffBtn_Click);
            // 
            // DeleteStaffbtn
            // 
            this.DeleteStaffbtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DeleteStaffbtn.Location = new System.Drawing.Point(1098, 21);
            this.DeleteStaffbtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteStaffbtn.Name = "DeleteStaffbtn";
            this.DeleteStaffbtn.Size = new System.Drawing.Size(52, 28);
            this.DeleteStaffbtn.TabIndex = 4;
            this.DeleteStaffbtn.Text = "حذف";
            this.DeleteStaffbtn.UseVisualStyleBackColor = true;
            this.DeleteStaffbtn.Click += new System.EventHandler(this.DeleteStaffbtn_Click);
            // 
            // EditStaffBtn
            // 
            this.EditStaffBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EditStaffBtn.Location = new System.Drawing.Point(563, 21);
            this.EditStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditStaffBtn.Name = "EditStaffBtn";
            this.EditStaffBtn.Size = new System.Drawing.Size(55, 28);
            this.EditStaffBtn.TabIndex = 3;
            this.EditStaffBtn.Text = "تعديل";
            this.EditStaffBtn.UseVisualStyleBackColor = true;
            this.EditStaffBtn.Click += new System.EventHandler(this.EditStaffBtn_Click);
            // 
            // AddStaffBtn
            // 
            this.AddStaffBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AddStaffBtn.Location = new System.Drawing.Point(4, 21);
            this.AddStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddStaffBtn.Name = "AddStaffBtn";
            this.AddStaffBtn.Size = new System.Drawing.Size(52, 28);
            this.AddStaffBtn.TabIndex = 2;
            this.AddStaffBtn.Text = "إضافة";
            this.AddStaffBtn.UseVisualStyleBackColor = true;
            this.AddStaffBtn.Click += new System.EventHandler(this.AddStaffBtn_Click);
            // 
            // StaffSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 390);
            this.Controls.Add(this.OpreationsBox);
            this.Controls.Add(this.StaffListBox);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.MaximizeBox = false;
            this.Name = "StaffSearchForm";
            this.Text = "StaffSearchForm";
            this.StaffListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).EndInit();
            this.OpreationsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StaffListBox;
        private System.Windows.Forms.GroupBox OpreationsBox;
        private System.Windows.Forms.Button AddStaffBtn;
        private System.Windows.Forms.Button EditStaffBtn;
        private System.Windows.Forms.Button DeleteStaffbtn;
        private System.Windows.Forms.DataGridView StaffTable;
        private System.Windows.Forms.Button RefreshStaffBtn;
    }
}