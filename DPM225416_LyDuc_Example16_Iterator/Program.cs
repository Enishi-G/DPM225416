namespace Iterator.NetOptimized;

using static System.Console;

/// <summary>
/// Iterator Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create and item collection
        ItemCollection<Item> items = [
                new("Item 0"),
                new("Item 1"),
                new("Item 2"),
                new("Item 3"),
                new("Item 4"),
                new("Item 5"),
                new("Item 6"),
                new("Item 7"),
                new("Item 8")
              ];

        WriteLine("Iterate front to back");
        foreach (var item in items)
        {
            WriteLine(item.Name);
        }

        WriteLine("\nIterate back to front");
        foreach (var item in items.BackToFront)
        {
            WriteLine(item.Name);
        }
        WriteLine();

        // Iterate given range and step over even ones
        WriteLine("\nIterate range (1-7) in steps of 2");
        foreach (var item in items.FromToStep(1, 7, 2))
        {
            WriteLine(item.Name);
        }
        WriteLine();

        // Wait for user
        ReadKey();
    }
}

