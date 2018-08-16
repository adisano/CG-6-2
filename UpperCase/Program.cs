using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("Enter a word:");

            //write user input in ALLCAPS
            //(I know this isn't very readable...)
            //(But I am kind of proud of myself for making this program so tiny. :P)
            Console.WriteLine(Console.ReadLine().ToUpper());

            //keep program open
            Console.ReadLine();

        }
    }
}
