using System;
using System.Globalization;

namespace uri_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double RAIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double PI = 3.14159;

            double VOLUME = (4 / 3.0) * PI * (RAIO * RAIO * RAIO);

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
