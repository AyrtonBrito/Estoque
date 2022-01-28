using ExercicioEstoque.Entities.Enuns;
using ExercicioEstoque.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstoque
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status{ get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client cliente { get; set; }

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
            return 
        }
    }
}
