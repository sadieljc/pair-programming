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
                //int T = Convert.ToInt32(reader.ReadLine().Trim());

                //for (int TItr = 0; TItr < T; TItr++)
                //{
                    //int n = Convert.ToInt32(reader.ReadLine().Trim());

                    bigList = reader.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                var sut = new SherlockAndArray();
                string result = sut.BalancedSum(bigList);

                Console.WriteLine(result);
                    //textWriter.WriteLine(result);
                //}
            }

            System.Console.ReadLine();
        }
    }
}


