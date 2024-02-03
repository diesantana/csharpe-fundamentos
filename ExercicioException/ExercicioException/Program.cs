﻿
using ExercicioException.Entities;
using ExercicioException.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, initialBalance, limit);
    Console.WriteLine();

    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(amount);
    Console.WriteLine($"New Balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
} 
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " +  e.Message);
}