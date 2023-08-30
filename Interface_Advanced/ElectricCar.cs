using System;

namespace Interface_Advanced
{
    public class ElectricCar : IControllableRemotely
    {
        private int correctKeyId = 14;
        //property
        public bool CarOn { get; private set; }
        //methid
        public void StartTheCar(int keyId)
        {
            if (KeyValid(keyId))
            {
                CarOn = true;
                Console.WriteLine("Starting the car...");
            }
            else
            {
                Console.WriteLine("Where are the keys ??");
            }
        }

        public void Drive()
        {
            if (CarOn)
            {
                Console.WriteLine("Car Driving");
            }
            else
            {
                Console.WriteLine("First start the car");
            }
        }
        public void TurnTheCarOff()
        {
            CarOn = false;
            Console.WriteLine("Car is turned off");
        }

        private bool KeyValid(int keyId)
        {
            if (keyId == correctKeyId) return true;
            return false;
        }

        //Implement the method from INterface
        public void ReceiveRemoteCommand(int commandId)
        {
            if (commandId == 10)
            {
                TurnTheCarOff();
            }
            else if (commandId == correctKeyId)
            {
                StartTheCar(commandId);
            }

            else if (commandId == 20)
            {
                Drive();
            }
        }

    }
}