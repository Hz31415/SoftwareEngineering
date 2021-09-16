using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        class Solution
        {
            int[][] A;
            public Solution(int[][] A)
            {
                this.A = A;
            }
            public int solution()
            {
                int counter = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < A[i].Length; j++)
                    {
                        if (A[i][j] != -2000000000)
                        {
                            counter++;
                            checkNeighbor(i, j);
                        }
                    }
                }
                return counter;
            }
            public void checkNeighbor(int i, int j)
            {
                int compararer = A[i][j];

                if (j + 1 < A[i].Length && A[i][j + 1] == compararer)
                {
                    A[i][j] = -2000000000;
                    checkNeighbor(i, j + 1);
                }
                if (j - 1 >= 0 && A[i][j - 1] != -2000000000 && A[i][j - 1] == compararer)
                {

                    A[i][j] = -2000000000;
                    checkNeighbor(i, j - 1);
                }
                if (i + 1 < A.Length && A[i + 1][j] == compararer)
                {
                    A[i][j] = -2000000000;
                    checkNeighbor(i + 1, j);
                }
                if (i - 1 >= 0 && A[i - 1][j] != -2000000000 && A[i - 1][j] == compararer)
                {
                    A[i][j] = -2000000000;
                    checkNeighbor(i - 1, j);
                }
                A[i][j] = -2000000000;
            }
        }
    }
}
