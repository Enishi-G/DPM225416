namespace Decorator.NetOptimized;

using static System.Console;

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Book : LibraryItem<Book>
{
    private readonly string author;
    private readonly string title;

    // Constructor
    public Book(string author, string title, int numCopies)
    {
        this.author = author;
        this.title = title;
        NumCopies = numCopies;
    }

    public override void Display()
    {
        WriteLine("\nBook ------ ");
        WriteLine($" Author: {author}");
        WriteLine($" Title: {title}");
        WriteLine($" # Copies: {NumCopies}");
    }
}


