using System;

namespace HeadsOrTails
{
    public static class Solution01
    {
        public static int Solve(int[] A)
        {
            int[] B = new int[A.Length];
            Array.Copy(A, B, A.Length);

            int solutionWithFirstElementChanged = SolveByChangingFirstElement(B);

            int[] C = new int[A.Length];
            Array.Copy(A, C, A.Length);

            int solutionWithFirstElementNotChanged = SolveByNotChangingFirstElement(C);

            return solutionWithFirstElementChanged <= solutionWithFirstElementNotChanged ? solutionWithFirstElementChanged : solutionWithFirstElementNotChanged;
        }

        static int SolveByChangingFirstElement(int[] A)
        {
            int counter = 1;
            int reversedFirstElement = A[0] == 1 ? 0 : 1;

            A[0] = reversedFirstElement;

            int next = reversedFirstElement == 1 ? 0 : 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != next)
                {
                    counter++;
                    A[i] = next;
                }

                next = A[i] == 1 ? 0 : 1;
            }

            return counter;
        }

        static int SolveByNotChangingFirstElement(int[] A)
        {
            int counter = 0;

            int first = A[0];
            int next = first == 1 ? 0 : 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != next)
                {
                    counter++;
                    A[i] = next;
                }

                next = A[i] == 1 ? 0 : 1;
            }

            return counter;
        }
    }
}
