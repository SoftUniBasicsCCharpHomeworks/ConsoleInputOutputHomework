using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        double d = Math.Sqrt((b * b) - (4 * a * c));
        double x1 = (-b - d) / (2 * a);
        double x2 = (-b + d) / (2 * a);


        if (d > 0 && a != 0)
        {
            Console.WriteLine("x1= " + x1 + "; x2= " + x2);


        }
        if (d == 0 && a != 0)
        {
            Console.WriteLine("x1=x2= " + x1);

        }
        else if(d < 0 && a != 0)
        {
            Console.WriteLine("No real roots");
        }
    }
}

