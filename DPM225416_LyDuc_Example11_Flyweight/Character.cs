namespace Flyweight.NetOptimized;

using static System.Console;

/// <summary>
/// The 'Flyweight' class
/// </summary>
public class Character
{
    protected char symbol;
    protected int width;
    protected int height;
    protected int ascent;
    protected int descent;

    public void Display(int pointSize) =>
       WriteLine($"{symbol} (pointsize {pointSize})");
}

