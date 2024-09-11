namespace CSharp13;

class ImplicitIndexer
{
    public static void Main()
    {
        var x = new Numbers
        {
            Values =
            {
                [1] = 111,
                [^1] = 999  // Works starting in C# 13
            }
            // x.Values[1] is 111
            // x.Values[9] is 999, since it is the last element
        };
    }
}

public class Numbers
{
    public int[] Values { get; set; } = new int[10];
}
