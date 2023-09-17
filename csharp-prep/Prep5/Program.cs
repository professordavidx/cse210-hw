using System;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayName();
            string userName = PromptUserName();

            int favoriteNum = PromptUserNumber();

            int square = Squared(favoriteNum);

            DisplayResult(userName, square);



        }

        static void DisplayName()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string response = Console.ReadLine();
            return response;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int Squared(int favoriteNumber)
        {
            int result = favoriteNumber * favoriteNumber;
            return result;
        }

        static void DisplayResult(string response, int result)
        {
            Console.WriteLine($"{response}, the square of your number is {result}");
        }

    }
}