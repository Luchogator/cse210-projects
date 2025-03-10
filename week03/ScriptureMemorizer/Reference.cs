
using System;

/// <summary>
/// Represents a scripture reference, including book, chapter, and verses.
/// </summary>
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return _endVerse == -1 
            ? $"{_book} {_chapter}:{_verse}" 
            : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
