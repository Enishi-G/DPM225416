namespace Flyweight.NetOptimized;

/// <summary>
/// A 'ConcreteFlyweight' class
/// </summary>
public class CharacterA : Character
{
    // Constructor
    public CharacterA()
    {
        symbol = 'A';
        height = 100;
        width = 120;
        ascent = 70;
        descent = 0;
    }
}

