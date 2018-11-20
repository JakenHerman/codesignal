using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Challenges.Medium
{
    public class ConstructArray
    {
        public static int[] constructArray(int size)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= size; i++)
            {
                if ((size + 1) - i > i)
                {
                    list.Add(i);
                    list.Add((size + 1) - i);
                }

                if ((size + 1) - i == i)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
    }
}
