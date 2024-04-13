namespace Patterns.ExceptionMiddleware;

public interface IExceptionToResponseMapper
{
    ExceptionResponse Map(Exception exception);
}