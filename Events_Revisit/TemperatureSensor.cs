using System;

public class TempersatureSensor
{
    //declare the event
    public event EventHandler TemperatureTooHigh;

    private int _temperature;

    //method to see the tempersature and check the threshold
    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
        Console.WriteLine($"Sensor: current tempaerature is {_temperature}C");

        //if temp is greater than 45, raise event
        if(_temperature > 45)
        {
            OnTemperatureTooHigh(EventArgs.Empty);
        }
    }

    protected virtual void OnTemperatureTooHigh(EventArgs e)
    {
        TemperatureTooHigh?.Invoke(this, e);
    }

}