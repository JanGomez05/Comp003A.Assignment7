﻿/* 
 * Author: Jan Gomez
 * COurse: Comp003A L01
 * Purpose: Creating a list and arrays for Assignment 7
 * 
 */
 namespace Comp003A.Assignment7;
class Program
{
    private static bool e;

    static void Main(string[] args)
    {
        SectionSeparator("Array - Character Counter");

        Console.WriteLine("Please enter a letter.");
        char characterInput = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Now write your choice of word:");
        string word = Console.ReadLine();
        CharacterCounter(characterInput, word);

        SectionSeparator("Array - IsPalindrome Section");

        Console.WriteLine("Enter a word that may or may not be a palindrome!");
        Console.WriteLine(IsPalindrome(Console.ReadLine()));

        SectionSeparator("List - Add Selection");
        List<string> names = new List<string>();
        char userInput = default;
        do
        {
            Console.WriteLine("Please enter a name.");
            Console.ReadLine();
            Console.WriteLine("Please enter a key to add more or e to exit");
            userInput = Convert.ToChar(Console.ReadLine());
        } while ( userInput != 'e' || userInput != 'E' );

        SectionSeparator("List - Traversal Selection");


    }// end of main code

    /// <summary>
    /// 
    /// </summary>
    /// <param name="section"></param>
    static void SectionSeparator(string section)
    {
        Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="characterInput"></param>
    /// <param name="word"></param>
    /// <returns></returns>
        static int CharacterCounter(char characterInput, string word)
        {
            char[] charArray = word.ToCharArray();
            int charCounter = characterInput;
            word = word.ToLower();
            
            for(int i = 0; i < word.Length; i++)
            {
            
            if (charArray[i] == charCounter)
            { 
                   Console.WriteLine($"\tThere are {i-1} {characterInput}'s in {word}"); 
            }
        }
            return charCounter++;
        }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    static bool IsPalindrome(string word)
        {
        char[] wordArray = word.ToCharArray();
        string reverseWord = "";
        bool work = false;
            for(int i = 0; i < wordArray.Length; i++)
            {
                reverseWord = reverseWord + wordArray[wordArray.Length - i - 1 ];
            }
            if (reverseWord == word)
            {
                work = true;
            }
            return work;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
    static void TraverseList(List<string> list)
        {
            foreach(var word in list)
            {
                Console.WriteLine(word);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
    static void TraverseListReverse(List<string> list)
        {
            list.Reverse();
            foreach(var word in list)
            {
            Console.WriteLine(word);
            }
        }
}


