using System.ComponentModel;

namespace CSharp13;

// This code also requires a generator

// UserCode.cs
public partial class ViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChanged]
    public partial string? UserName { get; set; }
}

// Marker interface that drives generation
[AttributeUsage(AttributeTargets.Property)]
internal class NotifyPropertyChangedAttribute : Attribute
{ }

// Generated.cs
public partial class ViewModel
{
    private string? __generated_userName;

    public partial string? UserName
    {
        get => __generated_userName;
        set
        {
            if (value != __generated_userName)
            {
                __generated_userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }
    }
}
