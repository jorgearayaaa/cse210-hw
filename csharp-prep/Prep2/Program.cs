using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);

        string letter = "";

        string sign = "";

        if (gradePercent >= 90)
        {
            letter = "A";
            if (gradePercent == 90 || gradePercent == 91 || gradePercent == 92)
            {
                sign = "-"; 
            }
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
            if (gradePercent == 80 || gradePercent == 81 || gradePercent == 82)
            {
                sign = "-"; 
            }
            else if (gradePercent == 87 || gradePercent == 88 || gradePercent == 89)
            {
                sign = "+";
            }
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
            if (gradePercent == 70 || gradePercent == 71 || gradePercent == 72)
            {
                sign = "-"; 
            }
            else if (gradePercent == 77 || gradePercent == 78 || gradePercent == 79)
            {
                sign = "+";
            }
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
            if (gradePercent == 67 || gradePercent == 68 || gradePercent == 69)
            {
                sign = "+";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine();

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (gradePercent >= 70)
        {
            Console.WriteLine("You have passed the class!");
        }
        else
        {
            Console.WriteLine("You did not passed");
        }
    }
}