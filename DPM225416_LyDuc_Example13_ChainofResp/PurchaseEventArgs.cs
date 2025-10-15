namespace Chain.NetOptimized;

using System;

// Purchase event argument holds purchase info
public class PurchaseEventArgs : EventArgs
{
    internal Purchase Purchase { get; init; } = null!;
}


