using AulaListExercicio;
using System.Globalization;

Console.Write("Quantos funcionários serão registrados? ");
int quantity = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();
// Cadastra os funcionários
for (int i = 0; i < quantity; i++)
{
    Console.WriteLine($"Funcionário #{i + 1}:");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    // Verifica se o id já existe
    while (employees.Any(x => x.Id == id))
    {
        Console.WriteLine("O Id informado já existe!");
        Console.Write("Digite outro Id: ");
        id = int.Parse(Console.ReadLine());
    }

    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Salário: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employees.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Informe o Id do funcionário que terá aumento salarial: ");
int idToIncrease = int.Parse(Console.ReadLine());

if (employees.Any(x => x.Id == idToIncrease))
{
    int index = employees.FindIndex(x => x.Id == idToIncrease);
    Console.Write("Insira a porcentagem: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employees[index].IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("Este ID não existe");
}

Console.WriteLine();
Console.WriteLine("Lista de funcionários atualizada:");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}


