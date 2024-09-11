namespace CSharp13;

public class SomeClass<T, S1, S2>
    where T : allows ref struct
    where S2 : T
{
    //public T Fails { get; set; }
    public S1 Works { get; set; }
    public S2 WorksAlso { get; set; }
}

public class Allow<T> where T : allows ref struct
{}

public class Disallow<T>
{}

public class Example<T> where T : allows ref struct
{
    private Allow<T> fieldOne; // Allowed. T is allowed to be a ref struct

    ////private Disallow<T> fieldTwo; // Error. T is not allowed to be a ref struct
}

// ref struct can be useful for certain types of high perf/low allocations apps, 
// but it requires an investment to use safely, including ensuring that you respond
// to all warnings.
