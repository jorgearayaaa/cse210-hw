using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 100);

        int guessNumber = 0;
        int count = 0;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            count++;
            
            if (guessNumber > magicNumber)
            {  
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {count} guesses.");
                Console.WriteLine("Do you want to play again? (Yes/No): ");
                string playAgain = Console.ReadLine();

                if (playAgain == "no")
                {
                    Console.Write("Thanks for playing!.");
                }
                else if (playAgain == "yes")
                {
                    magicNumber = randomGenerator.Next(0,100);
                    count = 0;
                }
                else
                {
                   Console.Write("Thanks for playing!."); 
                }
            }
        }
    }
}