using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillTests
{
    public class STMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLucky(1230)); // should return true
        }

        /* Ticket numbers usually consist of an even number of digits.
         * A ticket number is considered lucky if the sum of the first 
         * half of the digits is equal to the sum of the second half.
         * 
         * Given a ticket number n, determine if it's lucky or not.
         */
        public static bool IsLucky(int n)
        {
            List<int> listOfInts = new List<int>();
            while (n > 0)
            {
                listOfInts.Add(n % 10);
                n = n / 10;
            }
            listOfInts.Reverse();

            var first = 0;
            for (int i = 0; i < listOfInts.Count / 2; i++)
            {
                first += listOfInts.ElementAt(i);
            }

            var second = 0;
            for (int i = listOfInts.Count / 2; i < listOfInts.Count; i++)
            {
                second += listOfInts.ElementAt(i);
            }

            return first == second;
        }
    }
}
