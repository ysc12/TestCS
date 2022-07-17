namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{
    public class Program
    {
        public static void Main()
        {
            (string First, string Second, string Third) nameFruits = ("apple", "orange", "banana");

            var nameFruit2 = ("apples", "orange", "etc");

            nameFruits.First = "Eat";

            Console.ReadKey();
        }
    }
}

//튜플 형식
// 값 형식을 튜플로 원하는 형식을 직접 다음 구현하는 방식.