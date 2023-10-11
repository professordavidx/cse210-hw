using System;
using Learning05;


class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red",4);
        Console.WriteLine(square1.GetArea());
        Console.WriteLine(square1.GetColor());
    }

}
