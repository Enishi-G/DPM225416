namespace Chain.NetOptimized;

using static System.Console;

/// <summary>
/// The 'ConcreteHandler' class
/// </summary>
public class Director : Approver
{
    public override void PurchaseHandler(object sender, PurchaseEventArgs e)
    {
        if (e.Purchase.Amount < 10000.0)
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


