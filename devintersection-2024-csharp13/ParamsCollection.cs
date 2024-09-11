namespace CSharp13;

public class ParamsCollection
{
    public static void Output(params IEnumerable<string> strings)
    {
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
    }
}
