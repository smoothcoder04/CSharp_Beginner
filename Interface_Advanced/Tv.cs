using System;

namespace Interface_Advanced
{
    public class Tv
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Turning the TV on... ");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("TV is OFF. ");
        }

        public void SwitchChannel()
        {
            if (IsOn)
            {
                Console.WriteLine("Switching channels- put DORAEMON");
            }
        }
    }
}