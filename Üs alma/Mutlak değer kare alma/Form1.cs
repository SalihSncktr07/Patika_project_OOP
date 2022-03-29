using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutlak_değer_kare_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi1.Text);
            int kare = Convert.ToInt32(txtSayi2.Text);
            int sonuc = (int)Math.Pow(sayi, kare);

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
