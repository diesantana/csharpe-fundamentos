
using ProjetoComposicao.Entities;
using ProjetoComposicao.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY): ");
string sDate = Console.ReadLine();
DateTime birthDate = DateTime.Parse(sDate);

// instanciando o cliente
Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
string sStatus = Console.ReadLine();
OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), sStatus);

// instanciando o pedido
Order order = new Order(status, client);

Console.Write("How many items to this order? ");
int quantityItems = int.Parse(Console.ReadLine());

// add items
for (int i = 0; i < quantityItems; i++)
{
    Console.WriteLine($"Enter #{i+1} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());
    Product product = new Product(productName, productPrice);

    order.AddItem(new OrderItem(productQuantity, productPrice,product ));
}
Console.WriteLine();
Console.WriteLine(order);