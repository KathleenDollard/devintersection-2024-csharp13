//namespace PossibleFuture_FieldAccessInProperties;

///// <summary>
///// How we anticipate field access working. This code 
///// will not compile in C# 13.
///// </summary>
//public class FieldAccess
//{
//    public string NameToday { get; set; }

//    // Prior to field access, to trim the above,
//    // you need to make a full property
//    private string name2Today;
//    public string Name2Today
//    {
//        get => name2Today;
//        set
//        {
//            name2Today = value.Trim();
//        }
//    }

//    // Either of both can access the hidden backing field via `field`
//    public string Name2 { get; set => field = value.Trim(); }

//    // This just states what happens with the auto-get.
//    public string Name3 { get => field; set => field = value.Trim(); }

//    /// <summary>
//    /// Another reason to want field access in auto-properties
//    /// </summary>
//    public string Xyz
//    {
//        get;
//        set
//        {
//            if (field == value) return;
//            field = value;
//            OnXyzChanged();
//        }
//    }
//}
