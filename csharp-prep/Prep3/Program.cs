using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("Enter magic number: ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess == magicNumber)
            {
                Console.Write($"You guessed it in {guessCount} attempts.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
        }


    }
}