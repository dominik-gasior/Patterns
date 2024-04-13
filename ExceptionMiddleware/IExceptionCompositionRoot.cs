namespace Patterns.ExceptionMiddleware;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}