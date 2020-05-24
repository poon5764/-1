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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox21.Text);
            int y = int.Parse(textBox20.Text);
            int z = int.Parse(textBox19.Text);
            int g;
            g = (x * 12) + y + z;
            textBox18.Text = g.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox18.Text);
            int b = int.Parse(numericUpDown1.Text);
            int c = int.Parse(numericUpDown2.Text);
            int d = int.Parse(numericUpDown3.Text);
            int t = int.Parse(numericUpDown4.Text);
            int f = int.Parse(numericUpDown5.Text);
            int g = int.Parse(numericUpDown6.Text);
            int h = int.Parse(numericUpDown7.Text);
            int i = int.Parse(numericUpDown8.Text);
            int j = int.Parse(numericUpDown9.Text);
            int k = int.Parse(numericUpDown10.Text);
            int x = 0;
            int y;
            int z;
            if(f + g > 20000)
            {
                x = 20000;
            }    
            else if(f + g < 20000)
            {
                x = f + g;
            }
            y = b + c + d + t + h + i + j + k + x;
            textBox10.Text = y.ToString();
            z = a - y;
            textBox9.Text = z.ToString();
            int o = int.Parse(textBox9.Text);
            if (o > 5000000)
            {
                o = (o * 35 / 100);
            }
            else if (o > 2000000)
            {
                o = (o * 30 / 100);
            }
            else if (o > 1000000)
            {
                o = (o * 25 / 100);
            }
            else if (o > 750000)
            {
                o = (o * 20 / 100);
            }
            else if (o > 500000)
            {
                o = (o * 15 / 100);
            }
            else if (o > 300000)
            {
                o = (o * 10 / 100);
            }
            else if (o > 150000)
            {
                o = (o * 5 / 100);
            }
            else
            {
                o = (0);
            }

            textBox8.Text = o.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
