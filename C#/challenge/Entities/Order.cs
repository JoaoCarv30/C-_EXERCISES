using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge.Entities.Enums;


namespace challenge.Entities
{
    public class Order
    {


        public Order ()
        {

        }
        public Order (DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }


        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public OrderItem OrderItem { get; set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
                Console.WriteLine(Items);

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ") - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name + ", $" + item.Product.Price.ToString("F2") + ", Quantity: " + item.Quantity + ", Subtotal: $" + item.SubTotal().ToString("F2"));
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }


    }
}