using static Microsoft.Maui.Controls.BindableProperty;

namespace GenAlphaMaui.AttachedProperties;

/// <summary>
/// A base BindableProperty to replace the vanilla Maui BindableProperty
/// </summary>
/// <typeparam name="Parent">The parent class to be attached property</typeparam>
/// <typeparam name="Property">The type of this attached property</typeparam>
public abstract class BaseAttachedProperties<Parent, Property>
    where Parent : new()
{
    #region Public Events

    /// <summary>
    /// Fired when the value changes
    /// </summary>
    public event Action<BindableObject, object, object> ValueChanged = (bindable, oldValue, newValue) => { };

    /// <summary>
    /// Fired when the value is updated
    /// </summary>
    public event Action<BindableObject, object> ValueUpdated = (sender, e) => { };

    #endregion

    #region Public Properties

    /// <summary>
    /// A singleton instance of our parent class
    /// </summary>
    public static Parent Instance { get; private set; } = new Parent();

    #endregion

    #region Attached Property Definitions

    public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", 
        typeof(Property), 
        typeof(BaseAttachedProperties<Parent, Property>),
        default(Property),
        propertyChanged: new BindingPropertyChangedDelegate(OnValuePropertyChanged),
        coerceValue: new CoerceValueDelegate(OnValuePropertyUpdated));

    /// <summary>
    /// The callback event when the <see cref="ValueProperty"/> is changed
    /// </summary>
    /// <param name="d">The UI element that has its property changed</param>
    /// <param name="e">The arguments for the event</param>
    public static void OnValuePropertyChanged(BindableObject sender, object oldValue, object newValue)
    {
        //Call the parent function
        (Instance as BaseAttachedProperties<Parent, Property>)?.OnValueChanged(sender, oldValue, newValue);

        //    //call event listeners
        (Instance as BaseAttachedProperties<Parent, Property>)?.ValueChanged(sender, oldValue, newValue);
    }

    /// <summary>
    /// The callback event when the <see cref="ValueProperty"/> is updated even if it is the same value
    /// </summary>
    /// <param name="d">The UI element that has its property updated</param>
    /// <param name="e">The arguments for the event</param>
    public static object OnValuePropertyUpdated(BindableObject sender, object value)
    {
        //Call the parent function
        (Instance as BaseAttachedProperties<Parent, Property>)?.OnValueUpdated(sender, value);

        //call event listeners
        (Instance as BaseAttachedProperties<Parent, Property>)?.ValueUpdated(sender, value);

        return value;
    }

    /// <summary>
    /// Gets the attached property
    /// </summary>
    /// <param name="d">The element to get the property from</param>
    /// <returns></returns>
    public static Property GetValue(BindableObject d) => (Property)d.GetValue(ValueProperty);

    /// <summary>
    /// Sets the attached property
    /// </summary>
    /// <param name="d">The element to get the property from</param>
    /// <param name="value">The value to set the property to</param>
    public static void SetValue(BindableObject d, Property value) => d.SetValue(ValueProperty, value);

    #endregion

    #region Event Methods

    /// <summary>
    /// The method that is called when any attached property of this type is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public virtual void OnValueChanged(BindableObject sender, object oldValue, object newValue) { }

    /// <summary>
    /// The method that is called when any attached property of this type is updated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public virtual void OnValueUpdated(BindableObject sender, object value) { }

    #endregion
}
