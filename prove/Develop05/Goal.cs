using System;

class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public virtual void MarkCompleted()
    {
        IsCompleted = true;
    }
}