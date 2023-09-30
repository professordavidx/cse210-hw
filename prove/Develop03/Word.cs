using System;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _word;
    private bool _isShown = true;

    public Word(string word)
    {
        _word = word;
        _isShown = true;
    }

    public void ShowWord()
    {
        _isShown = true;
    }
    public void Hide()
    {
        _isShown = false;
    }

    public bool Ishidden()
    {
        return !_isShown;
    }

    public string getWord()
    {
        if (_isShown) {
            return _word;
        }
        else
        {
            string hideWord = new string('_',_word.Length);
            return hideWord;
        }
        

    }
}

