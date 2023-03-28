namespace GeometricFun.Figures.Errors;

internal sealed class Error
{
    internal static readonly Error None = new(string.Empty, string.Empty);
    internal static readonly Error NullValue = new("Error.NullValue", "The specified result value is null.");

    internal Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    internal string Code { get; }

    internal string Message { get; }
}