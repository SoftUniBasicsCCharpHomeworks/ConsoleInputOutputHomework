using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main()
        {
            decimal r = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());

            decimal rubles = r / 100m * 3.5m;
            decimal dollars = d * 1.5m;
            decimal euros = e * 1.95m;
            decimal levaB = b / 2m;

            List< decimal> prices = new List<decimal>();
            prices.Add( rubles);
            prices.Add(dollars);
            prices.Add( euros);
            prices.Add(levaB);
            prices.Add( m);
            Console.WriteLine("{0:F2}",prices.Min());



        }
    }
}
