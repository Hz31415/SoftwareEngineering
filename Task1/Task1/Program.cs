using System;

namespace Task1
{
    class Program
    {
        static int Main(int n, int[] cars, int k)
        {
            Array.Sort(cars);

            int length = cars[cars.Length - 1] - cars[0];
            for (int i = 0; i < cars.Length - k; i++)
            {
                if (length > (cars[i + k - 1] - cars[i] + 1))
                    length = cars[i + k - 1] - cars[i] + 1;
            }

            return length;
        }
    }
}
