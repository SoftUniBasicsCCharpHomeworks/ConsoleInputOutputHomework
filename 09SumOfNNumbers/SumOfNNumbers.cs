using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum=0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine(sum);
    }
}

