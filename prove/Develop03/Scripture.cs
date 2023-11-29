using System;

public class Scripture
{
    private Reference _scriptureReference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _scriptureReference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_scriptureReference.GetReference()}");
        foreach (var word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count / 2);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}