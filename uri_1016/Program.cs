using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;
            tempo = int.Parse(Console.ReadLine());
            distancia = tempo * 2;
            Console.WriteLine(distancia + " minutos");
        }
    }
}
