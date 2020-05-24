using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);
            int g;
            g = (x * 12) + y + z;
            textBox4.Text = g.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                groupBox7.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                groupBox7.Enabled = true;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                groupBox7.Enabled = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                groupBox7.Enabled = true;
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
            {
                numericUpDown7.Enabled = true;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                numericUpDown7.Enabled = false;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                numericUpDown4.Enabled = true;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                numericUpDown4.Enabled = false;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                numericUpDown5.Enabled = true;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                numericUpDown5.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                numericUpDown1.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                numericUpDown1.Enabled = false;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                numericUpDown2.Enabled = true;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                numericUpDown2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(numericUpDown7.Text);
            int c = int.Parse(numericUpDown4.Text);
            int d = int.Parse(numericUpDown5.Text);
            int g = int.Parse(numericUpDown1.Text);
            int f = int.Parse(numericUpDown2.Text);
            int x;
            int y;
            x = b + c + d + g + f;
            textBox7.Text = x.ToString();
            y = a - x;
            textBox5.Text = y.ToString();
            int z = int.Parse(textBox5.Text);
            if (z > 5000000)
            {
                z = (z * 35 / 100);
            }
            else if (z > 2000000)
            {
                z = (z * 30 / 100);
            }
            else if (z > 1000000)
            {
                z = (z * 25 / 100);
            }
            else if (z > 750000)
            {
                z = (z * 20 / 100);
            }
            else if (z > 500000)
            {
                z = (z * 15 / 100);
            }
            else if (z > 300000)
            {
                z = (z * 10 / 100);
            }
            else if (z > 150000)
            {
                z = (z * 5 / 100);
            }
            else
            {
                z = (0);
            }

            textBox6.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}