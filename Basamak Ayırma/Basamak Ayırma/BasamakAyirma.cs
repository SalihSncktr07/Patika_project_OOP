using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basamak_Ayırma
{
    internal class BasamakAyirma
    {
        public void basamak(int girilenSayi)
        {
            int binler, yüzler, onlar, birler;

            binler = girilenSayi / 1000;
            girilenSayi = girilenSayi - (binler * 1000);
            yüzler = girilenSayi / 100;
            girilenSayi = girilenSayi - (yüzler * 100);
            onlar = girilenSayi / 10;
            girilenSayi = girilenSayi - (onlar * 10);
            birler = girilenSayi / 1;
            girilenSayi = girilenSayi - (birler * 1);

            Console.WriteLine("Binler Basamağı: {0}", binler);
            Console.WriteLine("Yüzler Basamağı: {0}", yüzler);
            Console.WriteLine("Onlar Basamağı: {0}", onlar);
            Console.WriteLine("Birler Basamağı: {0}", birler);
        }
    }
}
