using System;
using System.Globalization;

namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = (Console.ReadLine());
            double salariofixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double venda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = venda * 0.15;
            double total = salariofixo + comissao;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2" + CultureInfo.InvariantCulture));
        }
    }
}
