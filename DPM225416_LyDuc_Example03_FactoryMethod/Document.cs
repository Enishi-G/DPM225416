namespace Factory.NetOptimized;

/// <summary>
/// The 'Creator' abstract class
/// </summary>
public abstract class Document
{
    // Gets list of document pages
    public List<Page> Pages { get; protected set; } = null!;

    // Factory Method
    public abstract void CreatePages();

    // Override
    public override string ToString() => GetType().Name;
}
