using System;
using System.IO.Pipes;

namespace cupgame2
{
    class program
    {
        static void Main(string[] args)
        {
            bool playagain = true;
            bool correctguess = false;
            Random rnd = new Random();
            int randomnum = rnd.Next(1,4);
            int score = 0;
            String ans;
            int coin;

            Console.WriteLine("Enter coins: ");
            coin = Convert.ToInt32(Console.ReadLine());

            while (!correctguess)
            {
                if (coin <= 9999999999999)
                {
                    coin -= 1;
                }

                Console.WriteLine("|-----------|        |-----------|        |-----------|");
                Console.WriteLine("|-----------|        |-----------|        |           |");
                Console.WriteLine("|-----------|        |-----------|        |           |");
                Console.WriteLine("|-----------|        |-----------|        |           |");
                Console.WriteLine("|-----------|        |-----------|        |           |");
                Console.WriteLine("|-----1-----|        |-----2-----|        |     3     |");


                while (!correctguess)
                {
                    
                    Console.Write("Choose a cup: ");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > randomnum)
                    {
                        Console.WriteLine("Wrong cup, better luck next time.");
                    }
                    else if (guess < randomnum)
                    {
                        Console.WriteLine("Wrong cup, better luck next time.");
                    }
                    else
                    {
                        Console.WriteLine("Right cup, you've earned 10 tickets!");
                        correctguess = true;
                        score += 10;
                        Console.WriteLine("Tickets: " + score);
                    }
                    Console.Write("Would you like to play again? (Y/N):");
                    ans = Console.ReadLine();
                    ans = ans.ToUpper();

                    if (ans == "Y" )
                    {
                        playagain = true;
                    }
                    else
                    {
                        playagain = false;
                    }
                }
               
            }

            Console.ReadKey();

        }
    }
}
