namespace Factory.NetOptimized;

/// <summary>
/// The 'Product' abstract class
/// </summary>
public abstract class Page
{
    // Override. Display class name
    public override string ToString() => GetType().Name;
}
