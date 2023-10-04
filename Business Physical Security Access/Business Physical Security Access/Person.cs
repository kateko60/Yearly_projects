using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Physical_Security_Access
{
    public class Person
    {
        public string First_Name;
        public string Last_Name;
        public string Occupation;

        public Person(string aFirst_Name, string aLast_Name)
        {
            this.First_Name = aFirst_Name;
            this.Last_Name = aLast_Name;
        }
        public void Greet_And_GiveAccess()
        {
            Console.WriteLine($"Hi! {First_Name} {Last_Name} ");
        }
    }
}
