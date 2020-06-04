using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementare_heapsort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[10];
            for (int i = 0; i < 10; i++)
            {
                s[i] = StringGenerator(10);

            }

            HeapSort.show<string>(s);
            Console.WriteLine();

            HeapSort.sort<string>(s);

            HeapSort.show<string>(s);
            Console.WriteLine();
        }

        public static Random random = new Random();

        public static string StringGenerator(int n)
        {
            StringBuilder str_build = new StringBuilder();
            char letter;

            for (int i = 0; i < n; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }

            return str_build.ToString();
        }
    }
}
