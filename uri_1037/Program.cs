﻿using System;
using System.Globalization;


namespace uri_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            if (num >= 0 && num <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num >= 25 && num <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (num >= 50 && num <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (num >= 75 && num <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}

