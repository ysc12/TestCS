namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_32
{
    #region INCLUDE
    public class Palindrome
    {
        public static void Main()
        {
            string reverse, palindrome;
            char[] temp;

            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();

            // Remove spaces and convert to lowercase
            reverse = palindrome.Replace(" ", "");
            reverse = reverse.ToLower();

            #region HIGHLIGHT
            // Convert to an array
            temp = reverse.ToCharArray();
            #endregion HIGHLIGHT

            #region HIGHLIGHT
            // Reverse the array
            System.Array.Reverse(temp);
            #endregion HIGHLIGHT

            // Convert the array back to a string and
            // check if reverse string is the same
            if (reverse == new string(temp))
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\" is a palindrome.");
            }
            else
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\" is NOT a palindrome.");
            }
        }
    }
    #endregion INCLUDE
}

//배열 사용가능 기능
/*
 sort - 정렬하기
BinarySearch - 검색(이진 탐색)
reverse - 뒤집기
clear - 지우기
 
 */
