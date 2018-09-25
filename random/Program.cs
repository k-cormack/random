using System;
using System.Collections.Generic;


namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Shall we play a Game?");
            string answer = Console.ReadLine();
            if (!((answer == "y") || (answer == "Y") || (answer == "yes") || (answer == "Yes") || (answer == "YES")))
            {
                Console.Clear();
                Console.WriteLine("Thanks Anyway!");
                return;
            }
            else
            {
                bool replay = true;
                while (replay)
                {
                    Console.WriteLine("Great! I have selected a whole number between (but not including) 0 and 21.");
                    Console.WriteLine("Enter a whole number below (using digits, not words!) to guess what it is...");
                    Console.WriteLine("(or enter 'Q' at any time to quit)");
                    Random rand = new Random();
                    int randNumber = rand.Next(1, 101);
                    bool playing = true;
                    int guessCount = 0;
                    while (playing)
                    {
                        string guess = Console.ReadLine();
                        int number;
                        Int32.TryParse(guess, out number);
                        if ((guess == "Q") || (guess == "q"))
                        {
                            Console.Clear();
                            Console.Write("Nobody likes a quitter......");
                            Console.WriteLine("");
                            playing = false;
                            return;
                        }
                        else if ((number < 1) || (number >= 101))
                        {
                            Console.WriteLine("Your guess must be a number 1 to 100");
                        }
                        else if (number > randNumber)
                        {
                            Console.WriteLine("Too high!");
                        }
                        else if (number < randNumber)
                        {
                            Console.WriteLine("Too Low!");
                        }
                        if (number != randNumber)
                        {
                            guessCount++;
                            Console.WriteLine("Guess again!");
                            Console.WriteLine($"Number of Guesses So Far: {guessCount}");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Good job! You are something SPECIAL!!!!");
                            guessCount++;
                            Console.WriteLine($"Total Number of Guesses: {guessCount}");
                            Console.WriteLine("");
                            Console.WriteLine("Play Again?(Y/N)");
                            guess = Console.ReadLine();
                            if ((guess != "y") && (guess != "Y"))
                            {
                                Console.Clear();
                                Console.WriteLine("Thanks for Playing! Bye Felicia!");
                                return;
                            }
                            playing = false;


                        }
                    }
                }
            }
        }
    }
}
