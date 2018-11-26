using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arcade.Intro
{
    public class SmoothSailing
    {
        /*
         * Given an array of strings, return another array containing all of its longest strings.
         */
        public static string[] AllLongestStrings(string[] inputArray)
        {
            List<string> input = inputArray.ToList();
            return input.Where(y => y.Length == input.Select(r => r.Length).Max()).ToArray();
        }

    }
}
