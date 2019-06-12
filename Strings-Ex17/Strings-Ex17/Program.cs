using System;

namespace Strings_Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            string swap = SwapCommaWithDot("Ana, Dan, Remus, Maria.");
            Console.WriteLine(swap);
        }

        //Write a method to swap comma and dot in a string.

        public static string SwapCommaWithDot(string input)
        {
            string result = input.Replace(",", ".");

            return result;
        }
    }
}
