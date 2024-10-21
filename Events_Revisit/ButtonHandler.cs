using System;

public class ButtonHandler
{
    public void Subscribe(Button button)
    {
        button.Clicked += HandleClick;
    }

    //Event handler that responds to clicked event
    private void HandleClick(object sender, EventArgs e)
    {
        Console.WriteLine("ButtonHandler: Button click event received");
    }
}