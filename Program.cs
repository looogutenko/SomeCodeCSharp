using System;

namespace SomeCode
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine(AlphabetPosition("sdfnjksdn"));
        }



        //15.10.2022
        public static string AlphabetPosition(string text) =>
            string.Join(" ", text
                .ToLower()
                .Select(letter => Convert.ToInt32(letter) - 'a' + 1));

    }
}