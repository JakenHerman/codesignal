using Challenges.Medium;
using System;

namespace Challenges
{
    public class ChallengeMain
    {
        static void Main(string[] args)
        {
            Medium();
        }

        static void Easy()
        {
        }

        static void Medium()
        {
            int[] a = new int[10] {9, 8, 8, 5, 3, 5, 3, 2, 8, 6};
            Console.WriteLine(ZigZag.Zigzag(a)); // we expect 4
        }

        static void Hard()
        {

        }
    }
}
