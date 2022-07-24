using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 5;
            Console.ReadLine();
            switch(s1)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("my");
                    break;
                case 3:
                    Console.WriteLine("World");
                    break;
                case 4:
                    Console.WriteLine("SBS");
                    break;
                case 5:
                    Console.WriteLine("Academy");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
                    
            }
            Console.ReadKey();

        }
    }
}
