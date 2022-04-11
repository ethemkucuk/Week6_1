using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
            }
            timer1.Enabled=true;
        }
        int x = 0, y = 100;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled=true;
        }


        int i=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 30)
                pictureBox1.Top += 2;
            if (i > 30)
            {
                pictureBox1.Top -= 2;
            }
            if (i >= 60)
            {
                i = 0;
                timer1.Enabled = true;
                timer2.Enabled = false;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location=new Point(x,y);
            x++;
        }
    }
}
