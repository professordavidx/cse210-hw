using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma",32,23,30);
        Console.WriteLine(reference.singleVerse());
        Console.WriteLine(reference.multipleVerse());
    }
}
