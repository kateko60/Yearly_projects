using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_objects
{
    internal class Catered
    {
        public string Name;
        public int Age;
        public char Virgin;

        public Catered(string newName, int newAge, char newVirgin)
        {
            this.Name = newName;
            this.Age = newAge;
            this.Virgin = newVirgin;
        }

        public void DisplayArray()
        {
            Console.WriteLine($"Name: { Name}");
            Console.WriteLine($"Age: { Age}");
            Console.WriteLine($"Virgin(Y/N): { Virgin }");
        }
    }
}
