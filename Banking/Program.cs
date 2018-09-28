using Banking.Models.Domein;
using System;

namespace Banking
{
    static class Program
    {
        static void Main(string[] args)
        {
            //BankAccount anotherBA = new BankAccount()
            //{
            //    AccountNumber = "123-124153513-99",
            //    Balance = 200
            //};

            BankAccount myBA = new BankAccount("123-123123123-99", 50);
            Console.WriteLine($"Account number is {myBA.AccountNumber}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Deposit(200, 2);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Withdraw cost is {BankAccount.WithdrawCost}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            Console.ReadKey();
        }
    }
}
