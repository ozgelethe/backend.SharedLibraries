namespace backend.SharedLibraries.Results;

/// <summary>
/// Outcome of an operation that returns a value.
/// </summary>
/// <typeparam name="T">ValueType</typeparam>
public sealed class Result<T> : Result
{
    /// <summary>
    /// 
    /// </summary>
    private readonly T? _value;

    /// <summary>
    /// Returned value; throws on failure.
    /// </summary>
    public T Value
    {
        get
        {
            if (!IsSuccess)
            {
                throw new InvalidOperationException("Cannot access the value of a failed result.");
            }
            return _value!;
        }
    }

    internal Result(T? value, bool isSuccess, ErrorInformation? errorInformation)
        : base(isSuccess, errorInformation)
    {
        _value = value;
    }
}
