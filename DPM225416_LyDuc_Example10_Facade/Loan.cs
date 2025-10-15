namespace Facade.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Subsystem ClassC' class
/// </summary>
public class Loan
{
    public bool HasNoBadLoans(Customer c)
    {
        WriteLine($"Check loans for {c.Name}");
        return true;
    }
}

