namespace Clinic_Management_System
{
    partial class frm_Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dqv_suppliers = new System.Windows.Forms.DataGridView();
            this.txt_supp_search = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit_supp = new System.Windows.Forms.Button();
            this.btn_add_supplier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dqv_suppliers)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dqv_suppliers
            // 
            this.dqv_suppliers.AllowUserToAddRows = false;
            this.dqv_suppliers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dqv_suppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dqv_suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqv_suppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dqv_suppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dqv_suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dqv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqv_suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dqv_suppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dqv_suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dqv_suppliers.EnableHeadersVisualStyles = false;
            this.dqv_suppliers.Location = new System.Drawing.Point(0, 0);
            this.dqv_suppliers.Margin = new System.Windows.Forms.Padding(5);
            this.dqv_suppliers.MultiSelect = false;
            this.dqv_suppliers.Name = "dqv_suppliers";
            this.dqv_suppliers.ReadOnly = true;
            this.dqv_suppliers.RowHeadersVisible = false;
            this.dqv_suppliers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dqv_suppliers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dqv_suppliers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.dqv_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dqv_suppliers.Size = new System.Drawing.Size(873, 355);
            this.dqv_suppliers.TabIndex = 0;
            // 
            // txt_supp_search
            // 
            this.txt_supp_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.txt_supp_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_supp_search.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_supp_search.ForeColor = System.Drawing.Color.White;
            this.txt_supp_search.Location = new System.Drawing.Point(6, 84);
            this.txt_supp_search.Name = "txt_supp_search";
            this.txt_supp_search.Size = new System.Drawing.Size(171, 17);
            this.txt_supp_search.TabIndex = 0;
            this.txt_supp_search.Tag = "0";
            this.txt_supp_search.Text = "Search";
            this.toolTip1.SetToolTip(this.txt_supp_search, "ادخل نص البحث ");
            this.txt_supp_search.Visible = false;
            this.txt_supp_search.TextChanged += new System.EventHandler(this.txt_supp_search_TextChanged);
            this.txt_supp_search.Enter += new System.EventHandler(this.txt_supp_search_Enter);
            this.txt_supp_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supp_search_KeyDown);
            this.txt_supp_search.Leave += new System.EventHandler(this.txt_supp_search_Leave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlMenu.Controls.Add(this.btn_delete);
            this.pnlMenu.Controls.Add(this.btn_edit_supp);
            this.pnlMenu.Controls.Add(this.btn_add_supplier);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.txt_supp_search);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(30, 418);
            this.pnlMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suppliers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 63);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dqv_suppliers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 355);
            this.panel2.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Consolas", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::Clinic_Management_System.Properties.Resources.icons8_Delete_16;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(0, 250);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 35);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "  Delete Supplier";
            this.toolTip1.SetToolTip(this.btn_delete, "  Delete Supplier");
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit_supp
            // 
            this.btn_edit_supp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_supp.FlatAppearance.BorderSize = 0;
            this.btn_edit_supp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btn_edit_supp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btn_edit_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_supp.Font = new System.Drawing.Font("Consolas", 12F);
            this.btn_edit_supp.ForeColor = System.Drawing.Color.White;
            this.btn_edit_supp.Image = global::Clinic_Management_System.Properties.Resources.icons8_Edit_16;
            this.btn_edit_supp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_supp.Location = new System.Drawing.Point(0, 209);
            this.btn_edit_supp.Name = "btn_edit_supp";
            this.btn_edit_supp.Size = new System.Drawing.Size(180, 35);
            this.btn_edit_supp.TabIndex = 10;
            this.btn_edit_supp.Text = "  Update Supplier";
            this.toolTip1.SetToolTip(this.btn_edit_supp, "  Update Supplier");
            this.btn_edit_supp.UseVisualStyleBackColor = true;
            this.btn_edit_supp.Click += new System.EventHandler(this.btn_edit_supp_Click);
            // 
            // btn_add_supplier
            // 
            this.btn_add_supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_supplier.FlatAppearance.BorderSize = 0;
            this.btn_add_supplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btn_add_supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.btn_add_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_supplier.Font = new System.Drawing.Font("Consolas", 12F);
            this.btn_add_supplier.ForeColor = System.Drawing.Color.White;
            this.btn_add_supplier.Image = global::Clinic_Management_System.Properties.Resources.icons8_Add_16;
            this.btn_add_supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_supplier.Location = new System.Drawing.Point(0, 168);
            this.btn_add_supplier.Name = "btn_add_supplier";
            this.btn_add_supplier.Size = new System.Drawing.Size(180, 35);
            this.btn_add_supplier.TabIndex = 9;
            this.btn_add_supplier.Text = "New Supplier";
            this.toolTip1.SetToolTip(this.btn_add_supplier, "New Supplier");
            this.btn_add_supplier.UseVisualStyleBackColor = true;
            this.btn_add_supplier.Click += new System.EventHandler(this.btn_add_supplier_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Clinic_Management_System.Properties.Resources.icons8_Select_All_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Display All";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Clinic_Management_System.Properties.Resources.icons8_Menu_26;
            this.btnMenu.Location = new System.Drawing.Point(6, 47);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(16, 16);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Tag = "0";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Clinic_Management_System.Properties.Resources.icons8_Clinic_16;
            this.pictureBox2.Location = new System.Drawing.Point(6, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 5);
            this.panel3.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "كود المورد";
            this.Column1.HeaderText = "ID #";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "إسم المورد";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "العنوان";
            this.Column3.HeaderText = "City";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "الهاتف";
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(903, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Supplier";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الموردين ";
            this.Load += new System.EventHandler(this.frm_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqv_suppliers)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqv_suppliers;
        private System.Windows.Forms.TextBox txt_supp_search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit_supp;
        private System.Windows.Forms.Button btn_add_supplier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}