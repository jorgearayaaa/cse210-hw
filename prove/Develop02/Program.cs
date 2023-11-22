using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Entry: {entry.Content}");
            if (entry.Tags.Count > 0) // It shows the Tags.
            {
            Console.WriteLine("Tags: " + string.Join(", ", entry.Tags));
            }
            Console.WriteLine();
        }
    }
    public void SaveJournal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.Write($"{entry.Date},{entry.Prompt},{entry.Content},");

                if (entry.Tags.Count > 0) // It saves the Tags.
                {
                    outputFile.WriteLine(string.Join("|", entry.Tags));
                }
                else
                {
                    outputFile.WriteLine();
                }
            }
        }
    }
    public void LoadJournal(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string content = parts[2];

                Entry newEntry = new Entry(date, prompt, content);

                if (parts.Length > 3) // It adds the Tags in the Entry.
                {
                    string[] tags = parts[3].Split('|');
                    foreach (var tag in tags)
                    {
                        newEntry.AddTag(tag);
                    }
                }
                _entries.Add(newEntry); // It adds the Entry to the journal.
            }
        }
    }
}