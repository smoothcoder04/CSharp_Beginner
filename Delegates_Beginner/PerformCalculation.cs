namespace Delegates
{
    class PerformCalculation
    {
        public int a { get; set; }
        public int b { get; set; }

        public PerformCalculation(int value1, int value2)
        {
            this.a = value1;
            this.b = value2;

        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}