﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kim_Milyoner_Olmak_İster_2010__2_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public Int32 t = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 900;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;




            if (t == 5)
            {
                Application.Exit();
            }
        }
    }
}
