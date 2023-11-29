using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Jacob 3:2");
        Scripture scripture = new Scripture(reference, "O all ye that are pure in heart, lift up your heads and receive the pleasing word of God, and feast upon his alove; for ye may, if your bminds are cfirm, forever.");

        do
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWords();
        } while (!scripture.AllWordsHidden());
    }
}