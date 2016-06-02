using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWand
{
    class MagicWand
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int p = 0;
            Console.WriteLine("{0}*{0}", new string('.', ((3*n+2)-1)/2));
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', ((3 * n + 2) - 1) / 2 - i), new string('.', i+k));
                k++;
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', (3 * n + 2) - 2*n));
            for (int i = 1; i <= (n-1)/2; i++)
            {
                
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', ((3 * n + 2) - 4)-p));
                p += 2;
            }
            for (int i = 0; i < (n - 1) / 2; i++)
            {

                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', ((n - 1) / 2)-1-i), new string('.', (n - 1) / 2), new string('.', i), new string('.', n));
                
            }
            Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', (n +1) /2), new string('.', (n -1) / 2), new string('.', n));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{0}*{0}", new string('.', n));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n+2));
        }
    }
}
