namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_16
{
    #region INCLUDE
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(
            #region HIGHLIGHT
                $"Your full name is { firstName } { lastName }.");
            #endregion HIGHLIGHT
        }
    }
    #endregion INCLUDE
}
