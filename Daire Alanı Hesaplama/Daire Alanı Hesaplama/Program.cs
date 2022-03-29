using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Alanı_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DAİRE ALANI HESAPLAMA");
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Dairenin Yarıçapını Giriniz.");
                int r = Convert.ToInt32(Console.ReadLine());
                int pi = 3;
                int hesalplama = pi * r * r;
                Console.WriteLine("Dairenin Alanı: " + hesalplama + "\n");
            }
          
        }
    }
}
