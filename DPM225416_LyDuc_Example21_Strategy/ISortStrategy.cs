namespace Strategy.NetOptimized;
using System.Collections.Generic;

/// <summary>
/// The 'Strategy' interface
/// </summary>
public interface ISortStrategy
{
    void Sort(List<Student> list);
}
