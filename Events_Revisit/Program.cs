// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//create publisher and subscriber
Button button = new Button();
ButtonHandler handler = new ButtonHandler();

TempersatureSensor sensor = new TempersatureSensor();
AlarmSystem alarm = new AlarmSystem();


//subscribe to button clicked event
handler.Subscribe(button);
alarm.Subscribe(sensor);

//simulate pressing button
button.Press();
sensor.SetTemperature(10);
sensor.SetTemperature(55);
