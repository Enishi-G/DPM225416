namespace Interpreter.NetOptimized;

/// <summary>
/// The 'Context' class
/// </summary>
public record Context
{
    public string Input { get; set; } = null!;
    public int Output { get; set; }
}

