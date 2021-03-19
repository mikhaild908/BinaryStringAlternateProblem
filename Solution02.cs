using System;
using System.Linq;

namespace HeadsOrTails
{
    public static class Solution02
    {
        public static int GetMinimumNumberOfFlips(int[] source)
        {
            // Example: 1 1 0 -> requires a minimum of 1 flip to 
            //                   make the array alternating
            //
            //     1 1 0          1 1 0
            // XOR 1 0 1      XOR 0 1 0
            // ----------     ---------
            //     0 1 1          1 0 0
            //
            //    2 flips        1 flip

            var arrays = GenerateArraysWithAlternatingValues(source.Length);

            var firstNumberOfFlips = Enumerable.Range(0, source.Length)
                                        .Select(x => source[x] ^ arrays.Item1[x])
                                        .Sum();

            var secondNumberOfFlips = Enumerable.Range(0, source.Length)
                                        .Select(x => source[x] ^ arrays.Item2[x])
                                        .Sum();

            return firstNumberOfFlips <= secondNumberOfFlips ? firstNumberOfFlips : secondNumberOfFlips;
        }

        static Tuple<int[], int[]> GenerateArraysWithAlternatingValues(int length)
        {
            var firstArray = new int[length];
            var secondArray = new int[length];

            var currentElementOfFirstArray = 0;
            var currentElementOfSecondArray = 1;

            for (int i = 0; i < length; i++)
            {
                firstArray[i] = currentElementOfFirstArray;
                secondArray[i] = currentElementOfSecondArray;

                currentElementOfFirstArray = currentElementOfFirstArray ^ 1;
                currentElementOfSecondArray = currentElementOfSecondArray ^ 1;
            }

            return new Tuple<int[], int[]>(firstArray, secondArray);
        }
    }
}
