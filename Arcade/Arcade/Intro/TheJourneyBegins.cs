using System;
using System.Collections.Generic;
using System.Text;

namespace Arcade.Intro
{
    public static class TheJourneyBegins
    {
        //Write a function that returns the sum of two numbers.
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        /*
         * Given a year, return the century it is in. The first century spans from the year 1 
         * up to and including the year 100, the second - from the year 101 up to and including
         * the year 200, etc.
         * 
         */
        public static int CenturyFromYear(int year)
        {
            return year % 100 != 0 ? (year / 100) + 1 : (year / 100);
        }

        //Given the string, check if it is a palindrome.
        public static bool CheckPalindrome(string inputString)
        {
            char[] bchar = inputString.ToCharArray();
            Array.Reverse(bchar);
            return string.Compare(new string(bchar), inputString) == 0;
        }
    }
}
