using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");

            //take input from the user and convert it to all upper case
            string userString = Console.ReadLine();
            string userStringUp = userString.ToUpper();

            //print upper case string
            Console.WriteLine(userStringUp);

            //keep program open
            Console.ReadLine();

        }
    }
}
