using Palindrome.Domain;

namespace Palindrome.Client
{
    public class Program
    {
        public static void main(string[] args)
        {
            User user = new User();
            user.GetInput();
            bool Palindrome = user.IsPalindrome();
            if(Palindrome)
            {
                System.Console.WriteLine("Your entered word or phrase IS A PALINDROME!");
            }
            else
            {
                System.Console.WriteLine("Your entered word or phrase IS NOT A PALINDROME!");
            }
        }
    }
}