using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "Did you achieve the goals you had for today?",
            "What was the the most interesting thing you did today?",
            "How did I see the hand of the Lord in my life today?",
            "Would you change anything you did today?",
            "Did you meet anyone today?"
        };

        Random random = new Random();

        while (true)
        {
            Console.WriteLine("1. Write in your journal");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string randomPrompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("");
                    string entryContent = Console.ReadLine();
                    myJournal.AddEntry(new Entry(DateTime.Now.ToShortDateString(), randomPrompt, entryContent));
                    Console.WriteLine("Add tags to your entry:"); //It is to add tags to the entry.
                    string tagInput = Console.ReadLine();
                    string[] tags = tagInput.Split(',');
                    foreach (var tag in tags)
                    {
                        myJournal._entries[myJournal._entries.Count - 1].AddTag(tag.Trim());
                    }
                    break;

                case 2:
                    Console.WriteLine("Your journal:");
                    myJournal.DisplayEntries();
                    break;

                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveJournal(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadJournal(loadFilename);
                    Console.WriteLine("Journal loaded successfully.");
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}