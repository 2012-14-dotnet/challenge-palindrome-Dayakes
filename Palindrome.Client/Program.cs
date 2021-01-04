using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
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
