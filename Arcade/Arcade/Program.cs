using System;
using Arcade.Intro;

namespace Arcade
{
    class Program
    {
        static void Main(string[] args)
        {
            //run all Intro Tasks
            Intro();
        }

        static void Intro()
        {
            Console.WriteLine(TheJourneyBegins.Add(1, 2)); // should return three
            Console.WriteLine(TheJourneyBegins.CenturyFromYear(1905)); // should return 20
            Console.WriteLine(TheJourneyBegins.CheckPalindrome("aabaa")); // should return true
        }
    }
}
