using System;

// Define a delegate for the property changed event
public delegate void PropertyChangedEventHandler<T>(T newValue);

public class ReactiveProperty<T> : IDisposable
{
    private T _value;

    private event PropertyChangedEventHandler<T> PropertyChanged;

    // Define a property with a custom setter to trigger the event
    public T Value
    {
        get { return _value; }
        set
        {
            if (!_value.Equals(value))
            {
                _value = value;

                // Trigger the property changed event
                OnPropertyChanged(_value);
            }
        }
    }

    // Custom method to invoke the property changed event
    protected virtual void OnPropertyChanged(T newValue)
    {
        PropertyChanged?.Invoke(newValue);
    }

    // Method to subscribe to the property changed event
    public void Subscribe(PropertyChangedEventHandler<T> subscriber)
    {
        PropertyChanged += subscriber;
    }

    // Method to unsubscribe from the property changed event
    public void Unsubscribe(PropertyChangedEventHandler<T> subscriber)
    {
        PropertyChanged -= subscriber;
    }

    // Implement IDisposable interface
    public void Dispose()
    {
        // Unsubscribe all listeners when the object is disposed
        PropertyChanged = null;
    }
}