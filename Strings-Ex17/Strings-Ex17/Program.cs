using System;

namespace Strings_Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "This is an awesome string";
            Console.WriteLine(RemoveSpaces(givenString));
        }
        //Write a method to remove spaces from a given string.

        public static string RemoveSpaces(string input)
        {
            string replaced = input.Replace(" ", "");

            return replaced;
        }
    }
}
