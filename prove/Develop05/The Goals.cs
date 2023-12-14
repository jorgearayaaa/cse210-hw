using System;

class SimpleGoal : Goal
{}

class EternalGoal : Goal
{}

class ChecklistGoal : Goal
{
    public int RequiredTimes { get; set; }
    public int TimesCompleted { get; set; }

    public override void MarkCompleted()
    {
        TimesCompleted++;
        if (TimesCompleted >= RequiredTimes)
        {
            IsCompleted = true;
            Points += 500;
        }
    }
}