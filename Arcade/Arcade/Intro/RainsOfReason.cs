using System;
using System.Collections.Generic;
using System.Text;

namespace Arcade.Intro
{
    public class RainsOfReason
    {
        public static int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }
            return inputArray;
        }
    }
}
