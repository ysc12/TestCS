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

//Ʃ�� ����
// �� ������ Ʃ�÷� ���ϴ� ������ ���� ���� �����ϴ� ���.