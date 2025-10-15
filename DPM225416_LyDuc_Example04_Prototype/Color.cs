namespace Prototype.NetOptimized;

using static System.Console;
using System.Text.Json;

/// <summary>
/// The 'ConcretePrototype' class
/// </summary>
public class Color : ICloneableObject
{
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    // Returns a shallow or a deep copy
    public object? Clone(bool shallow)
    {
        return shallow ? Clone() : DeepCopy();
    }

    // Creates a shallow copy
    public object Clone()
    {
        WriteLine(
            "Shallow copy of color RGB: {0,3},{1,3},{2,3}",
            Red, Green, Blue);

        return MemberwiseClone();
    }

    // Creates a deep copy
    public object? DeepCopy()
    {
        // use serialized to create a deep copy
        var serialized = JsonSerializer.Serialize(this);
        var copy = JsonSerializer.Deserialize<Color>(serialized);

        if (copy is not null)
        {
            WriteLine(
                "*Deep* copy of color RGB: {0,3},{1,3},{2,3}",
                (copy as Color).Red, (copy as Color).Green, (copy as Color).Blue
            );
        }

        return copy;
    }
}

