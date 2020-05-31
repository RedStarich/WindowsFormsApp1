using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bus = Convert.ToString(comboBox1.Text);
            //Y(x) = 1 + (1, 25 * z * n)x
            //max people 5000 min 200
            int maxp = 8000;
            int minp = 100;
            int chanse = 0;
            int N = 0;
            int people = Convert.ToInt32(textBox1.Text);
            int day = Convert.ToInt16(textBox2.Text);
            int c = Convert.ToInt16(textBox3.Text);
            chanse = people;
            N = ((maxp*day - minp*day)*c)/ ((maxp * day - chanse) ) ;
            if (c < 1)
            {
                label1.Text = Convert.ToString(99);
            }
            else
            {
                label1.Text = Convert.ToString(N);
            }
        }
    }
}
