using System;

namespace HeadsOrTails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution 01");
            Console.WriteLine(Solution01.Solve(new int[] { 1, 0, 1, 0, 1, 1 })); // 1
            Console.WriteLine(Solution01.Solve(new int[] { 1, 1, 0, 1, 1 })); // 2
            Console.WriteLine(Solution01.Solve(new int[] { 0, 1, 0 })); // 0
            Console.WriteLine(Solution01.Solve(new int[] { 0, 1, 1, 0 })); // 2

            Console.WriteLine();

            Console.WriteLine("Solution 02");
            Console.WriteLine(Solution02.GetMinimumNumberOfFlips(new int[] { 1, 0, 1, 0, 1, 1 })); // 1
            Console.WriteLine(Solution02.GetMinimumNumberOfFlips(new int[] { 1, 1, 0, 1, 1 })); // 2
            Console.WriteLine(Solution02.GetMinimumNumberOfFlips(new int[] { 0, 1, 0 })); // 0
            Console.WriteLine(Solution02.GetMinimumNumberOfFlips(new int[] { 0, 1, 1, 0 })); // 2
        }
    }
}