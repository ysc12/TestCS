using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Console;

namespace RandomNumber
{
    class Program
    {

        static IntPtr ConsoleWindowHnd = GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("User32.Dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        const int VK_RETURN = 0x0D;
        const int WM_KEYDOWN = 0x100;

        static void Main(string[] args)
        {
            theThreadTimer();

            Random random = new Random();
            int ran = random.Next(1, 50);
            int player = 0;
            int count = 0;

            for (count = 9; count > 0; count--)
            {
                Write("숫자를 입력하세요 (1~50) : ");
                player = int.Parse(ReadLine());

                if (player == ran)
                {
                    WriteLine("축하합니다. 정답입니다!!");
                    break;
                }

                if (player > ran)
                {
                    WriteLine("더 작습니다.");
                    WriteLine("{0}회 남음", count);
                }
                else
                {
                    WriteLine("더 큽니다.");
                    WriteLine("{0}회 남음", count);
                }
            }

            if (count == 0)
            {
                WriteLine("아쉽지만 실패하였습니다.");
            }








            ReadKey();
        }

        static async Task theThreadTimer()
        {
            int theTime = 0;
            int timeLimit = 10;

            while (theTime < timeLimit)
            {
                await Task.Delay(1000);
                theTime++;
                WriteLine();
                Write("{0}초 경과!!", theTime);
                WriteLine();
            }

            PostMessage(ConsoleWindowHnd, WM_KEYDOWN, VK_RETURN, 0);
        }



    }
}
