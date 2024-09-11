namespace CSharp13;

/// <summary>
/// Illustrates the use of the Lock type, which allows
/// </summary>
public class LockObject
{
    // Prior to C# 13, the type of the lock was object
    // Switch to the Lock object for better performance and guardrails
    private readonly Lock _lock = new();
    public void Example()
    {
        lock (_lock)
        {
            // do something
        }
    }
}
