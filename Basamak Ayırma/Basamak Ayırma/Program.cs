using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basamak_Ayırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BASAMAK AYIRMA

            BasamakAyirma basamak = new BasamakAyirma();
            Console.WriteLine("4 Basamaklı bir sayi giriniz.");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            basamak.basamak(girilenSayi);



            //ŞEKİL ÇİZME

            //Sekiller ucgen = new Sekiller();
            //Console.WriteLine("Lütfen bir değer giriniz.");
            //int deger = Convert.ToInt32(Console.ReadLine());
            //ucgen.ucgen(deger);

            //Console.WriteLine();
            //ucgen.dortgen();



            //ÜÇGEN PİRAMİT
            
            //ucgenPiramit piramit = new ucgenPiramit();
            //piramit.piramit();

            Console.ReadLine();
        }
    }
}
