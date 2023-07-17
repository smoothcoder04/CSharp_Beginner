namespace enericInheritance
{
    // This class is not generic, but it derives from a generic class
    public class IntegerHolder : Holder<int>
    {
        //constructor chaining
        public IntegerHolder(int holderSize)
            : base(holderSize)
        {

        }

        public int GetSum()
        {
            int sum = 0;

            foreach (var number in Items)
            {
                sum += number;
            }

            return sum;
        }
    }
}