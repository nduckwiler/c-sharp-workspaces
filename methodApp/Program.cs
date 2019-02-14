using System;

namespace MethodApp
{
    class Program
    {
        // Use a static method that returns a string
        // Write and read from Console
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string input = Console.ReadLine();
            Console.Write("I think you said... ");
            Console.WriteLine(yell(input));
        }

        static string yell(string phrase) 
        {
            string loudPhrase = phrase.ToUpper() + "!";
            return loudPhrase;
        }
    }
}
