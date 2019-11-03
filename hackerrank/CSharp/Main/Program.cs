using Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bigList = new List<int>();

            using (var reader = new StreamReader("..\\..\\SherlockAndArray\\TestCase3_oneLine.txt"))
            {
                bigList = reader.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                var sut = new SherlockAndArray();

                var start = DateTime.Now;
                Console.WriteLine(start);

                string result = sut.BalancedSum(bigList);
                Console.WriteLine(result);

                var end = DateTime.Now;
                Console.WriteLine(end);

                var difference = end.Subtract(start);
                Console.WriteLine(difference.TotalSeconds);                
            }

            System.Console.ReadLine();
        }
    }
}


