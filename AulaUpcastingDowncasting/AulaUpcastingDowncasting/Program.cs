

using AulaUpcastingDowncasting.Entities;

Account acc = new Account(1001, "Alex", 0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

// Upcasting
Account acc1 = bacc;
Account acc2 = new BusinessAccount(1003, "Pedro", 0.0, 500.0);
Account acc3 = new SavingsAccount(1004, "Alice", 0.0, 0.01);

// Downcasting
// BusinessAccount acc4 = (BusinessAccount)acc2;
BusinessAccount acc4 = acc2 as BusinessAccount;

if (acc3 is BusinessAccount)
{
    BusinessAccount acc5 = acc3 as BusinessAccount;
}
else
{
    Console.WriteLine("Operação insegura! Downcasting não permitido.");
}
