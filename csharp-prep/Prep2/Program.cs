using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.Write("Please enter your grade: ");
            string grade = Console.ReadLine();
            int number = int.Parse(grade);

            if (number >= 90)
            {
                Console.WriteLine("Your final grade is A. Congratulations on passing this course!!");
            }
            else if (number >= 80)
            {
                Console.WriteLine("Your final grade is B. Congratulations on passing this course!!");
            }
            else if (number >= 70)
            {
                Console.WriteLine("Your final grade is C. Congratulations on passing this course!!");
            }
            else if (number >= 60)
            {
                Console.WriteLine("Your final grade is D. You did not approved this course. Keep trying and don't give up!!");
            }

            else if (number < 60)
            {
                Console.WriteLine("Your final grade is F. You did not approved this course. Keep trying and don't give up!!");
            }
        }
    }
}