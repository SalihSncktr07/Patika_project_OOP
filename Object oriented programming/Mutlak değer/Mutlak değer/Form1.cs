﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutlak_değer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;

            x = Convert.ToInt32(textBox1.Text);
            y = Math.Abs(x);
            lblSonuc.Text = y.ToString();
        }
    }
}
