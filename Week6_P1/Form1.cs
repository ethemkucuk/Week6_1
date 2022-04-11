using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] array_1 = new string[8] { "a", "e", "ı", "i", "o", "ö", "u", "ü" };
        string[] array_2 = new string[50];

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j=0; j < 50; j++)
                {
                    if(array_2[j] == array_1[i])
                    {
                        textBox2.Text = textBox2.Text + array_2[j];
                    }
                }
            }
        }
        int i =0;
        private void Select(object sender, KeyPressEventArgs e)
        {
            if (i < 50)
            {
                array_2[i] = e.KeyChar.ToString();
                i++;
            }
            if (i > 50)
            {
                button1.Select();
            }
        }
    }
}
