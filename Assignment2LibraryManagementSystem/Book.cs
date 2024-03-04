public class Book : LibraryItem
{
    public string Author { get; set; }

    public Book(string title, int year, string author)
        : base(title, year)
    {
        Author = author;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Author}");
    }

    public override void BorrowItem(string borrower)
    {
        if (IsAvailable)
        {
            Console.WriteLine($"{Title} has been borrowed by {borrower}.");
            IsAvailable = false;
        }
        else
        {
            Console.WriteLine($"{Title} is not available for borrowing.");
        }
    }

    public override void ReturnItem()
    {
        Console.WriteLine($"{Title} has been returned.");
        IsAvailable = true;
    }
}
