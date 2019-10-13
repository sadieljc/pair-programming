using System;
using System.Collections.Generic;

namespace Core
{
    public class ClosestNumbers
    {
        public int[] Evaluate(int[] numbers)
        {
            var results = new List<int>();
            int difference = 0;
            int smallestDiffence = int.MaxValue;

            //find smallest absolute difference
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                difference = Math.Abs(numbers[i + 1] - numbers[i]);

                //difference is smaller than smallest
                if (difference < smallestDiffence)
                {
                    smallestDiffence = difference;
                    results.Clear();

                    results.Add(numbers[i]);
                    results.Add(numbers[i + 1]);
                }
                //difference is equal to smaller
                else if (difference == smallestDiffence)
                {
                    results.Add(numbers[i]);
                    results.Add(numbers[i + 1]);
                }
            }

            return results.ToArray();
        }
    }
}
