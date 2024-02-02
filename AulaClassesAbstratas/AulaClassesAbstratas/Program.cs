
using AulaClassesAbstratas.Entities;
using System.Globalization;
using System.Security.Principal;

List<Account> accounts = new List<Account>();

accounts.Add(new BusinessAccount(1001, "Alex", 500.0, 200.0));
accounts.Add(new SavingsAccount(1002, "Maria", 500.0, 0.01));
accounts.Add(new BusinessAccount(1003, "Bob", 500.0, 200.0));
accounts.Add(new SavingsAccount(1004, "Paulo", 500.0, 0.01));

double sum = 0;
foreach (Account account in accounts)
{
    sum += account.Balance;
}

Console.WriteLine("Total balance: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

foreach (Account account in accounts)
{
    account.Withdraw(10.0);
}

Console.WriteLine("Update balance:");
foreach (Account account in accounts)
{
    Console.WriteLine($"Conta: {account.Number}, Balance: $ {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}