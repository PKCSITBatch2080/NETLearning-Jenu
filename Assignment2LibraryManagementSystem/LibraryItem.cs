using System;
public abstract class LibraryItem : IBorrowable
{
    public string Title { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; protected set; }

    public LibraryItem(string title, int year)
    {
        Title = title;
        Year = year;
        IsAvailable = true;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
    }

    public abstract void BorrowItem(string borrower);

    public abstract void ReturnItem();
}
