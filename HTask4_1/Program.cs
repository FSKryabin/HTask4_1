using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTask4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1;
            Console.Write("Ввести целое число:");
            int n = int.Parse(Console.ReadLine());
            while (y <= n * 2)
            {
                x += y;
                y += 2;
                Console.WriteLine(x.ToString());
            }
            Console.ReadKey();
        }
    }
}
