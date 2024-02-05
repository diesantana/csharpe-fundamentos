
using ExercicioInterfaces.Entities;
using ExercicioInterfaces.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");

Contract contract = new Contract(number, date, contractValue);

int numberOfInstallments = int.Parse(Console.ReadLine());
ContractService contractService = new ContractService(new PayPalService());
contractService.ProcessContract(contract, numberOfInstallments);

Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}