using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domein
{
    public class BankAccount
    {
        #region Fields
        //private string _accountNumber;
        public const decimal WithdrawCost = 0.10M;
        private decimal _balance; 
        #endregion

        #region Properties
        public string AccountNumber { get; private set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        } 
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount, int nrOfTimes = 1)
        {
            Balance += amount * nrOfTimes;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount + WithdrawCost;
        } 
        #endregion
    }
}
