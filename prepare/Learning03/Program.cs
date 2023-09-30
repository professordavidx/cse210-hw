using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1.GetFractionToString());
        // Fraction f2 = new Fraction();
        // Console.WriteLine(f2.GetDecimalResult());

        // Fraction f3 = new Fraction(4);
        // Console.WriteLine(f3.GetFractionToString());
        // Fraction f4 = new Fraction();
        // Console.WriteLine(f4.GetDecimalResult());

        Fraction f5 = new Fraction(3 , 4);
        Console.WriteLine(f5.GetFractionToString());
        Fraction f6 = new Fraction();
        Console.WriteLine(f6.GetDecimalResult());


    }

}