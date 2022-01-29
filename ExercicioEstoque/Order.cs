using ExercicioEstoque.Entities.Enuns;
using ExercicioEstoque.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioEstoque
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status{ get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client cliente { get; set; }

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            this.moment = moment;
            this.status = status;
            this.cliente = cliente;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Itens.Remove(item);
        }
        public double total()
        {
            double sum = 0.0;
            foreach(OrderItem obj in Itens)
            {
                sum += obj.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + status);
            sb.AppendLine("Client: " + cliente.name + " " + cliente.birthDate.ToString("dd/MM/yyyy") + " - " + cliente.email);
            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
