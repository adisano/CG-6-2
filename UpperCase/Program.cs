using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");

            Console.WriteLine(Console.ReadLine().ToUpper());

            //keep program open
            Console.ReadLine();

        }
    }
}
