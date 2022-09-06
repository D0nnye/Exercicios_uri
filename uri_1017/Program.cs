using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine());
            int KM = int.Parse(Console.ReadLine());

            double QntLT = (H * KM) / 12.00;
            Console.WriteLine(QntLT.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
