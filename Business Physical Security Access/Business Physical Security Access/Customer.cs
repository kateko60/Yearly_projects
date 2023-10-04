using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Physical_Security_Access
{
    internal class Customer
    {
        /*
        public Customer() {

            Shareholders.Shopping_Area();
        }
        */
        public static void Layers_Of_Security_ForCustomer()
        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Building/Area \t\tGranted/Denied");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Storage Room \t|\t{Shareholders.Employees_Computer()}");
            Console.WriteLine($"Security Offices |\t{Shareholders.Employees_Computer()}");
            Console.WriteLine($"Shopping Area \t|\t{Shareholders.Shopping_Area()}");
            Console.WriteLine($"Employees Computer |\t{Shareholders.Employees_Computer()}");
        }
    }
}
