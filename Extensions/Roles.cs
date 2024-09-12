//using PossibleFuture_Extensions;
//using Scl.Dummy.Api;
//using System.ComponentModel.DataAnnotations;

//namespace PossibleFuture_Extensions;

///// <summary>
///// Air code about how extension types may work. This code 
///// will not compile in C# 13 and this may not be the way
///// the extension implementation works.
///// </summary>
///// <remarks>
///// Generics are messy here because we are not yet clear how
///// they will work.
///// </remarks>
//public explicit extension ComparableSymbol for CliValueSymbol
//{
//    public Range? Range { get; set; }

//    public IEnumerable<string>? ValidateRange<T>(T value)
//        where T : IComparable<T>
//    {
//        if (Range is null)
//        {
//            return null;
//        }
//        // Validate based on range
//    }

//    public static bool TryGetAs(CliValueSymbol valueSymbol,
//                out ComparableSymbol? comparableSymbol)
//    {
//        if (valueSymbol.ValueType.IsAssignableTo(typeof(IComparable)))
//        {
//            comparableSymbol = valueSymbol;
//            return true;
//        }
//        comparableSymbol = null;
//        return false;
//    }
//}

//public class RoleUsage
//{
//    public void Example()
//    {
//        var option = new CliOption("index", typeof(int));

//        // This is a pattern to ensure the type of the 
//        // option or argument is IComparable
//        if (ComparableSymbol.TryGetAs(option, out var comparableSymbol))
//        {
//            comparableSymbol.Range = new Range(1, 42);
//        }

//        // Build rest of CLI tree and parse
//        var result = ParseCliTree();

//        if (comparableSymbol is not null)
//        {
//            comparableSymbol.ValidateRange(result.GetValue(option));
//        }
//    }

//    private Result ParseCliTree()
//    {
//        throw new NotImplementedException();
//    }
//}

//public class Range
//{
//    IComparable LowerBound { get; set; }

//    public Range(IComparable lowerBound, IComparable upperBound)
//    {
//        LowerBound = lowerBound;
//        UpperBound = upperBound;
//    }

//    IComparable UpperBound { get; set; }
//}

//internal class Result
//{
//    internal object GetValue(CliOption option)
//    {
//        throw new NotImplementedException();
//    }
//}