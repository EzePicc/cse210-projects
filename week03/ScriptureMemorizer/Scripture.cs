using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();
        string[] wordTexts = text.Split(' ');
        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = _random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

}