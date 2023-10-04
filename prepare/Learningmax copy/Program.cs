using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A great book");

        Console.WriteLine(book1.GetBookInfo());

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Jones");
        book2.SetTitle("A beautiful Picture Book");
        book2.SetIllustrator("Burton");

        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Edwards","Just another book");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Casio","World","Coco");
        Console.WriteLine(book4.GetBookInfo());

    }
}