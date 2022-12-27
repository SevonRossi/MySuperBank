using System;
using System.Security.AccessControl;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Sevon", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(-300, DateTime.Now, "stealing");
            Console.Write(account.Balance);

            BankAccount invalidAccount;


            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
        }
    }
}