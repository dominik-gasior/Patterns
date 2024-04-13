namespace Patterns.CQRS.Command;

public interface ICommandDispatcher
{
    Task SendAsync<TCommand>(TCommand command) where TCommand : class, ICommand;
}