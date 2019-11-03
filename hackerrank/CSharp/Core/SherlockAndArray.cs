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
            var left = 0;
            var sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
            }

            for (int i = 0; i < length; i++)
            {
                sum -= arr[i];

                if (left == sum)
                {
                    return "YES";
                }

                left += arr[i];                
            }

            return "NO";
        }
    }
}
