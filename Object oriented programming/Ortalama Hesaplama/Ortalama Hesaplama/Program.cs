using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sinav1, sinav2, ortalama;
            Console.WriteLine("1. Sınav Notunuzu Giriniz.");
            sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sınav Notunuzu Giriniz.");
            sinav2 = Convert.ToDouble(Console.ReadLine());
            // 1. Sınav %60 2. Sınav %40
            ortalama = (sinav1 * 60 / 100) + (sinav2 * 40 / 100);

            if (ortalama < 40)
            {
                Console.WriteLine("Kaldınız!!!");
                Console.WriteLine("Ortalama: " + ortalama);
            }
            else if (ortalama <= 100)
            {
                Console.WriteLine("Geçtiniz, Tebrikler");
                Console.WriteLine("Ortalama: " + ortalama);
            }
            else
            {
                Console.WriteLine("Eksik Veya Yanlış Değer Girdiniz.");
            }
            
            Console.ReadLine();
        }
    }
}
