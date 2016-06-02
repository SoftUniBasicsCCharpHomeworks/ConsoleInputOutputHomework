using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Formattingcers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string hex = Convert.ToString(a, 16);
        string bin = Convert.ToString(a, 2);
        Console.Write("|{0,-10}", hex.ToUpper());
        Console.Write("|{0}|", bin.PadLeft(10, '0'));
        Console.Write("{0,10}|", Math.Round(b, 2));
        Console.WriteLine("{0,-10:F3}|", c);
        //Console.WriteLine("|{0,-10} |{1,10}|{2,10:0.##}|{3,-10:F3}|", hex.ToUpper(), bin.PadLeft(10, '0'), b, c);
    }
}

