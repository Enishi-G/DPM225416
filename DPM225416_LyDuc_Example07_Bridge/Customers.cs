namespace Bridge.NetOptimized;

using static System.Console;

/// <summary>
/// The 'RefinedAbstraction' class
/// </summary>
public class Customers(IDataObject<string> dataObject) : CustomersBase(dataObject)
{
    public override void ShowAll()
    {
        // Add separator lines
        WriteLine();
        WriteLine("------------------------");
        base.ShowAll();
        WriteLine("------------------------");
    }
}

