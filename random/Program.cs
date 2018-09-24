using System;
using System.Collections.Generic;


namespace random
{
     class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Console.Clear();
            Console.WriteLine("Shall we play a Game?");
            string answer = Console.ReadLine();
            if (!((answer == "y") || (answer == "Y") || (answer == "yes") || (answer == "Yes") || (answer == "YES")))
            {
                playing = false;
                return;
            }
            else
            {
                while (playing)
                {
                    Random rand = new Random();
                    int randNumber = rand.Next(1, 21);
                    Console.WriteLine("I have selected a whole number between (but not including) 0 and 21.");
                    Console.WriteLine("Enter a whole number below (using digits, not words!) to guess what it is...");
                    string guess = Console.ReadLine();
                    int number;
                    if (Int32.TryParse(guess, out number) && ((number == 0) || (number >= 21)))
                    {

                    }
                }
            }
        }
    }
}
