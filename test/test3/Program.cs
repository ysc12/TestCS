using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";
            string calcu = "";

            Console.WriteLine("input1 : ");
            s1 = Console.ReadLine();

            Console.WriteLine("input2 : ");
            s2 = Console.ReadLine();

            Console.WriteLine("calcu : ");
            calcu = Console.ReadLine();

            int resultNum = Calculator(int.Parse(s1), int.Parse(s2), calcu);

            Console.WriteLine("결과 : " + resultNum);
            Console.ReadKey();
        }

        static int Calculator(int num1, int num2, string type)
        {
            int result = 0;

            
            switch (type)
            {
                case "+" :
                    result = num1 + num2; 
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
           
            return result;


        }

        
    }
}

/*
 
1. 두 숫자를 입력받는다.
2. input : 1
3. input : 2
4. input : (곱, 뺄, 나눗, 덧셈)

5. 메소드로 빼서 진행
6. 결과물 출력하기
 
 
 */