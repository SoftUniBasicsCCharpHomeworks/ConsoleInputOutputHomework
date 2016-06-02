using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDividableByGivenNumber
{
    class NumbersDividableByGivenNumber
    {
        static void Main()
        {
            Console.Write("Enter start value: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter end value: ");
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = x; i <= y; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
