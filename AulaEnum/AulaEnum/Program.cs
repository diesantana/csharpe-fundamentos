
using AulaEnum.Entities;
using AulaEnum.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine("Pedido: " + order);
// Pedido: 1080, 31/01/2024 15:25:08, PendingPayment
Console.WriteLine();

// Convertendo um enum para string
string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

// String para enum
string texto = "Delivered";
OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), texto);
Console.WriteLine();


// String para enum com segurança
string textoEnum = "Delivered";
OrderStatus statusPedido;
if (Enum.TryParse(textoEnum, out statusPedido))
{
    // A conversão foi bem-sucedida, 'statusPedido' contém o valor do enum correspondente
    Console.WriteLine("Status do pedido: " + statusPedido);
}
else
{
    // A string fornecida não corresponde a nenhum valor do enum
    Console.WriteLine("Status do pedido não encontrado. Por favor digite um valor válido!");
}
