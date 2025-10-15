namespace Decorator.NetOptimized;

using static System.Console;

/// <summary>
/// The 'ConcreteDecorator' class
/// </summary>
public class Borrowable<T> : Decorator<T>
{
    private readonly List<string> borrowers = [];

    // Constructor
    public Borrowable(LibraryItem<T> libraryItem)
        : base(libraryItem)
    {
    }

    public void BorrowItem(string name)
    {
        borrowers.Add(name);
        NumCopies--;
    }

    public void ReturnItem(string name)
    {
        borrowers.Remove(name);
        NumCopies++;
    }

    public override void Display()
    {
        base.Display();
        borrowers.ForEach(b => WriteLine(" borrower: " + b));
    }
}


