namespace Chain.NetOptimized;

using static System.Console;

/// <summary>
/// The 'ConcreteHandler' clas
/// </summary>
public class President : Approver
{
    public override void PurchaseHandler(object sender, PurchaseEventArgs e)
    {
        if (e.Purchase.Amount < 100000.0)
        {
            WriteLine("{0} approved request# {1}",
                sender.GetType().Name, e.Purchase.Number);
        }
        else if (Successor != null)
        {
            Successor.PurchaseHandler(this, e);
        }
        else
        {
            WriteLine(
                "Request# {0} requires an executive meeting!",
                e.Purchase.Number);
        }
    }
}


