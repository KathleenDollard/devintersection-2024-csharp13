namespace CSharp13;

public class EscapeESC
{
    public static void Example()
    {
        Console.WriteLine("Hello (\x001b[91mWorld\x001b[0m)");
        Console.WriteLine("Hello (\e[91mWorld\e[0m)");
    }
}
