using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buble_sort
{
    internal class Program
    {
        public static void BubleSort(int[] Numbers, int nrel)
        {
            int temp;
            bool swapped;
            for (int j = 0; j < nrel - 1; j++)
            {
                swapped = false;
                for (int y = 0; y < nrel - j - 1; y++)
                {
                    if (Numbers[y] > Numbers[y + 1])
                    {
                        temp = Numbers[y];
                        Numbers[y] = Numbers[y + 1];
                        Numbers[y + 1] = temp;
                        swapped = true;
                    }

                }
                if (swapped == false)
                    break;
            }
        }
        public static void PrinList(int[] Numbers, int nrel)
        {
            for(int y = 0; y < nrel; y++)
            {
                Console.WriteLine(Numbers[y] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] Numbers = { 3, 5, 2, 0, 9, 7 };
            int nrel = 6;

            BubleSort(Numbers, nrel);
            PrinList(Numbers, nrel);

            Console.ReadLine();
        }
    }
}
