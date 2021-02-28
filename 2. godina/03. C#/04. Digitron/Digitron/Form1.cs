using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;
            if(radioButton1.Checked == true)
            {
                c = a + b;
            } else if (radioButton2.Checked == true)
            {
                c = a - b;
            } else if (radioButton3.Checked == true)
            {
                c = a * b;
            } else
            {
                c = a / b;
            }
            c = Math.Round(c, 4);
            label3.Text = Convert.ToString(c);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void digitronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;


        }

        private void odvajanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string recenica = textBox3.Text;
            string[] rec = recenica.Split('_', ' ', '*');

            for(int i = 0; i < rec.Length; i++)
            {
                label4.Text += rec[i] + "\r\n";
            }
            
        }
    }
}
