namespace Clinic_Management_System
{
    partial class frm_add_supplier
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
            this.lb_supp_id = new System.Windows.Forms.Label();
            this.txt_supplier_id = new System.Windows.Forms.TextBox();
            this.txt_supplier_name = new System.Windows.Forms.TextBox();
            this.lb_supp_name = new System.Windows.Forms.Label();
            this.txt_supplier_address = new System.Windows.Forms.TextBox();
            this.lb_supp_address = new System.Windows.Forms.Label();
            this.txt_supplier_phone = new System.Windows.Forms.TextBox();
            this.lb_supp_phone = new System.Windows.Forms.Label();
            this.btn_Cancl = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_supp_id
            // 
            this.lb_supp_id.AutoSize = true;
            this.lb_supp_id.Location = new System.Drawing.Point(311, 30);
            this.lb_supp_id.Name = "lb_supp_id";
            this.lb_supp_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_supp_id.Size = new System.Drawing.Size(94, 23);
            this.lb_supp_id.TabIndex = 0;
            this.lb_supp_id.Text = "كود المورد ";
            // 
            // txt_supplier_id
            // 
            this.txt_supplier_id.Location = new System.Drawing.Point(182, 27);
            this.txt_supplier_id.Name = "txt_supplier_id";
            this.txt_supplier_id.ReadOnly = true;
            this.txt_supplier_id.Size = new System.Drawing.Size(100, 30);
            this.txt_supplier_id.TabIndex = 1;
            this.txt_supplier_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_supplier_id, "الكود");
            // 
            // txt_supplier_name
            // 
            this.txt_supplier_name.Location = new System.Drawing.Point(21, 90);
            this.txt_supplier_name.Name = "txt_supplier_name";
            this.txt_supplier_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_supplier_name.Size = new System.Drawing.Size(261, 30);
            this.txt_supplier_name.TabIndex = 0;
            this.txt_supplier_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_supplier_name, "الاسم");
            // 
            // lb_supp_name
            // 
            this.lb_supp_name.AutoSize = true;
            this.lb_supp_name.Location = new System.Drawing.Point(306, 93);
            this.lb_supp_name.Name = "lb_supp_name";
            this.lb_supp_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_supp_name.Size = new System.Drawing.Size(105, 23);
            this.lb_supp_name.TabIndex = 2;
            this.lb_supp_name.Text = "اسم المورد ";
            // 
            // txt_supplier_address
            // 
            this.txt_supplier_address.Location = new System.Drawing.Point(21, 153);
            this.txt_supplier_address.Name = "txt_supplier_address";
            this.txt_supplier_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_supplier_address.Size = new System.Drawing.Size(261, 30);
            this.txt_supplier_address.TabIndex = 1;
            this.txt_supplier_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_supplier_address, "العنوان");
            // 
            // lb_supp_address
            // 
            this.lb_supp_address.AutoSize = true;
            this.lb_supp_address.Location = new System.Drawing.Point(305, 156);
            this.lb_supp_address.Name = "lb_supp_address";
            this.lb_supp_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_supp_address.Size = new System.Drawing.Size(106, 23);
            this.lb_supp_address.TabIndex = 4;
            this.lb_supp_address.Text = "عنوان المورد";
            // 
            // txt_supplier_phone
            // 
            this.txt_supplier_phone.Location = new System.Drawing.Point(21, 216);
            this.txt_supplier_phone.Name = "txt_supplier_phone";
            this.txt_supplier_phone.Size = new System.Drawing.Size(261, 30);
            this.txt_supplier_phone.TabIndex = 2;
            this.txt_supplier_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_supplier_phone, "رقم الهاتف");
            // 
            // lb_supp_phone
            // 
            this.lb_supp_phone.AutoSize = true;
            this.lb_supp_phone.Location = new System.Drawing.Point(309, 219);
            this.lb_supp_phone.Name = "lb_supp_phone";
            this.lb_supp_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_supp_phone.Size = new System.Drawing.Size(98, 23);
            this.lb_supp_phone.TabIndex = 6;
            this.lb_supp_phone.Text = "رقم الهاتف ";
            // 
            // btn_Cancl
            // 
            this.btn_Cancl.Image = global::Clinic_Management_System.Properties.Resources.Close_32x32;
            this.btn_Cancl.Location = new System.Drawing.Point(52, 297);
            this.btn_Cancl.Name = "btn_Cancl";
            this.btn_Cancl.Size = new System.Drawing.Size(145, 43);
            this.btn_Cancl.TabIndex = 9;
            this.toolTip2.SetToolTip(this.btn_Cancl, "إلغاء");
            this.btn_Cancl.UseVisualStyleBackColor = true;
            this.btn_Cancl.Click += new System.EventHandler(this.btn_Cancl_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Image = global::Clinic_Management_System.Properties.Resources.save_32;
            this.btn_Save.Location = new System.Drawing.Point(234, 297);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(145, 43);
            this.btn_Save.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Save, "حفظ");
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 10;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_add_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 376);
            this.Controls.Add(this.btn_Cancl);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_supplier_phone);
            this.Controls.Add(this.lb_supp_phone);
            this.Controls.Add(this.txt_supplier_address);
            this.Controls.Add(this.lb_supp_address);
            this.Controls.Add(this.txt_supplier_name);
            this.Controls.Add(this.lb_supp_name);
            this.Controls.Add(this.txt_supplier_id);
            this.Controls.Add(this.lb_supp_id);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مورد جديد";
            this.Load += new System.EventHandler(this.frm_add_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_supp_id;
        private System.Windows.Forms.Label lb_supp_name;
        private System.Windows.Forms.Label lb_supp_address;
        private System.Windows.Forms.Label lb_supp_phone;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        public System.Windows.Forms.TextBox txt_supplier_id;
        public System.Windows.Forms.TextBox txt_supplier_name;
        public System.Windows.Forms.TextBox txt_supplier_address;
        public System.Windows.Forms.TextBox txt_supplier_phone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}