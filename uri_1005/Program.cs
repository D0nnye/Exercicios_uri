using System;
using System.Globalization;

namespace uri_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P1 = A * 3.5;
            double P2 = B * 7.5;

            double resultado = (P1 + P2) / 11;
            Console.WriteLine("MEDIA = " + resultado.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
