using Scl.Dummy.Api;
using System;

//namespace Extensions;

///// <summary>
///// Air code about how extension types may work. This code 
///// will not compile in C# 13 and this may not be the way
///// the extension implementation works and we may not create them.
///// </summary>
//// We are considering dropping the word "implicit" for implicit extensions
//public implicit extension ExtensionTypesWithInterfaces for CliSymbol
//    : IParsable<CliSymbol>
//{
//    static CliSymbol? IParsable<CliSymbol>.Parse(string s) ​
//        => TryParse(s, out CliSymbol symbol)
//            ? symbol
//            : default;

//    }

//    static bool IParsable<CliSymbol>.TryParse(string? s, IFormatProvider? provider, out CliSymbol result)
//    {
//        // if we can read the JSON, return the JSON
//    }
//}
