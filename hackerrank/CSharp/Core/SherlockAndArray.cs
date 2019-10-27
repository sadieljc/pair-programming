using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SherlockAndArray
    {
        public string BalancedSum(List<int> arr)
        {
            var length = arr.Count;

            for (int i = 0; i < length; i++)
            {
                var left = 0;
                var right = 0;
                //left
                for (int j = 0; j < i; j++)
                {
                    left += arr[j];
                }
                //right
                for (int k = i + 1; k < length; k++)
                {
                    right += arr[k];
                }

                if (right == left) return "YES";
            }

            return "NO";
        }
    }
}
