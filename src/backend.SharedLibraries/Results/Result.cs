using System.Diagnostics.CodeAnalysis;

namespace backend.SharedLibraries.Results;

/// <summary>
/// Outcome of an operation without a return value.
/// </summary>
public class Result
{
    /// <summary>
    /// Whether the operation succeeded.
    /// </summary>
    [MemberNotNullWhen(false, nameof(ErrorInformation))]
    public bool IsSuccess { get; }
    /// <summary>
    /// Error details, null on success.
    /// </summary>
    public ErrorInformation? ErrorInformation { get; }

    /// <summary>
    /// Outcome of an operation without a return value.
    /// </summary>
    /// <param name="isSuccess"></param>
    /// <param name="errorInformation"></param>
    protected Result(bool isSuccess, ErrorInformation? errorInformation)
    {
        if (isSuccess && errorInformation is not null)
        {
            throw new ArgumentException("A successful result cannot have an error.", nameof(errorInformation));
        }

        if (!isSuccess && errorInformation is null)
        {
            throw new ArgumentException("A failed result must have an error.", nameof(errorInformation));
        }

        IsSuccess = isSuccess;
        ErrorInformation = errorInformation;
    }

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    public static Result Success()
    {
        return new(true, null);
    }

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    /// <param name="errorInformation">Error details.</param>
    public static Result Failure(ErrorInformation errorInformation)
    {
        return new(false, errorInformation);
    }
}
