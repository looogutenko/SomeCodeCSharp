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
            Console.WriteLine(AlphabetPosition("sdfnjks dn"));
        }

        //15.10.2022
        public static string AlphabetPosition(string text) =>
            string.Join(" ", text
                .ToLower()
                .Where(letter => letter != ' ')
                .Select(letter => Convert.ToInt32(letter) - 'a' + 1));
    }
}
