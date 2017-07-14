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
            this.dqv_suppliers = new System.Windows.Forms.DataGridView();
            this.Pan_Search = new System.Windows.Forms.Panel();
            this.btn_add_supplier = new System.Windows.Forms.Button();
            this.btn_edit_supp = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_Supplier = new System.Windows.Forms.Label();
            this.txt_supp_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dqv_suppliers)).BeginInit();
            this.Pan_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqv_suppliers
            // 
            this.dqv_suppliers.AllowUserToAddRows = false;
            this.dqv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqv_suppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dqv_suppliers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dqv_suppliers.Location = new System.Drawing.Point(0, 152);
            this.dqv_suppliers.Margin = new System.Windows.Forms.Padding(5);
            this.dqv_suppliers.MultiSelect = false;
            this.dqv_suppliers.Name = "dqv_suppliers";
            this.dqv_suppliers.ReadOnly = true;
            this.dqv_suppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dqv_suppliers.Size = new System.Drawing.Size(903, 266);
            this.dqv_suppliers.TabIndex = 0;
            // 
            // Pan_Search
            // 
            this.Pan_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pan_Search.Controls.Add(this.btn_add_supplier);
            this.Pan_Search.Controls.Add(this.btn_edit_supp);
            this.Pan_Search.Controls.Add(this.btn_delete);
            this.Pan_Search.Controls.Add(this.lb_Supplier);
            this.Pan_Search.Controls.Add(this.txt_supp_search);
            this.Pan_Search.Controls.Add(this.btn_search);
            this.Pan_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_Search.Location = new System.Drawing.Point(0, 0);
            this.Pan_Search.Name = "Pan_Search";
            this.Pan_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pan_Search.Size = new System.Drawing.Size(903, 144);
            this.Pan_Search.TabIndex = 2;
            // 
            // btn_add_supplier
            // 
            this.btn_add_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_supplier.Image = global::Clinic_Management_System.Properties.Resources.if_Add_character_include_more_person_user_1886171;
            this.btn_add_supplier.Location = new System.Drawing.Point(817, 5);
            this.btn_add_supplier.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_supplier.Name = "btn_add_supplier";
            this.btn_add_supplier.Size = new System.Drawing.Size(72, 46);
            this.btn_add_supplier.TabIndex = 6;
            this.btn_add_supplier.Tag = "بحث";
            this.toolTip1.SetToolTip(this.btn_add_supplier, "إضافة مورد جديد");
            this.btn_add_supplier.UseVisualStyleBackColor = true;
            this.btn_add_supplier.Click += new System.EventHandler(this.btn_add_supplier_Click);
            // 
            // btn_edit_supp
            // 
            this.btn_edit_supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit_supp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_supp.Image = global::Clinic_Management_System.Properties.Resources.if_sign_up_49622;
            this.btn_edit_supp.Location = new System.Drawing.Point(735, 5);
            this.btn_edit_supp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit_supp.Name = "btn_edit_supp";
            this.btn_edit_supp.Size = new System.Drawing.Size(72, 46);
            this.btn_edit_supp.TabIndex = 5;
            this.btn_edit_supp.Tag = "بحث";
            this.toolTip1.SetToolTip(this.btn_edit_supp, "تعديل بيانات مورد");
            this.btn_edit_supp.UseVisualStyleBackColor = true;
            this.btn_edit_supp.Click += new System.EventHandler(this.btn_edit_supp_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Image = global::Clinic_Management_System.Properties.Resources.if_1_04_511562;
            this.btn_delete.Location = new System.Drawing.Point(653, 5);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 46);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Tag = "بحث";
            this.toolTip2.SetToolTip(this.btn_delete, "حذف مورد");
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lb_Supplier
            // 
            this.lb_Supplier.AutoSize = true;
            this.lb_Supplier.Location = new System.Drawing.Point(689, 84);
            this.lb_Supplier.Name = "lb_Supplier";
            this.lb_Supplier.Size = new System.Drawing.Size(135, 23);
            this.lb_Supplier.TabIndex = 3;
            this.lb_Supplier.Text = "البحث عن مورد ";
            // 
            // txt_supp_search
            // 
            this.txt_supp_search.Location = new System.Drawing.Point(227, 80);
            this.txt_supp_search.Name = "txt_supp_search";
            this.txt_supp_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_supp_search.Size = new System.Drawing.Size(430, 30);
            this.txt_supp_search.TabIndex = 0;
            this.txt_supp_search.Tag = "";
            this.txt_supp_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txt_supp_search, "ادخل نص البحث ");
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = global::Clinic_Management_System.Properties.Resources.if_system_search_118797__1_;
            this.btn_search.Location = new System.Drawing.Point(116, 80);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(72, 37);
            this.btn_search.TabIndex = 1;
            this.btn_search.Tag = "بحث";
            this.toolTip1.SetToolTip(this.btn_search, "بحث ");
            this.btn_search.UseVisualStyleBackColor = true;
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
            // frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 418);
            this.Controls.Add(this.Pan_Search);
            this.Controls.Add(this.dqv_suppliers);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Supplier";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الموردين ";
            ((System.ComponentModel.ISupportInitialize)(this.dqv_suppliers)).EndInit();
            this.Pan_Search.ResumeLayout(false);
            this.Pan_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqv_suppliers;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel Pan_Search;
        private System.Windows.Forms.Label lb_Supplier;
        private System.Windows.Forms.TextBox txt_supp_search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_add_supplier;
        private System.Windows.Forms.Button btn_edit_supp;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}