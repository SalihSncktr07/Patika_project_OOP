using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boşluk_yazma__tersten_yazma__ters_çevirme
{
    public partial class Form1 : Form
    {
        string metin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            button1.Text = "İşlem";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Değer Giriniz.";
                textBox1.Focus();
                textBox1.Text = "";
            }
            else
            {
                metin = textBox1.Text;
                //for (int i = 0; i < metin.Length; i++)    //Metni birer boşluklu yazar
                //{
                //    label1.Text += metin[i] + " ";
                //}

                //for (int i = metin.Length - 1; i >= 0; i--)     //Metni tersten yazdırma
                //{
                //    label1.Text += metin[i];
                //}

                //for (int i = 0; i < metin.Length; i++)      //Metin içerisindeki 'a' harfini '@' harfine çevirir.
                //{
                //    if (metin[i] == 'a')
                //    {
                //        label1.Text += '@';
                //    }
                //    else
                //    {
                //        label1.Text += metin[i];
                //    }
                //}

                //for (int i = 0; i < metin.Length; i++)      //Metin içerisindeki 'a' harfini '@' harfine çevirir.
                //{
                //    if (metin[i] == 'a')
                //    {
                //        label1.Text += '@';
                //    }
                //    else
                //    {
                //        label1.Text += metin[i];
                //    }
                //}

                for (int i = 0; i < metin.Length; i++)      //'0' ve '9' Arasındaki sayıları '?' ile değiiştirir.
                {
                    if (metin[i] >= '0' && metin[i] <= '9')
                    {
                        label1.Text += '?';
                    }
                    else
                    {
                        label1.Text += metin[i];
                    }
                }
            }
        }
    }
}
