using System;
using System.Globalization;

namespace uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double N1 = A * 2;
            double N2 = B * 3;
            double N3 = C * 5;



            double resultado = (N1 + N2 + N3) / 10;
            Console.WriteLine("MEDIA = " + resultado.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
