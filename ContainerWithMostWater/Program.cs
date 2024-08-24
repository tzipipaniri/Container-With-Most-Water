using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    //    You are given an integer array height of length n.There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).

    //Find two lines that together with the x-axis form a container, such that the container contains the most water.

    //Return the maximum amount of water a container can store.

    //Notice that you may not slant the container.



    //Example 1:


    //Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
    //Output: 49
    //Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
    //Example 2:

    //Input: height = [1, 1]
    //Output: 1
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int[,] mat = new int[height.Length, height.Length];
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    mat[i, j] = Math.Min(height[i], height[j]) * Math.Abs(i + 1 - (j + 1));
                }
            }
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    if (mat[i, j] > max)
                        max = mat[i, j];
                }
            }
            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
