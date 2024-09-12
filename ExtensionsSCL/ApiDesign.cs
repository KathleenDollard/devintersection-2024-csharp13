

namespace Scl.Dummy.Api;

// Basic architecture:
//    Strict separation between parsing concerns - POSIX that will never change
//    along with flexibility to handle Windows idioms. This assembly understands
//    these concepts and a few others, like the number of items that can be entered.
//
//    These assemblies will be owned by different teams.
public abstract class CliSymbol
{
    public string Name { get; }
    public string[] Aliases { get; }

    protected CliSymbol(string name, params string[] aliases)
    {
        Name = name;
        Aliases = aliases;
    }
}
public abstract class CliValueSymbol : CliSymbol
{
    public Type ValueType { get; }
    protected CliValueSymbol(string name, Type valueType, params string[] aliases)
        : base(name, aliases)
    {
        ValueType = valueType;
    }
}
public class CliCommand : CliSymbol
{
    public CliCommand(string name, params string[] aliases)
        : base(name, aliases) { }
}

// Options and arguments are generic to the type they accept 
// in the real System.CommandLine, but that added complexity 
// to this example.
public class CliOption : CliValueSymbol
{
    public CliOption(string name, Type valueType, params string[] aliases)
        : base(name, valueType, aliases) { }
}
public class CliArgument : CliValueSymbol
{
    public CliArgument(string name, Type valueType, params string[] aliases)
        : base(name, valueType, aliases) { }
}

//public class SclExampleNullable
//{
//    public SclExampleNullable()
//    {
//        _arguments = new();
//        _options = new();
//        _subcommands = new();
//        _otherValueSymbols = new();
//    }
//    public void Add(CliSymbol symbol)
//    {
//        var _ = symbol switch
//        {
//            CliArgument argument => AddArgument(argument),
//            CliOption option => AddOption(option),
//            CliCommand command => AddSubCommand(command),
//            CliValueSymbol valueSymbol => AddOtherSymbol(valueSymbol),
//            _ => throw new InvalidOperationException("Unexpected symbol type"),
//        };
//    }

//    public void Add(CliArgument argument) => AddArgument(argument);
//    public void Add(CliOption option) => AddOption(option);
//    public void Add(CliCommand command) => AddSubCommand(command);

//    private List<CliArgument> _arguments;
//    public IEnumerable<CliArgument> Arguments => _arguments;
//    private Discard AddArgument(CliArgument argument)
//    {
//        _arguments.Add(argument);
//        return Discard.Empty;
//    }

//    private List<CliOption> _options;
//    public IEnumerable<CliOption> Options => _options;
//    private Discard AddOption(CliOption option)
//    {
//        _options.Add(option);
//        return Discard.Empty;
//    }

//    private List<CliValueSymbol> _otherValueSymbols;
//    public IEnumerable<CliValueSymbol> OtherSymbols => _otherValueSymbols;
//    private Discard AddOtherSymbol(CliValueSymbol valueSymbol)
//    {
//        _otherValueSymbols.Add(valueSymbol);
//        return Discard.Empty;
//    }

//    private List<CliCommand> _subcommands;
//    public IEnumerable<CliCommand> Subcommands => _subcommands;
//    private Discard AddSubCommand(CliCommand subcommand)
//    {
//        _subcommands.Add(subcommand);
//        return Discard.Empty;
//    }


//}
