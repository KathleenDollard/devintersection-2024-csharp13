using Scl.Dummy.Api;

namespace PossibleFuture_Extensions;

public class Extensions
{
    // This is how extensions work today as a start to the 
    // discussion of extension types.
    public static void Example()
    {
        var command = new CliCommand("base");
        command.SetDescription("This is the base command");
        Console.WriteLine(command.GetDescription());
    }
}
