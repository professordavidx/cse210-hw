using System;
    

public class Book // SUPER CLASS
{
    protected string _author = ""; // PRIVATE = only accessible within this class - PROTECTED is accessible to everything that has been inherited by the super class
    protected string _title = "";

    public Book() // this is a constructor - this will print this information to the terminal (Super Class)
    {
        _author = "Anonymous";
        _title = "Unknown";
    }

    public Book(string author, string title) // this constructor will require the user to provide information when creating a new book
    {
        _author = author;
        _title = title;
    }

// creating a getter 
    public string GetAuthor()
    {
        return _author;
    }
// creating a setter
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetBookInfo()
    {
        return $"{_title} by {_author}";
    }

}