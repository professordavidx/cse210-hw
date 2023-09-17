using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        List<int> numbers = new List<int>();
        int sum = 0;


        while (userNumber != 0)
        {
            Console.WriteLine("Enter Number (Press 0 to quit): ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);


            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum} ");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}