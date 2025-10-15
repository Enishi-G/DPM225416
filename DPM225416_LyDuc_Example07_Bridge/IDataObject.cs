namespace Bridge.NetOptimized;

/// <summary>
/// The 'Implementor' interface
/// </summary>
public interface IDataObject<T>
{
    void NextRecord();
    void PriorRecord();
    void AddRecord(T t);
    void DeleteRecord(T t);
    T GetCurrentRecord();
    void ShowRecord();
    void ShowAllRecords();
}

