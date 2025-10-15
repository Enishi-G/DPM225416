namespace Facade.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Subsystem ClassB' class
/// </summary>
public class Credit
{
    public bool HasGoodCredit(Customer c)
    {
        WriteLine($"Check credit for {c.Name}");
        return true;
    }
}

