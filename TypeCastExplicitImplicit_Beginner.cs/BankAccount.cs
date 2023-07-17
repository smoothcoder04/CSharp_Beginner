namespace CastOperatorOverloading
{

    public class BankAccount
    {

        //define filed Funds' property
        public decimal Funds { get; set; }

        public static implicit operator decimal(BankAccount param)
        {
            return param.Funds;
        }
        public static explicit operator BankAccount(decimal param)
        {
            return new BankAccount() { Funds = param };
        }
    }

}