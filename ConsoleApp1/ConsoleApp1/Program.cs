using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static event Action myAction;
        static void Main(string[] args)
        {

            while(true)
            {
                string s1 = Console.ReadLine();

                switch (s1)
                {
                    case "1":
                        myAction += One;
                        break;
                    case "2":
                        myAction += Two;
                        break;
                    case "3":
                        myAction += Three;
                        break;
                    case "4":
                        myAction?.Invoke();
                        break;
                    default:
                        break;
                }
                
                
                
            }




            Console.ReadKey();




        }

        static void One()
        {
            Console.WriteLine("Hi world");
        }

        static void Two()
        {
            Console.WriteLine("Hello world");
        }

        static void Three()
        {
            Console.WriteLine("안녕");
        }

    }

}
