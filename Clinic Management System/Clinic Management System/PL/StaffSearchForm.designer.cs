namespace Clinic_Management_System 
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
            this.components = new System.ComponentModel.Container();
            this.StaffListBox = new System.Windows.Forms.GroupBox();
            this.StaffTable = new System.Windows.Forms.DataGridView();
            this.RowMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RowMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.RowMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStaffbtn = new System.Windows.Forms.Button();
            this.AddStaffBtn = new System.Windows.Forms.Button();
            this.OpreationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EditStaffBtn = new System.Windows.Forms.Button();
            this.SearchStaffLabel = new System.Windows.Forms.Label();
            this.SearchStaffBox = new System.Windows.Forms.TextBox();
            this.SearchStaffToolsTip = new System.Windows.Forms.ToolTip(this.components);
            this.StaffListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).BeginInit();
            this.RowMenuStrip.SuspendLayout();
            this.OpreationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffListBox
            // 
            this.StaffListBox.Controls.Add(this.StaffTable);
            this.StaffListBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StaffListBox.Location = new System.Drawing.Point(9, 74);
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
            this.StaffTable.ContextMenuStrip = this.RowMenuStrip;
            this.StaffTable.Location = new System.Drawing.Point(4, 20);
            this.StaffTable.Margin = new System.Windows.Forms.Padding(2);
            this.StaffTable.MultiSelect = false;
            this.StaffTable.Name = "StaffTable";
            this.StaffTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StaffTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StaffTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffTable.Size = new System.Drawing.Size(1143, 284);
            this.StaffTable.TabIndex = 2;
            // 
            // RowMenuStrip
            // 
            this.RowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RowMenuEdit,
            this.RowMenuDelete});
            this.RowMenuStrip.Name = "RowMenuStrip";
            this.RowMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // RowMenuEdit
            // 
            this.RowMenuEdit.Name = "RowMenuEdit";
            this.RowMenuEdit.Size = new System.Drawing.Size(148, 22);
            this.RowMenuEdit.Text = "تعديل الموظف";
            this.RowMenuEdit.Click += new System.EventHandler(this.RowMenuEdit_Clicked);
            // 
            // RowMenuDelete
            // 
            this.RowMenuDelete.Name = "RowMenuDelete";
            this.RowMenuDelete.Size = new System.Drawing.Size(148, 22);
            this.RowMenuDelete.Text = "حذف الموظف";
            this.RowMenuDelete.Click += new System.EventHandler(this.RowMenuDelete_Clicked);
            // 
            // DeleteStaffbtn
            // 
            this.DeleteStaffbtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DeleteStaffbtn.Location = new System.Drawing.Point(176, 18);
            this.DeleteStaffbtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteStaffbtn.Name = "DeleteStaffbtn";
            this.DeleteStaffbtn.Size = new System.Drawing.Size(52, 28);
            this.DeleteStaffbtn.TabIndex = 4;
            this.DeleteStaffbtn.Text = "حذف";
            this.SearchStaffToolsTip.SetToolTip(this.DeleteStaffbtn, "خذف موظف من جدول الموظفين");
            this.DeleteStaffbtn.UseVisualStyleBackColor = true;
            this.DeleteStaffbtn.Click += new System.EventHandler(this.DeleteStaffbtn_Click);
            // 
            // AddStaffBtn
            // 
            this.AddStaffBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AddStaffBtn.Location = new System.Drawing.Point(580, 18);
            this.AddStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddStaffBtn.Name = "AddStaffBtn";
            this.AddStaffBtn.Size = new System.Drawing.Size(52, 28);
            this.AddStaffBtn.TabIndex = 3;
            this.AddStaffBtn.Text = "إضافة";
            this.SearchStaffToolsTip.SetToolTip(this.AddStaffBtn, "إضافة موظف لجدول الموظفين");
            this.AddStaffBtn.UseVisualStyleBackColor = true;
            this.AddStaffBtn.Click += new System.EventHandler(this.AddStaffBtn_Click);
            // 
            // OpreationsGroupBox
            // 
            this.OpreationsGroupBox.Controls.Add(this.EditStaffBtn);
            this.OpreationsGroupBox.Controls.Add(this.DeleteStaffbtn);
            this.OpreationsGroupBox.Controls.Add(this.AddStaffBtn);
            this.OpreationsGroupBox.Controls.Add(this.SearchStaffLabel);
            this.OpreationsGroupBox.Controls.Add(this.SearchStaffBox);
            this.OpreationsGroupBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OpreationsGroupBox.Location = new System.Drawing.Point(13, 11);
            this.OpreationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.OpreationsGroupBox.Name = "OpreationsGroupBox";
            this.OpreationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.OpreationsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpreationsGroupBox.Size = new System.Drawing.Size(1154, 59);
            this.OpreationsGroupBox.TabIndex = 7;
            this.OpreationsGroupBox.TabStop = false;
            this.OpreationsGroupBox.Text = "العمليات";
            // 
            // EditStaffBtn
            // 
            this.EditStaffBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EditStaffBtn.Location = new System.Drawing.Point(378, 18);
            this.EditStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditStaffBtn.Name = "EditStaffBtn";
            this.EditStaffBtn.Size = new System.Drawing.Size(52, 28);
            this.EditStaffBtn.TabIndex = 7;
            this.EditStaffBtn.Text = "تعديل";
            this.SearchStaffToolsTip.SetToolTip(this.EditStaffBtn, "تعديل موظف في جدول الموظفين");
            this.EditStaffBtn.UseVisualStyleBackColor = true;
            this.EditStaffBtn.Click += new System.EventHandler(this.EditStaffBtn_Click);
            // 
            // SearchStaffLabel
            // 
            this.SearchStaffLabel.AutoSize = true;
            this.SearchStaffLabel.Location = new System.Drawing.Point(1064, 29);
            this.SearchStaffLabel.Name = "SearchStaffLabel";
            this.SearchStaffLabel.Size = new System.Drawing.Size(85, 17);
            this.SearchStaffLabel.TabIndex = 6;
            this.SearchStaffLabel.Text = "كلمة البحث :";
            // 
            // SearchStaffBox
            // 
            this.SearchStaffBox.Location = new System.Drawing.Point(808, 22);
            this.SearchStaffBox.Name = "SearchStaffBox";
            this.SearchStaffBox.Size = new System.Drawing.Size(250, 24);
            this.SearchStaffBox.TabIndex = 0;
            this.SearchStaffToolsTip.SetToolTip(this.SearchStaffBox, "البحث عن موظف في جدول الموظفين");
            this.SearchStaffBox.TextChanged += new System.EventHandler(this.SearchStaffBox_TextChanged);
            // 
            // SearchStaffToolsTip
            // 
            this.SearchStaffToolsTip.AutomaticDelay = 250;
            this.SearchStaffToolsTip.AutoPopDelay = 5000;
            this.SearchStaffToolsTip.InitialDelay = 250;
            this.SearchStaffToolsTip.IsBalloon = true;
            this.SearchStaffToolsTip.ReshowDelay = 50;
            // 
            // StaffSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 387);
            this.Controls.Add(this.OpreationsGroupBox);
            this.Controls.Add(this.StaffListBox);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.MaximizeBox = false;
            this.Name = "StaffSearchForm";
            this.Text = "نموذج الموظفين";
            this.StaffListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).EndInit();
            this.RowMenuStrip.ResumeLayout(false);
            this.OpreationsGroupBox.ResumeLayout(false);
            this.OpreationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StaffListBox;
        private System.Windows.Forms.Button AddStaffBtn;
        private System.Windows.Forms.Button DeleteStaffbtn;
        private System.Windows.Forms.GroupBox OpreationsGroupBox;
        private System.Windows.Forms.Button EditStaffBtn;
        private System.Windows.Forms.Label SearchStaffLabel;
        private System.Windows.Forms.TextBox SearchStaffBox;
        public System.Windows.Forms.DataGridView StaffTable;
        private System.Windows.Forms.ContextMenuStrip RowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RowMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem RowMenuDelete;
        private System.Windows.Forms.ToolTip SearchStaffToolsTip;
    }
}