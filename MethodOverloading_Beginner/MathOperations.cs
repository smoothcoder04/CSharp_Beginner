namespace Methodoverloading
{
    public class MathOperation
    {
        public double Multiply(int FirstNumber, int SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }

        public double Multiply(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            return FirstNumber * SecondNumber * ThirdNumber;
        }

        public double Multiply(params double[] NumbersToMultiply)
        {
            if (NumbersToMultiply.Length == 0)
            {
                return 0;
            }
            if (NumbersToMultiply.Length == 1)
            {
                return NumbersToMultiply[0];
            }

            var result = NumbersToMultiply[0];
            for (int index = 1; index < NumbersToMultiply.Length; index++)
            {
                result *= NumbersToMultiply[index];
            }
            return result;
        }
    }
}