namespace Patterns.Result;

public class Result<T> : Result
{
    public T Value { get; }

    protected internal Result(T value, bool isSuccess)
        : base(isSuccess)
    {
        Value = value;
    }
    
    protected internal Result(T value, bool isSuccess, string? message)
        : base(isSuccess, message)
    {
        Value = value;
    }
}