using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            FinalFinal.Visible = false;
            Final.Visible = false;
            pictureBox2.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = false;
            Final.Visible = true;
        }

        private void Final_Click(object sender, EventArgs e)
        {
            FinalFinal.Visible = true;
            Final.Visible = false;
        }

        private void FinalFinal_Click(object sender, EventArgs e)
        {
            FinalFinal.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = false;
            FinalFinal.Visible = true;
        }
    }
}
