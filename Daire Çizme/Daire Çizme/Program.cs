using System;

namespace daire
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double thickness = 0.4;
            char symbol = '*';
            do
            {
                Console.Write("yaricapi gir; ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Pozitif sayi olmak zorunda");
                }
            }
            while (radius <= 0);
            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
