using System;


namespace CastOperatorOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            var bankAccount = new BankAccount() { Funds = 1000000m };
            decimal myMoney = bankAccount;
            myMoney += 250m;
            BankAccount anotherBankAccount = (BankAccount)myMoney;

            Console.WriteLine($"Money in initial bank account: {bankAccount.Funds} dollars.");
            Console.WriteLine($"Money in the second account: {anotherBankAccount.Funds} dollars.");
        }
    }
}