using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int Number in intArray)
            {
                Console.WriteLine(Number + 3);
                Console.ReadLine();
            }
        }
    }
}
