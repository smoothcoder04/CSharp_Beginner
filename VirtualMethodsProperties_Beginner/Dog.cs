namespace VirtualMethProp
{
    public class Dog : Animal
    {
        public string Voice = "Barkkk...";

        public override void Voicy()
        {
            Console.WriteLine("Louie & Phoebe are my little monkies");
            Console.WriteLine("Next line is the call from base class Animal");
            base.Voicy();
        }
    }
}