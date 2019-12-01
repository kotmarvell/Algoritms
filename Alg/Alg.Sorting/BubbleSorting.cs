using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Sorting
{
    public static class BubbleSorting
    {
        public static int[] BubbleSortInt(int[] array)
        {
            int length = array.Length;
            for(int i = 0; i < length - 1; i++)
            {
                for(int l = i; l < length; l++)
                {
                    if(array[i] > array[l])
                    {
                        Swap(array[i], array[l]);
                    }
                }
            }

            return array;
        }

        private static void Swap(int x, int y)
        {
            int swap = x;
            x = y;
            y = swap;
        }
    }
}
