using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İki_sayı_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTpl_Click(object sender, EventArgs e)
        {
            int S1 = Convert.ToInt32(txtSayi_1.Text);
            int S2 = Convert.ToInt32(txtSayi_2.Text);
            int sonuc = S1 + S2;

            lblSonuc.Text = Convert.ToString(sonuc);
        }
    }
}
