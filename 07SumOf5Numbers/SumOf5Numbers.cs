using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter five numbers seperated by space: ");
        string[] number = Console.ReadLine().Split();
        double sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            sum += Convert.ToDouble(number[i]);
        }
        Console.WriteLine(sum);
    }
}

