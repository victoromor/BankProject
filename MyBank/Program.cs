using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Victor", 10000);
            Console.WriteLine($"Account {account.Number} " +
                $"was created for {account.Owner} with " +
                $"${account.Balance} balance.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "PS5 Game");

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine(account.Balance);



            //// Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    //return;
            //}

        }
    }

}