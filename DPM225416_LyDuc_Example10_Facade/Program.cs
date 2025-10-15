namespace Facade.NetOptimized;

using static System.Console;

/// <summary>
/// Facade Design Pattern
/// </summary>
public class Program
{
    static void Main()
    {
        // Facade
        var mortgage = new Mortgage();

        // Evaluate mortgage eligibility for customer
        var customer = new Customer("Ann McKinsey");
        bool eligible = mortgage.IsEligible(customer, 125000);

        string result = eligible ? "Approved" : "Rejected";
        WriteLine($"\n{customer.Name} has been {result}");


        // Wait for user
        ReadKey();
    }
}

