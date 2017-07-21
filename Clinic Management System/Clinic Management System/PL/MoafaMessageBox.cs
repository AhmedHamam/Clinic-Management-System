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
    public enum MoafaIcon{Success,Error}
    public partial class MoafaMessageBox : Form
    {
        public MoafaMessageBox()
        {
            InitializeComponent();

        }

        public void MoafaShow(string text, MoafaIcon moafaIcon)
        {
           
            label1.Text = text;
            if (moafaIcon == MoafaIcon.Success)
                pictureBox1.Image = Properties.Resources.Apply_32x32;
            else
                pictureBox1.Image = Properties.Resources.Close_32x32;

            this.Show();
            this.timer1.Start();

           
        }
        
        public  void MoafaShow(string text,MoafaIcon moafaIcon,Color backColor,Color foreColor)
        {
            label1.Text = text;
            if (moafaIcon == MoafaIcon.Success)
                pictureBox1.Image = Properties.Resources.Apply_32x32;
            else
                pictureBox1.Image = Properties.Resources.Close_32x32;

            this.BackColor = backColor;
            this.label1.ForeColor = foreColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Hide();
            this.timer1.Stop();
        }
    }
}
