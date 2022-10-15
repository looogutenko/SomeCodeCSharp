using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace SomeCode
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine(DuplicateCount("aabbcde"));
        }



        //15.10.2022
        public static string AlphabetPosition(string text) =>
            string.Join(" ", text
                .ToLower()
                .Where(letter => Char.IsLetter(letter))
                .Select(letter => Convert.ToInt32(letter) - 'a' + 1));



        //16.10.2022
        public static int DuplicateCount(string str)
        {
            List<int> counts = new(str.ToLower().Distinct().Count());

            int count;
            foreach (char UniqueCh in str.ToLower().Distinct())
            {
                count = 0;
                foreach (char Ch in str)
                {
                    if (UniqueCh == Ch)
                    {
                        count++;
                    }
                }
                counts.Add(count);
            }

            return counts
                .Where(count => count > 1)
                .Count();
        }
    }
}
