using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapirKamenMakaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int p1 = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int com = rand.Next(1, 4);
            // 1 - papir
            // 2 - kamen
            // 3 - makaze
            if(com == p1)
            {
                label1.Text = "Nerešeno!";
            } else if ((com == 1 && p1 == 3) || (com == 2 && p1 == 1) || (com == 3 && p1 == 2))
            {
                label1.Text = "Pobednik: korisnik!";
            } else
            {
                label1.Text = "Pobednik: kompjuter!";
            }

            switch (com) {
                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources.paper;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.rock;
                    break;
                case 3:
                    pictureBox2.BackgroundImage = Properties.Resources.scissors;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            p1 = 1;
            if(radioButton1.Checked == true)
            {
                pictureBox1.BackgroundImage = Properties.Resources.paper;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p1 = 2;
            if (radioButton2.Checked == true)
            {
                pictureBox1.BackgroundImage = Properties.Resources.rock;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            p1 = 3;
            if (radioButton3.Checked == true)
            {
                pictureBox1.BackgroundImage = Properties.Resources.scissors;

            }
        }

       
    }
}
