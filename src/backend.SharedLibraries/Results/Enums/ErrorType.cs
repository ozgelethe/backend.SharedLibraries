namespace backend.SharedLibraries.Results.Enums;

/// <summary>
/// Error categories mapped to HTTP status codes.
/// </summary>
public enum ErrorType
{
    /// <summary>
    /// General business rule failure.
    /// </summary>
    Failure = 1,
    /// <summary>
    /// Invalid input.
    /// </summary>
    Validation = 2,
    /// <summary>
    /// Caller is not authenticated.
    /// </summary>
    Unauthorized = 3,
    /// <summary>
    /// Caller lacks permission.
    /// </summary>
    Forbidden = 4,
    /// <summary>
    /// Requested resource does not exist.
    /// </summary>
    NotFound = 5,
    /// <summary>
    /// Conflicts with the current resource state.
    /// </summary>
    Conflict = 6,
    /// <summary>
    /// Unhandled server error.
    /// </summary>
    Unexpected = 7,
}
