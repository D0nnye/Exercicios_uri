using System;
using System.Globalization;

namespace uri_10115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] P1 = Console.ReadLine().Split();
            string[] P2 = Console.ReadLine().Split();

            double X1 = double.Parse(P1[0], CultureInfo.InvariantCulture);
            double X2 = double.Parse(P1[1], CultureInfo.InvariantCulture);

            double Y1 = double.Parse(P2[0], CultureInfo.InvariantCulture);
            double Y2 = double.Parse(P2[1], CultureInfo.InvariantCulture);

            double Distancia = Math.Sqrt(Math.Pow(X1 - Y1, 2.00) + Math.Pow(X2 - Y2, 2.00));

            Console.WriteLine(Distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
