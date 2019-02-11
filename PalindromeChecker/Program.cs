using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Program{
        public static void Main()
        {
            Console.WriteLine("Enter a word and I'll tell you if it's a palindrome!");
            string chosenWord = Console.ReadLine().ToLower();
            char[] individualLetters = chosenWord.ToCharArray();
            List<char> reverseCharacters = new List<char> {};
            for (int i = 0; i < individualLetters.Length; i++)
            {
                reverseCharacters.Add(individualLetters[individualLetters.Length-(1+i)]);
            }
            char[] reverseCharArray = reverseCharacters.ToArray();
            string reverseWord = new string(reverseCharArray);
            Console.WriteLine(reverseWord);
            Console.WriteLine(chosenWord);
            if(chosenWord == reverseWord)
            {
                Console.WriteLine("You gave me a palindrome!");
            }
            else
            {   
                Console.WriteLine("You bogus gimme a palindrome.");
            }
        }
    }
}