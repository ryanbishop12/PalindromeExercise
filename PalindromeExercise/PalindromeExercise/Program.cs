using System;
using System.Linq;

namespace PalindromeExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static bool IsPalindrome(string word)
        {
            return word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
    }
}
