using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Physical_Security_Access
{
    internal class Employee
    {
        /*
        public Employee() {

            Shareholders.Shopping_Area();
            Shareholders.Employees_Computer();         
        }
        */
        public static void Layers_Of_Security_ForEmployee()
        {
            Console.WriteLine("___________________________________________");
            Console.WriteLine("Building/Area \t\tGranted/Denied");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Storage Room\t|\t{Shareholders.Employees_Computer()}");
            Console.WriteLine($"Security Offices |\t{Shareholders.Employees_Computer()}");
            Console.WriteLine($"Shopping Area\t|\t{Shareholders.Security_Offices()}");
            Console.WriteLine($"Employees Computer |\t{Shareholders.Security_Offices()}");

        }
    }
}
