using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamItem
{
    class DreamItem
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            decimal workingDays=0;
            if (input[0]== "Feb")
            {
                workingDays = 18;
            }
            if (input[0] == "Jan"|| input[0] == "March" ||input[0] == "May" || input[0] == "July" || input[0] == "Aug" || input[0] == "Oct" || input[0] == "Dec")
            {
                workingDays = 21;
            }
            if (input[0] == "Apr" || input[0] == "June"|| input[0] == "Sept" || input[0] == "Nov")
            {
                workingDays = 20;
            }
            decimal salary = workingDays * Convert.ToDecimal(input[1]) * Convert.ToDecimal(input[2]);
            if (salary>700)
            {
                salary +=salary/10;
            }
            //Console.WriteLine(salary);
            decimal price = Convert.ToDecimal(input[3]);
            if (salary>= price)
            {
                Console.WriteLine("Money left = {0:0.00} leva.",salary-price);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:0.00} leva needed.",price-salary);
            }
        }
    }
}
