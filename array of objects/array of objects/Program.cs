using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_objects
{
    internal class Program
    {
        public static void GetDetails(Catered[] catereds,ref int nrel)
        {
            Console.Write("What is your name: ");
            string Name = Console.ReadLine();

            Console.Write("How old are you: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Are you a virgin(Y/N)? ");
            char Virgin = char.Parse(Console.ReadLine().ToUpper());

            catereds[nrel] = new Catered(Name, Age, Virgin);
            nrel++;

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Catered[] catereds = new Catered[3];
            int nrel = 0;

            for(int y = 1; y <= 3; y++)
            {
                GetDetails(catereds , ref nrel);
            }
            Console.WriteLine("Details of persons: ");
            for (int i = 0; i < catereds.Length; i++)
            {
                catereds[i].DisplayArray();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
