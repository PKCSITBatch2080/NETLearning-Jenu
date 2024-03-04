class Program
{
    static void Main()
    {
        Book myBook = new Book("Karnali Blues", 2010, "Buddhisagar");
        myBook.DisplayInfo();
        myBook.BorrowItem("Jenu Oli");
        myBook.DisplayInfo();
        myBook.ReturnItem();
        myBook.DisplayInfo();

        Console.WriteLine();

        DVD myDVD = new DVD("Munamadan", 1936, "Laxmi Prasad Devkota");
        myDVD.DisplayInfo();
        myDVD.BorrowItem("Iliya Fathma");
        myDVD.DisplayInfo();
        myDVD.ReturnItem();
        myDVD.DisplayInfo();
    }
}
