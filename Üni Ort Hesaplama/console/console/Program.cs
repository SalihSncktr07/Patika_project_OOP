
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize, final, ort;
            Console.WriteLine("Vize notunu giriniz:");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz:");
            final = Convert.ToInt32(Console.ReadLine());
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ort);
            Console.WriteLine();
            if (ort < 50)
            {
                Console.WriteLine("Kaldınız.");
            }
            else
            {
                Console.WriteLine("Geçtiniz.");
            }
            Console.ReadLine();
        }
    }
}
