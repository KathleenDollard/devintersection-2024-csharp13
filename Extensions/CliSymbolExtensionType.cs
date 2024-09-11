//using Extensions;
//using ExtensionsSCL;

//namespace CSharp13;

///// <summary>
///// Air code about how extension types may work. This code 
///// will not compile in C# 13 and this may not be the way
///// the extension implementation works and we may not create them.
///// </summary>
//public implicit extension CliSymbolExtensionType for CliSymbol
//{
//    public static string[] AvailableAnnotations
//    => [
//        Annotations.Description    ];
//    public string? Description { get; set; }
//}

//public class ExtensionTypeUsage
//{
//    public void Example()
//    {
//        Console.WriteLine(string.Concat(Environment.NewLine, CliSymbol.AvailableAnnotations));

//        var command = new CliCommand("base");
//        command.SetDescription("This is the base command");
//        Console.WriteLine(command.Description);
//    }
//}
    
