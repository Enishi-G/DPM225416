namespace Mediator.NetOptimized;

/// <summary>
/// The 'Mediator' interface
/// </summary>
public interface IChatroom
{
    void Register(Participant participant);
    void Send(string from, string to, string message);
}
