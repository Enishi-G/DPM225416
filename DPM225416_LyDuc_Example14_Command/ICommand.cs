namespace Command.NetOptimized;

/// <summary>
/// The 'Command' interface
/// </summary>
public interface ICommand
{
    void Execute();
    void UnExecute();
}
