namespace Patterns.ExceptionMiddleware;

public abstract class CustomException : Exception
{
    protected CustomException(string message) : base(message)
    {
    }
}