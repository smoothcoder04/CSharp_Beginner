namespace OperatorOverloading
{
    public class PreciousMetal
    {
        public decimal DollaValue { get; set; }
        public decimal Weight { get; set; }
        public decimal PricePerGram
        {
            get { return DollaValue / Weight; }
        }

        public PreciousMetal(decimal dollarValue, decimal weight)
        {
            this.DollaValue = dollarValue;
            this.Weight = weight;
        }

        public static PreciousMetal operator +(PreciousMetal operand1, PreciousMetal operand2)
        {

            var combinedDollarValue = operand1.DollaValue + operand2.DollaValue;
            var combinedWeights = operand1.Weight + operand2.Weight;

            return new PreciousMetal(combinedDollarValue, combinedWeights);
        }

        public static bool operator <(PreciousMetal operand1, PreciousMetal operand2)
        {
            return operand1.PricePerGram < operand2.PricePerGram;
        }
        public static bool operator >(PreciousMetal operand1, PreciousMetal operand2)
        {
            return operand1.PricePerGram > operand2.PricePerGram;
        }
        public static decimal operator +(PreciousMetal operand1, decimal operand2)
        {
            return operand1.DollaValue + operand2;
        }
    }
}