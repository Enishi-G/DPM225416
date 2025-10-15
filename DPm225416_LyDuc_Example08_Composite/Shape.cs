namespace Composite.NetOptimized;

using System;

/// <summary>
/// Shape class
/// <remarks>
/// Implements generic IComparable interface
/// </remarks>
/// </summary>
public class Shape(string name) : IComparable<Shape>
{
    public override string ToString() => name;

    // IComparable<Shape> Member
    public int CompareTo(Shape? other) => (this == other) ? 0 : -1;
}


