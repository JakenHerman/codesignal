using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arcade.Intro
{
    public class EdgeOfTheOcean
    {
        public static int AdjacentElementsProduct(int[] inputArray)
        {
            List<int> products = new List<int>();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                products.Add(inputArray[i] * inputArray[i + 1]);
            }
            return products.Max();
        }
    }
}
