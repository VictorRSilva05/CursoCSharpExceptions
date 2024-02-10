using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp15.Exceptions;

namespace ConsoleApp15.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawnLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawnLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawnLimit = withdrawnLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithdrawnLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
