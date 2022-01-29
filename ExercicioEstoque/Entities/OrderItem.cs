using System.Text;
using System.Globalization;

namespace ExercicioEstoque.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }

        public double subTotal()
        {
            return price * quantity; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order items: ");
            sb.Append(product.name + ", " + product.price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + quantity + " Subtotal: " + subTotal().ToString("F2", CultureInfo.InvariantCulture));;
            return sb.ToString();
        }
    }
}
