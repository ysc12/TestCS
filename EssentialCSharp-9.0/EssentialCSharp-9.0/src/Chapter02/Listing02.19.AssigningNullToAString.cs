namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19
{
    public class Program
    {
        #region INCLUDE
        public static void Main()
        {
            int? age;
            //...

            // Clear the value of age
            age = null;

            #region EXCLUDE
            System.Console.WriteLine($"The age is: {age}");
            #endregion EXCLUDE
        }
        #endregion INCLUDE
    }
}

//null 소개

/*
 null은 아무것도 없음을 뜻함. (0 아님)
 말 그대로 Nothing을 뜻함

*/

