using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business_Physical_Security_Access
{
    internal class Program
    {
        public static void Get_Person_Details()
        {
            Console.Write("What is your name: ");
            string First_Name = Console.ReadLine();

            Console.Write("What is your last name: ");
            string Last_Name = Console.ReadLine();

            Person Human = new Person(First_Name, Last_Name);
            Human.Greet_And_GiveAccess();
        }
        public static string Get_Occupation()
        {
            Console.Write("What is your occupation(shareholder/employee/customer): ");
            string Occupation = Console.ReadLine().ToUpper();
            while (Occupation != "SHAREHOLDER" && Occupation != "EMPLOYEE"
                && Occupation != "CUSTOMER")
            {
                Console.WriteLine("Please choose carefully from the given options");
                Console.Write("What is your occupation(shareholder/employee/customer): ");
                Occupation = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }
            return Occupation;
        }
        public static void Layer_Of_Security()
        {
            //aligning the layes of security depending on the conditions given
            string Occupation = Get_Occupation();
            if (Occupation == "SHAREHOLDER")
            {
                
                Shareholders.Layers_Of_Access_ForShareholder();
            }
              else if(Occupation == "EMPLOYEE")
            {
                Employee.Layers_Of_Security_ForEmployee();
            }
            else if(Occupation == "CUSTOMER")
            {
                Customer.Layers_Of_Security_ForCustomer();
            }

        }
        static void Main(string[] args)
        {
            Get_Person_Details();
            Layer_Of_Security();
            Console.WriteLine("Enjoy your stay.");
            Console.WriteLine();
            Console.Write("Is there more people(Y/N)? ");
            char More_Or_Not = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();
            for (int y = 1; y > 0; y++)
            {
                if (More_Or_Not == 'Y')
                {
                    Get_Person_Details();
                    Layer_Of_Security();
                    Console.WriteLine("Enjoy your stay.");
                    Console.WriteLine();
                    Console.Write("Is there more people(Y/N)? ");
                    More_Or_Not = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Enjoy your stay.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
