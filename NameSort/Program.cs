using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MakeStar
{
    class Program
    {
        private static string m초성Tbl = "ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎ";
        private static string m중성Tbl = "ㅏㅐㅑㅒㅓㅔㅕㅖㅗㅘㅙㅚㅛㅜㅝㅞㅟㅠㅡㅢㅣ";
        private static string m종성Tbl = " ㄱㄲㄳㄴㄵㄶㄷㄹㄺㄻㄼㄽㄾㄿㅀㅁㅂㅄㅅㅆㅇㅈㅊㅋㅌㅍㅎ";
        private static ushort mUniCode한글Base = 0xAC00;
        private static ushort mUniCode한글Last = 0xD79F;
        private static string m초성;
        private static string m중성;
        private static string m종성;

        public class Pair<T, U>
        {
            public Pair()
            {
            }

            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }
        };

        static char c자소나누기(char c한글자, string chosung, string joongsung)
        {
            int i초성Idx, i중성Idx, i종성Idx; // 초성,중성,종성의 인덱스
            ushort uTempCode = 0x0000;       // 임시 코드용
            //Char을 16비트 부호없는 정수형 형태로 변환 - Unicode
            uTempCode = Convert.ToUInt16(c한글자);
            // 캐릭터가 한글이 아닐 경우 처리
            if ((uTempCode < mUniCode한글Base) || (uTempCode > mUniCode한글Last))
            {
                chosung = ""; joongsung = ""; m종성 = "";
            }
            // iUniCode에 한글코드에 대한 유니코드 위치를 담고 이를 이용해 인덱스 계산.
            int iUniCode = uTempCode - mUniCode한글Base;
            i초성Idx = iUniCode / (21 * 28);
            iUniCode = iUniCode % (21 * 28);
            i중성Idx = iUniCode / 28;
            iUniCode = iUniCode % 28;
            i종성Idx = iUniCode;
            chosung = new string(m초성Tbl[i초성Idx], 1);
            joongsung = new string(m중성Tbl[i중성Idx], 1);
            m종성 = new string(m종성Tbl[i종성Idx], 1);

            return char.Parse(chosung);


        }
        static int han(char a)
        {
            var myList = new List<KeyValuePair<char, int>>();
            myList.Add(new KeyValuePair<char, int>('ㄱ', 1));
            myList.Add(new KeyValuePair<char, int>('ㄴ', 2));
            myList.Add(new KeyValuePair<char, int>('ㄷ', 3));
            myList.Add(new KeyValuePair<char, int>('ㄹ', 4));
            myList.Add(new KeyValuePair<char, int>('ㅁ', 5));
            myList.Add(new KeyValuePair<char, int>('ㅂ', 6));
            myList.Add(new KeyValuePair<char, int>('ㅅ', 7));
            myList.Add(new KeyValuePair<char, int>('ㅇ', 8));
            myList.Add(new KeyValuePair<char, int>('ㅈ', 9));
            myList.Add(new KeyValuePair<char, int>('ㅊ', 10));
            myList.Add(new KeyValuePair<char, int>('ㅋ', 11));
            myList.Add(new KeyValuePair<char, int>('ㅌ', 12));
            myList.Add(new KeyValuePair<char, int>('ㅍ', 13));
            myList.Add(new KeyValuePair<char, int>('ㅎ', 14));
            foreach (var i in myList) if (a == i.Key) return i.Value;

            return 0;
        }

        static void Main(string[] args)
        {
            string[] name = { "황수연", "김동록", "김동광", "전지수" };
            for (int i = 0; i < 4; i++)
            {
                int key = i;
                for (int j = i; j >= 0; j--)
                {
                    char n = c자소나누기(name[key][0], m초성, m중성), n2 = c자소나누기(name[j][0], m초성, m중성);

                    if (han(n) < han(n2))
                    {
                        string nTemp = name[j];
                        name[j] = name[key];
                        name[key] = nTemp;
                        key = j;
                    }
                    else if (han(n) == han(n2))
                    {
                        char jn = c자소나누기(name[key][1], m초성, m중성), jn2 = c자소나누기(name[j][1], m초성, m중성);
                        if (han(jn) < han(jn2))
                        {
                            string nTemp = name[j];
                            name[j] = name[key];
                            name[key] = nTemp;
                            key = j;
                        }
                        else if (han(n) == han(n2))
                        {
                            char jjn = c자소나누기(name[key][2], m초성, m중성), jjn2 = c자소나누기(name[j][2], m초성, m중성);
                            if (han(jjn) < han(jjn2))
                            {
                                string nTemp = name[j];
                                name[j] = name[key];
                                name[key] = nTemp;
                                key = j;
                            }
                        }
                    }
                }


            }




            foreach (var and in name) WriteLine(and);


            ReadKey();
        }
    }
}

