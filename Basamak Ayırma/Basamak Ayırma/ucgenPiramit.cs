using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basamak_Ayırma
{
    internal class ucgenPiramit
    {
        public void piramit()
        {
            for (int i = 1; i < 20; i++)
            {
                for (int k = i; k < 20; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
