using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Physical_Security_Access
{
    internal class Shareholders
    {
        /*
      public void Get_Person_Details()
        {
            Program.Get_Person_Details();
        }
        */
        public static string Storage_Room()
        {
            return "Granted";
        }
        public static string Security_Offices()
        {
            return "Granted";
        }
        public static string Shopping_Area()
        {
            return "Granted";
        }
        public static string Employees_Computer()
        {
            return "Denied";
        }
      
        public static void Layers_Of_Access_ForShareholder()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("Building/Area \t\tGranted/Denied");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Storage Room \t|\t{Storage_Room()}");
            Console.WriteLine($"Security Offices |\t{ Security_Offices()}");
            Console.WriteLine($"Shopping Area \t|\t{Shopping_Area()}");
            Console.WriteLine($"Employees Computer |\t{Employees_Computer()}");

        }
    }
}
