namespace Prototype.NetOptimized;

using System.Collections.Generic;

/// <summary>
/// Type-safe prototype manager
/// </summary>
public record ColorManager
{
    private readonly Dictionary<ColorType, Color> colors = [];

    // Gets or sets color
    public Color this[ColorType type]
    {
        get => colors[type];
        set => colors.Add(type, value);
    }
}

