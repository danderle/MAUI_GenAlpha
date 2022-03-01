using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenAlphaMaui.ViewModels.Base;

/// <summary>
/// A base view model that fires Property Changed events as needed
/// </summary>
public class BaseViewModel : INotifyPropertyChanged
{
    //
    // Summary:
    //     Occurs when property changed.
    public event PropertyChangedEventHandler? PropertyChanged;

    //
    // Summary:
    //     Sets the property.
    //
    // Parameters:
    //   backingStore:
    //     Backing store.
    //
    //   value:
    //     Value.
    //
    //   validateValue:
    //     Validates value.
    //
    //   propertyName:
    //     Property name.
    //
    //   onChanged:
    //     On changed.
    //
    // Type parameters:
    //   T:
    //     The 1st type parameter.
    //
    // Returns:
    //     true, if property was set, false otherwise.
    protected virtual bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action? onChanged = null, Func<T, T, bool>? validateValue = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
        {
            return false;
        }

        if (validateValue != null && !validateValue!(backingStore, value))
        {
            return false;
        }

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }

    //
    // Summary:
    //     Raises the property changed event.
    //
    // Parameters:
    //   propertyName:
    //     Property name.
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
