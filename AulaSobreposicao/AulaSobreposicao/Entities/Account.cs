using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreposicao.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Deposit(balance);
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
