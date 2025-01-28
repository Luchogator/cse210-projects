
using System;
using System.Collections.Generic;

/// <summary>
/// Represents a scripture with a reference and its associated text, broken into words.
/// </summary>
public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public void RevealHint()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                word.Reveal();
                break;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{Reference.GetDisplayText()}\n{string.Join(' ', displayWords)}";
    }
}
