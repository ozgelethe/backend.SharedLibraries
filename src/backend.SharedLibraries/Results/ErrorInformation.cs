using backend.SharedLibraries.Results.Enums;

namespace backend.SharedLibraries.Results;

/// <summary>
/// Error record that encapsulates error information.
/// </summary>
public sealed record ErrorInformation
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public string Code { get; }
    /// <summary>
    /// Human-readable error message
    /// </summary>
    public string Message { get; }
    /// <summary>
    /// Error category
    /// </summary>
    public ErrorType Type { get; }

    /// <summary>
    /// Field-level validation failures.
    /// </summary>
    public IReadOnlyList<ValidationError> ValidationErrors { get; }

    private ErrorInformation(
        string code,
        string message,
        ErrorType type,
        IReadOnlyList<ValidationError>? validationErrors = null)
    {
        Code = code;
        Message = message;
        Type = type;
        ValidationErrors = validationErrors ?? [];
    }

    /// <summary>
    /// Creates a general failure error.
    /// </summary>
    /// <param name="code">Error code.</param>
    /// <param name="message">Error message.</param>
    public static ErrorInformation Failure(string code, string message)
    {
        return new(code, message, ErrorType.Failure);
    }

    /// <summary>
    /// Creates a validation error.
    /// </summary>
    /// <param name="code">Error code.</param>
    /// <param name="message">Error message.</param>
    public static ErrorInformation Validation(string code, string message)
    {
        return new(code, message, ErrorType.Validation);
    }

    /// <summary>
    /// Creates a validation error with field-level failures.
    /// </summary>
    /// <param name="code">Error code</param>
    /// <param name="message">Error message</param>
    /// <param name="validationErrors">ValidationErrors</param>
    public static ErrorInformation Validation(string code, string message, IReadOnlyList<ValidationError> validationErrors)
    {
        return new(code, message, ErrorType.Validation, validationErrors);
    }

    /// <summary>
    /// Creates an unauthorized error.
    /// </summary>
    /// <param name="code">Error code.</param>
    /// <param name="message">Error message.</param>
    public static ErrorInformation Unauthorized(string code, string message)
    {
        return new(code, message, ErrorType.Unauthorized);
    }

    /// <summary>
    /// Creates a forbidden error.
    /// </summary>
    /// <param name="code">Error code.</param>
    /// <param name="message">Error message.</param>
    public static ErrorInformation Forbidden(string code, string message)
    {
        return new(code, message, ErrorType.Forbidden);
    }

    /// <summary>
    /// Creates a not found error.
    /// </summary>
    /// <param name="code">Error code.</param>
    /// <param name="message">Error message.</param>
    public static ErrorInformation NotFound(string code, string message)
    {
        return new(code, message, ErrorType.NotFound);
    }

    /// <summary>
    /// Creates a conflict error.
    /// </summary>
    /// <param name="code">Error code.</param>
    /// <param name="message">Error message.</param>
    public static ErrorInformation Conflict(string code, string message)
    {
        return new(code, message, ErrorType.Conflict);
    }

    /// <summary>
    /// Creates an unexpected error.
    /// </summary>
    /// <param name="code">Error code</param>
    /// <param name="message">Error message</param>
    public static ErrorInformation Unexpected(string code, string message)
    {
        return new(code, message, ErrorType.Unexpected);
    }


}
