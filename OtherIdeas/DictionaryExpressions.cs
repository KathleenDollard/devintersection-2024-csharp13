//namespace PossibleFuture_OtherIdeas;

///// <summary>
///// Air code about how dictionary expressions may work. This code 
///// will not compile in C# 13 and this may not be the way
///// the extension implementation works, and we may not create them.
///// </summary>   
//public class DictionaryExpressions
//{
//    public void Example()
//    {
//        var folks Dictionary<string, int> _nameToAge = 
//            [
//                "Kathleen": 21,
//                "Dustin": 22,
//                "Mads": 23,
//            ];
//        Console.WriteLine(string.Join(Environment.NewLine,
//            _nameToAge
//                .Select(x => $"{x.Key} is {x.Value}")));
//    }
//}
