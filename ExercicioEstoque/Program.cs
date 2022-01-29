using System;
using ExercicioEstoque.Entities.Enuns;
using ExercicioEstoque.Entities;
using System.Globalization;

namespace ExercicioEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date: (DD/MM/YYY) ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name:");
                string nameProduct = Console.ReadLine();
                Console.WriteLine("Product price:");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(name, priceProduct);

                Console.WriteLine("Product quantity:");
                int quantityProduct = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}
