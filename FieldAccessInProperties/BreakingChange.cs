//namespace PossibleFuture_ExtensionsSCL;

///// <summary>
///// Illustrates impact that `field` within a property now refers to the 
///// </summary>
//public class BreakingChange
//{
//    private string field = "<some value for field>";

//    public BreakingChange(string? name = null)
//    {
//        if (name is not null)
//        {
//            Name = name;
//        }
//    }

//    private string? name;
//    public string? Name
//    {
//        get => name;
//        set
//        {
//            // with this feature, field within a property
//            // refers to the backing field
//            field = value?.Trim();
//            name = value;

//            // To refer to the class level field instead of 
//            // the backing field, use an  `this.` or @ sign
//            this.field = value.Trim();
//        }
//    }

//    public void Output()
//    {
//        var b = new BreakingChange("Kathleen");
//        Console.WriteLine(field);
//        Console.WriteLine(name);
//        Console.WriteLine(Name);
//        // Prior to this change, outputs: "Kathleen" three times
//        // After this change, "<some value for field>", "Kathleen" and "Kathleen"
//    }
//}
