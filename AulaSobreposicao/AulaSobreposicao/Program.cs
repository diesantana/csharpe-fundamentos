
using AulaSobreposicao.Entities;

Account account = new Account(1001, "Maria", 500.0);
Account account2 = new SavingsAccount(50, "Bob", 500.0, 0.01);

account.Withdraw(10.0);
account2.Withdraw(10.0);

Console.WriteLine(account.Balance); // 485.00
Console.WriteLine(account2.Balance); // 490.00