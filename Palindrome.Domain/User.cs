using System.Text.RegularExpressions;

namespace Palindrome.Domain
{
    public class User
    {
        public string Entered { get; set; }
        public void GetInput()
        {
            System.Console.WriteLine("Please enter your word or phrase:");
            Entered = System.Console.ReadLine();
        }
        public bool IsPalindrome()
        {
            string trim = Regex.Replace( Entered, @"s", "" );
            int min = 0;
            int max = trim.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = trim[min];
                char b = trim[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}