using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MarsExploration
    {
        /// <summary>
        /// Checks messge for altered characters
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public int Evaluate(string message)
        {
            var messageList = new List<String>();
            var expectedSubstring = "SOS";

            // slicing message into word of 3 characters
            for (int i = 0; i < message.Length; i += 3)
            {
                messageList.Add(message.Substring(i, 3));
            }

            var count = 0;

            // counts the number of altered characters in the message
            foreach (var word in messageList)
            {
                count += compareToSos(word, expectedSubstring);
            }

            return count;
        }

        /// <summary>
        /// Compares characters in two words, and returns a count of the difference
        /// </summary>
        /// <param name="word"></param>
        /// <param name="expectedWord"></param>
        /// <returns></returns>
        private int compareToSos(string word, string expectedWord)
        {
            var counter = 0;
            var expected = expectedWord;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != expected[i])
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}
