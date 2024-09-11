using Scl.Dummy.Api;

namespace PossibleFuture_Extensions;

internal class Annotations
{
    internal const string Description = "description";
    internal const string Range = "range";

    // Since it is a library that will be used in unknown ways,
    // the actual System.CommandLine uses a strongly weak table
    // which is an advanced feature. The strongly typed weak table
    // can release references to allow GC of items. For multi-threaded
    // use, the store needs to be locked on write.
    private static Dictionary<(object parent, string key), object> _annotations = new();

    public static void SetAnnotation(CliSymbol symbol, string key, object value)
        => _annotations[(symbol,key)] = value;

    public static T? GetAnnotationOrDefault<T>(CliSymbol symbol, string key)
        => _annotations.TryGetValue((symbol, key), out var value)
                ? (T)value
                : default;
}
