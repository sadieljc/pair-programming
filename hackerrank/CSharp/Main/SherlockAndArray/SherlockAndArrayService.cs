using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Main.SherlockAndArray
{
    public class SherlockAndArrayService
    {
        public void Execute(string path)
        {
            var bigList = new List<int>();

            using (var reader = new StreamReader(path))
            {
                bigList = reader.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                var sut = new Core.SherlockAndArray();

                var start = DateTime.Now;
                Console.WriteLine(start);

                string result = sut.BalancedSum(bigList);
                Console.WriteLine(result);

                var end = DateTime.Now;
                Console.WriteLine(end);

                var difference = end.Subtract(start);
                Console.WriteLine(difference.TotalSeconds);
            }

            Console.ReadLine();
        }
    }
}