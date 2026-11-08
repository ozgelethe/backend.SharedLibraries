namespace backend.SharedLibraries.Results;

/// <summary>
/// Represents a field-level validation failure
/// </summary>
public sealed record ValidationError
{
    /// <summary>
    /// Name of the invalid field
    /// </summary>
    public string PropertyName { get; }
    /// <summary>
    /// Validation failure message
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Creates a validation error for a field.
    /// </summary>
    /// <param name="propertyName">PropertyName</param>
    /// <param name="message">Message</param>
    public ValidationError(string propertyName, string message)
    {
        PropertyName = propertyName;
        Message = message;
    }
}