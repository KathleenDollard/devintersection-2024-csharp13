//using PossibleFuture_Extensions;
//using Scl.Dummy.Api;

//namespace CSharp13;

///// <summary>
///// Air code about how extension types may work. This code 
///// will not compile in C# 13 and this may not be the way
///// the extension implementation works and we may not create them.
///// </summary>
//public implicit extension CliSymbolExtensionType for CliSymbol
//{
//    // Allows static methods and properties
//    public static string[] AvailableAnnotations
//        => [
//        Annotations.Description ];

//    // Allows instance methods and properties
//    public string? Description { get; set; }
//}

//public class ExtensionTypeUsage
//{
//    public void Example()
//    {
//        Console.WriteLine(string.Concat(Environment.NewLine, CliSymbol.AvailableAnnotations));

//        var command = new CliCommand("base");
//        command.Description = "This is the base command";
//        Console.WriteLine(command.Description);
//    }
//}

