using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karekök_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            double karekök;

            sayi = Convert.ToInt32(textBox1.Text);
            karekök = Math.Sqrt(sayi);
            lblSonuc.Text = karekök.ToString();
        }
    }
}
