using Scl.Dummy.Api;

namespace PossibleFuture_Extensions;

/// <summary>
/// Review of how extension methods work today
/// </summary>
public static class CliSymbolExtensions
{
    public static void SetDescription(this CliSymbol symbol, string description)
        => Annotations.SetAnnotation(symbol, Annotations.Description, description);

    public static string? GetDescription(this CliSymbol symbol)
        => Annotations.GetAnnotationOrDefault<string>(symbol, Annotations.Description);

    public static void SetRange<T>(this CliSymbol symbol, T lowerBound, T upperBound)
        where T : IComparable<T>
        => Annotations.SetAnnotation(symbol, Annotations.Range, (lowerBound, upperBound));

    public static string? GetRange<T>(this CliSymbol symbol)
        => Annotations.GetAnnotationOrDefault<string>(symbol, Annotations.Description);
}

