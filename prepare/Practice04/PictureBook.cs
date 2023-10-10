using System;

public class PictureBook : Book // we inherit author and the title variable from the super class.
 
{
    private string _illustrator = "";

    public PictureBook(): base()
    {

    }

    public PictureBook(string author, string title, string illustrator): base(author,title) // by using the word base we can pass info from another constructor
    {
        _illustrator = illustrator;
    }

    public string GetIllustrator() // getter
    {
        return _illustrator;
    }   

    public void SetIllustrator(string illustrator) //setter
    {
        _illustrator = illustrator;
    }

    public string GetPictureBookInfo()
    {
        return $"{_title} by {_author} illustrated by {_illustrator}";
    }


}