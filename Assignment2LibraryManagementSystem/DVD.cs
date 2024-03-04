public class DVD : LibraryItem
{
    public string Director { get; set; }

    public DVD(string title, int year, string director)
        : base(title, year)
    {
        Director = director;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Director: {Director}");
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
