using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {

        static void ctn(ref char answer)
        {
            Console.Write("Continue? (y/n) : ");
            answer = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void input(ref int number1, ref int number2, ref char type)
        {
            Console.Write("input1 : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("type : ");
            type = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.Write("input2 : ");
            number2 = int.Parse(Console.ReadLine());
        }

        static int cal(ref int number1, ref int number2, ref int result, ref char type)
        {
            result = 0;

            switch (type)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.Write("ERROR");
                    break;
            }
            Console.WriteLine("result : " + result);
            return result;
        }
               
    static void Main(string[] args)
        {

            int num1 = 0, num2 = 0, result = 0;
            char type = ' ';
            char answer = ' ';

            input(ref num1, ref num2, ref type);
            

            while(true)
            {

                cal(ref num1, ref num2, ref result, ref type);

                ctn(ref answer);




                num1 = result;

                if (answer == 'y' || answer == 'Y')
                {
                    Console.Write("type : ");
                    type = Console.ReadKey().KeyChar;
                    Console.ReadLine();
                    
                    Console.Write("input2 : ");
                    num2 = int.Parse(Console.ReadLine());
                    
                    continue;
                }
                else if(answer == 'n' || answer == 'N')
                {
                    Console.WriteLine("finish");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }

            
            Console.ReadKey();


        }
    }
}
