using System;
using System.Collections.Generic;
// This class will keep track of the refrence and the text of the scripture. Can hide words and get the rendered display of the text
public class Scripture
{
    private string _reference;
    
    private List<Word> _words = new List<Word>();
    // create a list that takes objects coming from the word class
    public Scripture(string reference , string textofscripture)
    {
        _reference = reference;
        string[] wordList = textofscripture.Split(" ");

        foreach (string word in wordList)
        {
            Word oneWord = new Word(word);
            _words.Add(oneWord);
        }
    }
    
    public void hideWords()
    {
        Random r = new Random();
        int pendingToHide = r.Next(2, 4);
        int countHiddenWords = 0;

        // keep hiding words until countHiddenWords is bigger than pendingToHide
        while (countHiddenWords < pendingToHide)
        {
            int rIndex = r.Next(_words.Count);
            // hide the word if its not already hidden
            if (!_words[rIndex].Ishidden())
            {
                _words[rIndex].Hide();
                countHiddenWords++;
            } 
            
        }
        // clear console and display the scripture in the terminal
        Console.Clear();
        getRenderText();
    }

    // get scripture text with words already hidden
    public void getRenderText()
    {
        Console.Write($"{_reference} ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");

        } 
    }

    // Confirm if each  word is already hidden

    public bool completelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Ishidden())
            {
                return false;
            }
        
        }
        return true;
    }

}


