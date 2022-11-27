using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kim_Milyoner_Olmak_İster_2010__2_
{
    public partial class Form115 : Form
    {
        public Form115()
        {
            InitializeComponent();
        }
        public Int32 t = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form115_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 900;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            if (t==0)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
