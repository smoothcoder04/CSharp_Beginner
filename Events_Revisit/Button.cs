using System;

public class Button
{
    //declare event called click
    public event EventHandler Clicked;

    //method to simulate button click
    public void Press()
    {
        Console.WriteLine("Button : Button was pressed");
        //raise the clicked event. this is just another method
        OnClicked();
    }
    protected virtual void OnClicked()
    {
        //raise the event only when there are subscribers
        Clicked.Invoke(this, EventArgs.Empty);
    }
}