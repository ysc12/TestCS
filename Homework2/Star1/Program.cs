using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int one = 0; one < 5; one++)
            {
                for (int j = 0; j < one + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            for (int two = 0; two < 5; two++)
            {
                for (int j = 0; j < 4 - two; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < two + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            for (int three = 0; three < 5; three++)
            {
                for (int t = 0; t < 4 - three; t++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < three * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int four = 0; four < 4; four++)
            {
                for (int j = 0; j < four + 1; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k<7- four*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }


        Console.ReadLine();
        }
    }
}
