﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pravljenjeRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sakrivamo beskoristne elemente
            groupBox1.Visible = false;
            this.Size = new Size(310, 265);
            
            label2.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;


        }

        private void operacijeSaRačunomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otkrivamo elemente
            groupBox1.Visible = true;
            this.Size = new Size(310, 370);

            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label4.Visible = true;
            textBox4.Visible = true;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            this.Size = new Size(310, 370);
            label5.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label4.Visible = true;
            textBox4.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            this.Size = new Size(310, 370);
            label5.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label4.Visible = true;
            textBox4.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            this.Size = new Size(535, 370);
            label5.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;

            this.Size = new Size(310, 370);

            label5.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint account = Convert.ToUInt32(textBox1.Text);
            string name = textBox2.Text;
            string surname = textBox3.Text;
            double amount = Convert.ToDouble(textBox4.Text);

            Racun osoba1 = new Racun(account, name, surname, amount);
            osoba1.UpitStanja();

            if (radioButton1.Checked == true)
            {
                osoba1.Uplati(Convert.ToDouble(textBox4.Text));
                osoba1.UpitStanja();
            } 
            else if (radioButton2.Checked == true)
            {
                osoba1.Isplati(Convert.ToDouble(textBox4.Text));
            }
            else if (radioButton3.Checked == true)
            {

            }
            else if (radioButton4.Checked == true)
            {

            }
            else if (groupBox1.Visible == false)
            {

            }


        }
    }
}
