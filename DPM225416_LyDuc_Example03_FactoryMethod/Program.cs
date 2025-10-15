namespace Factory.NetOptimized;

using static System.Console;

/// <summary>
/// Factory Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        // Document constructors call Factory Method
        List<Document> documents = [new Resume(), new Report()];

        // Display document pages
        foreach (var document in documents)
        {
            document.CreatePages();  // Factory method

            WriteLine($"{document} --");
            foreach (var page in document.Pages) WriteLine($" {page}");
            WriteLine();
        }

        // Wait for user
        ReadKey();
    }
}
