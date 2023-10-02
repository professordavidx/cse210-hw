using System;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _word;
    private bool _isShown = true;

    // Create Constructor
    public Word(string word)
    {
        _word = word;
        _isShown = true;
    }
    // This behaviors will make sure to return the word
    public void ShowWord()
    {
        _isShown = true;
    }
    // The word is not longer show in the terminal
    public void Hide()
    {
        _isShown = false;
    }

    public void Show()
    {
        _isShown = true;
    }

    // This behaviors will confirm that the word is already hidden and will no be display in the terminal
    public bool Ishidden()
    {
        return !_isShown;
    }

    public string GetWord()
    {
        if (_isShown) 
        {
            return _word;
        }
        else
        {           // according number characters the underscore will be placed there
            string hideWord = new string('_',_word.Length);
            return hideWord;
        }
        

    }
}

