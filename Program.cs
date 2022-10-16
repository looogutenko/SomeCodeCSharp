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
            Console.WriteLine(Persistence(999));
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

        public static int DuplicateCount1(string str) => str
            .ToLower()
            .GroupBy(letter => letter)
            .Where(g => g.Count() > 1)
            .Count();

        public static int Persistence(long n)
        {
            int persistence = 0;

            while (n > 9)
            {
                n = Convert.ToString(n)
                .ToCharArray()
                .Select(num => (int) Char.GetNumericValue(num))
                .ToList<int>()
                .Aggregate((x, y) => x * y);

                persistence++;
            }

            return persistence;
        }
      

    }
}
