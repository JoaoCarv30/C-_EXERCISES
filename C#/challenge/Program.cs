using System;
using challenge.Entities;
using challenge.Entities.Enums;

namespace challenge // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Order order = new Order();
            Console.WriteLine("Enter Cliente Data :");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter #" + (i) + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);


                order = new Order(DateTime.Now, status, client);
                order.AddItem(orderItem);



            }


            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}