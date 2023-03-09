/* 
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
        int Charactercounter = CharacterCounter(characterInput, word);
        Console.WriteLine($"\tThere are {Charactercounter} {characterInput}'s in {word}");


        SectionSeparator("Array - IsPalindrome Section");

        Console.WriteLine("Enter a word that may or may not be a palindrome!");
        Console.WriteLine(IsPalindrome(Console.ReadLine()));

        SectionSeparator("List - Add Selection");
        List<string> names = new List<string>();
        char userInput = default;
        do
        {
            Console.WriteLine("Please enter a name.");
            names.Add(Console.ReadLine());
            Console.WriteLine("Please enter a key to add more or e to exit");
            userInput = Console.ReadKey().KeyChar;

        } while (userInput != 'e' && userInput != 'E' );

        SectionSeparator("List - Traversal Selection");
        TraverseList(names);

        SectionSeparator("List - Reverse Traversal Selection");
        TraverseListReverse(names);


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
            
            int charCounter = 0;
            word = word.ToLower();
            char[] charArray = word.ToCharArray();
        for (int i = 0; i < word.Length; i++)
        {
            
            if (charArray[i] == characterInput)
            {
                   charCounter++;
            }
        }
        return charCounter;
        }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    static bool IsPalindrome(string word)
        {
        word = word.ToLower();
        char[] wordArray = word.ToCharArray();
        string reverseWord = "";
       
            for(int i = 0; i < wordArray.Length; i++)
            {
                reverseWord = reverseWord + wordArray[wordArray.Length - i - 1 ];
            }
            if (reverseWord == word)
            {
            return true;
            }
            return false;
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


