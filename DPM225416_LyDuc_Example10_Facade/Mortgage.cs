namespace Facade.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Facade' class
/// </summary>
public class Mortgage
{
    private readonly Bank bank = new();
    private readonly Loan loan = new();
    private readonly Credit credit = new();

    public bool IsEligible(Customer cust, int amount)
    {
        WriteLine("{0} applies for {1:C} loan\n",
            cust.Name, amount);

        bool eligible = true;

        // Check creditworthyness of applicant
        if (!bank.HasSufficientSavings(cust, amount))
        {
            eligible = false;
        }
        else if (!loan.HasNoBadLoans(cust))
        {
            eligible = false;
        }
        else if (!credit.HasGoodCredit(cust))
        {
            eligible = false;
        }

        return eligible;
    }
}

