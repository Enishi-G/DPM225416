namespace Chain.NetOptimized;

using static System.Console;

/// <summary>
/// The 'ConcreteHandler' class
/// </summary>
public class VicePresident : Approver
{
    public override void PurchaseHandler(object sender, PurchaseEventArgs e)
    {
        if (e.Purchase.Amount < 25000.0)
        {
            WriteLine("{0} approved request# {1}",
                this.GetType().Name, e.Purchase.Number);
        }
        else
        {
            Successor?.PurchaseHandler(this, e);
        }
    }
}


