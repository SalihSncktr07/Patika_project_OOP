using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_Çevre_ve_Alan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, sonuc;

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUzun.Clear();
            txtKısa.Clear();
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtKısa.Text);
            b = Convert.ToInt32(txtUzun.Text);
            sonuc = a * b;

            MessageBox.Show(sonuc.ToString());
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtKısa.Text);
            b = Convert.ToInt32(txtUzun.Text);
            sonuc = (a + b) * 2;

            MessageBox.Show(sonuc.ToString());
        }
    }
}
