using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uvod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;      // A
            string t2 = textBox2.Text;      // B
            string t3 = textBox3.Text;
            double a, b, c;
            //double z = a + b;
            // MessageBox.Show(Convert.ToString(z));
            // MessageBox.Show("Rezultat sabiranja a i b je: " + z);
            //label4.Text = Convert.ToString(z);
            double rez = 0;
            if(radioButton1.Checked == true)
            {
                a = Convert.ToDouble(t1);
                b = Convert.ToDouble(t2);
                // Pravougaonik
                rez = a * b;
                label4.Text = Convert.ToString(rez);
            }
            else if(radioButton2.Checked == true)
            {
                a = Convert.ToDouble(t1);
                // Krug
                rez = a * a * Math.PI;
                label4.Text = Convert.ToString(rez);
            }
            else if (radioButton3.Checked)
            {
                a = Convert.ToDouble(t1);
                b = Convert.ToDouble(t2);
                c = Convert.ToDouble(t3);
                // Kvadar
                rez = 2 * (a * b) + 2 * (a * c) + 2 * (b * c);
                label4.Text = Convert.ToString(rez);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Kvadar
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;

        }
    }
}
