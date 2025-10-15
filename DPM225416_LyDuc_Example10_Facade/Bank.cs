namespace Facade.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Subsystem ClassA' class
/// </summary>
public class Bank
{
    public bool HasSufficientSavings(Customer c, int amount)
    {
        WriteLine($"Check bank for {c.Name}");
        return true;
    }
}

