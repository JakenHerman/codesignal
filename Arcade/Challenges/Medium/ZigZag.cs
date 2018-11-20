using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Challenges.Medium
{
    public class ZigZag
    {
        public static int Zigzag(int[] a)
        {
            bool leftSmaller, rightSmaller, leftBigger, rightBigger, leftSame, rightSame, inSubArray;
            List<int[]> subArrays = new List<int[]>();
            List<int> subArray = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0 || i == a.Length - 1)
                {
                    subArray.Add(a[i]);
                    continue;
                }

                inSubArray = subArray.Count > 0 ? true : false;

                //check left side of element
                leftSmaller = (a[i - 1] < a[i]) ? true : false;
                leftBigger = (a[i - 1] > a[i]) ? true : false;
                leftSame = (!leftSmaller && !leftBigger) ? true : false;

                //check right side of element
                rightSmaller = (a[i + 1] < a[i]) ? true : false;
                rightBigger = (a[i + 1] > a[i]) ? true : false;
                rightSame = (!rightSmaller && !rightBigger) ? true : false;

                //check if both sides are exclusively smaller, or exclusively larger
                //and if so, add element to subArray
                if ((leftSmaller && rightSmaller) || leftBigger && rightBigger)
                {
                    if (i - 1 != -1 && !inSubArray)
                    {
                        subArray.Add(a[i - 1]);
                    }
                    subArray.Add(a[i]);
                }

                //check if elements are the same. If so, add element to subArray, 
                //and begin new subArray
                if (leftSame || rightSame && inSubArray)
                {
                    subArray.Add(a[i]);
                    subArrays.Add(subArray.ToArray());
                    subArray = new List<int>();
                }

                //if the left is bigger and the right is smaller or vice versa, and we're in a
                //subArray, we need to close the subArray as we're no longer zig-zagging.
                if ((leftSmaller && rightBigger) || (leftBigger && rightSmaller) && inSubArray)
                {
                    subArray.Add(a[i]);
                    subArrays.Add(subArray.ToArray());
                    subArray = new List<int>();
                }
            }
            return a.Length <= 2 ? 1 : subArrays.Max(x => x.Length);
        }

    }
}
