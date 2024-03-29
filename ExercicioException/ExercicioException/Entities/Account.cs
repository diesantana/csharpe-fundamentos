﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioException.Entities.Exceptions;

namespace ExercicioException.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }    
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new DomainException("Deposit must be greater than zero");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new DomainException("Withdraw must be greater than zero");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }

    }
}
