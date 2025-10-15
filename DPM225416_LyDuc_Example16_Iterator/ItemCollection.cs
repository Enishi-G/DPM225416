namespace Iterator.NetOptimized;

using System.Collections;
using System.Collections.Generic;

/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>
/// <typeparam name="T">Collection item type</typeparam>
public class ItemCollection<T> : IEnumerable<T>
{
    private readonly List<T> items = [];

    public void Add(T t) => items.Add(t);

    // The 'ConcreteIterator'
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }

    public IEnumerable<T> FrontToBack { get => this; }

    public IEnumerable<T> BackToFront
    {
        get
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }
    }

    public IEnumerable<T> FromToStep(int from, int to, int step)
    {
        for (int i = from; i <= to; i += step)
        {
            yield return items[i];
        }
    }

    // Gets number of items
    public int Count { get => items.Count; }

    // System.Collections.IEnumerable member implementation
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

