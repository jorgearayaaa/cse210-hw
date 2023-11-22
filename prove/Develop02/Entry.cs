using System;

class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Content { get; }
    public List<string> Tags { get; }

    public Entry(string date, string prompt, string content)
    {
        Date = date;
        Prompt = prompt;
        Content = content;
        Tags = new List<string>(); // It starts the list of tags when a new entry is made.
    }
    public void AddTag(string tag) //It adds a new tag to the entry.
    {
        Tags.Add(tag);
    }
}