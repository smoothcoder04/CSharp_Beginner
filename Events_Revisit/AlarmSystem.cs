using System;

public class AlarmSystem
{
    //method to subscribe to event
    public void Subscribe(TempersatureSensor sensor)
    {
        sensor.TemperatureTooHigh += OnTemperatureTooHigh;
    }

    //event handler method that gets called when the event is raised
    public void OnTemperatureTooHigh(object sender, EventArgs e)
    {
        Console.WriteLine("Alam system: Warning! the temperature is too high!!!");
    }
}