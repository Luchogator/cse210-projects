
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // AddEntry: Adds a new journal entry to the list.
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // DisplayAll: Displays all journal entries.
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // SaveToFile: Saves the journal entries in CSV format (compatible with Excel).
    // The first line contains the headers "Date,Prompt,Entry".
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Entry"); // Add CSV headers
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.ToString().Replace('|', ',')}"); // Replace separator for CSV format
            }
        }
        Console.WriteLine("Journal saved successfully in CSV format.\n");
    }

    // LoadFromFile: Loads journal entries from a CSV file.
    // It skips the first line if it contains headers.
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        // Skip the header line (if it exists)
        for (int i = 1; i < lines.Length; i++)
        {
            Entry entry = Entry.FromString(lines[i].Replace(',', '|'));
            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded successfully from CSV.\n");
    }

    // SearchEntries: Searches the journal for entries that match a specific date or keyword.
    // This method performs a case-insensitive search.
    public void SearchEntries(string searchQuery)
    {
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry.ToString().Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries match your search.\n");
        }
    }
}
