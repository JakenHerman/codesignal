using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arcade.Intro
{
    public class EdgeOfTheOcean
    {
        /*Given an array of integers, find the pair of adjacent elements 
         * that has the largest product and return that product.*/
        public static int AdjacentElementsProduct(int[] inputArray)
        {
            List<int> products = new List<int>();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                products.Add(inputArray[i] * inputArray[i + 1]);
            }
            return products.Max();
        }


        /*
             Below we will define an n-interesting polygon. Your task is 
             to find the area of a polygon for a given n.

             A 1-interesting polygon is just a square with a side of length 1. 
             An n-interesting polygon is obtained by taking the n - 1-interesting polygon
             and appending 1-interesting polygons to its rim, side by side.
        */
        public static int ShapeArea(int n)
        {
            int sum = 1;
            for (int i = 0; i < n; i++)
            {
                sum += 4*i;
            }
            return sum;
        }
    }
}
