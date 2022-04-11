using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();

        int k, l, m;

        private void Play_Image(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm3.pictureBox1.Location = new Point(l, 10);
            if(l > 45)
            {
                timer3.Enabled = true;
            }
            if (l > 255)
            {
                timer2.Enabled = false;
                l = -134;
            }
            l++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            frm4.pictureBox1.Location = new Point(m, 10);
            if (m > 45)
            {
                timer1.Enabled = true;
            }
            if (m > 255)
            {
                timer3.Enabled = false;
                m = -134;
            }
            
            m++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.pictureBox1.Location = new Point(k, 10);
            if (k > 45)
            {
                timer2.Enabled = true;
            }
            if (k > 255)
            {
                timer3.Enabled = false;
                k = -134;
            }

            k++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_File(object sender, EventArgs e)
        {
            frm2.MdiParent = this;
            frm3.MdiParent = this;
            frm4.MdiParent = this;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frm4.pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
                m = frm4.pictureBox1.Location.X;
                frm4.Show();
                frm3.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                l = frm3.pictureBox1.Location.X;
                frm3.Show();
                frm2.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                k = frm2.pictureBox1.Location.X;
                frm2.Show();

                this.LayoutMdi(MdiLayout.TileVertical);
            }
        }
    }
}
