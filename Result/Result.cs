using Newtonsoft.Json;

namespace Patterns.Result;

public class Result
{
    public bool IsSuccess { get; }
    public string? Message { get; }
    public bool IsFailure => !IsSuccess;

    protected Result(bool isSuccess)
    {
        if (!isSuccess)
            throw new InvalidOperationException();
        
        IsSuccess = isSuccess;
        Message = null;
    }
    
    protected Result(bool isSuccess, string message)
    {
        if (isSuccess)
            throw new InvalidOperationException();

        IsSuccess = isSuccess;
        Message = message;
    }

    public static Result Fail(string message)
    {
        return new Result(false, message);
    }

    public static Result<T> Fail<T>(string message)
    {
        return new Result<T>(default(T), false, message);
    }

    public static Result Ok()
    {
        return new Result(true);
    }

    public static Result<T> Ok<T>(T value)
    {
        return new Result<T>(value, true);
    }

    public override string ToString()
        => JsonConvert.SerializeObject(this);
}