using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        string compPhoneNumb = Console.ReadLine();
        Console.Write("Company fax number: ");
        string compFaxNumb = Console.ReadLine();
        Console.Write("Company website: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string manFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string manLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int manAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        int manPhoneNumb = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}\ncompany addres:{1}\nphone:{2}\nfax:{3}\nwebsite:{4}", compName, compAddress, compPhoneNumb, compFaxNumb, website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, phone:{3})", manFirstName, manLastName, manAge, manPhoneNumb);
    }
}

