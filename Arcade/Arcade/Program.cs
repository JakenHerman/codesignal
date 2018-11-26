using System;
using Arcade.Intro;

namespace Arcade
{
    class Program
    {
        static int[] inputArray;
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

            //Edge Of The Ocean
            inputArray = new int[] { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(EdgeOfTheOcean.AdjacentElementsProduct(inputArray)); // should return 21
            Console.WriteLine(EdgeOfTheOcean.ShapeArea(2)); //should return 5
            Console.WriteLine(EdgeOfTheOcean.MakeArrayConsecutive2(new int[] { 6, 2, 3, 8 })); //should return 3

            //Rains of Reason
            inputArray = new int[] { 1, 2, 1 };
            Console.WriteLine(RainsOfReason.ArrayReplace(inputArray, 1, 3)); //should return [3, 2, 3]
        }
    }
}
