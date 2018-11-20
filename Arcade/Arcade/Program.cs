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
            //The Journey Begins
            Console.WriteLine(TheJourneyBegins.Add(1, 2)); // should return three
            Console.WriteLine(TheJourneyBegins.CenturyFromYear(1905)); // should return 20
            Console.WriteLine(TheJourneyBegins.CheckPalindrome("aabaa")); // should return true

            //Rains of Reason
            int[] inputArray = { 1, 2, 1 };
            Console.WriteLine(RainsOfReason.ArrayReplace(inputArray, 1, 3)); //should return [3, 2, 3]
        }
    }
}
