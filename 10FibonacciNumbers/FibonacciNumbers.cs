using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x1 = 0;
            int x2 = 1;
            if (n == 1)
            {
                Console.WriteLine(x1);
                return;
            }
            Console.Write("{0} {1}", x1, x2);
            for (int i = 2; i < n; i++)
            {
                int x3 = x1 + x2;
                Console.Write(" {0} ", x3);
                x1 = x2;
                x2 = x3;
            }
            Console.WriteLine();
        }
    }
}
