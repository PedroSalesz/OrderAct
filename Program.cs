using ProjectOrder.Entities.Enums;
using ProjectOrder.Entities;
using System.Globalization;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(clientName, email, birthDate);  //Construtor recebendo nome do cliente, email do cliente e data de aniversário
Order order = new Order(DateTime.Now, status, client);    // Construtor recebendo a data do momento, o status do pedido e o cliente

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:"); //Interpolação ($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Product product = new Product(productName, price); //Construtor recebendo Nome do produto e o preço

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem orderItem = new OrderItem(quantity, price, product); //Construtor recebendo a Quantidade, preço e o produto

    order.AddItem(orderItem); //Adicionando items 
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);
