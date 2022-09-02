using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] values = { 1, 5, 10, 20, 50, 100 };
            int[] amounts = new int[values.Length];
            int totalAmount = 363;

            =
            while (left > 0)
            {
                int nextNote = random.Next(0, values.Length);
                if (values[nextNote] < left)
                {
                    left -= values[nextNote];,
                    amounts[nextNote]++;
                }
            }
        }
    }
}
