namespace Prototype.NetOptimized;

/// <summary>
/// ICloneable is not supported in .NET Core
/// </summary>
public interface ICloneableObject
{
    object Clone();
}

