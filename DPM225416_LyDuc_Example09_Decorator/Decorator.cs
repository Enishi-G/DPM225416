namespace Decorator.NetOptimized;

/// <summary>
/// The 'Decorator' abstract class
/// </summary>
public abstract class Decorator<T>(LibraryItem<T> libraryItem) : LibraryItem<T>
{
    public override void Display() => libraryItem.Display();

}


