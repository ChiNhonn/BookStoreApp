using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value < 0 ? 0 : value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value < 0 ? 0 : value; }
        }
        public Product(int id, string name, decimal price, int quantity)
        {
            ProductId = id;
            ProductName = name;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{ProductName} - ${Price} (Qty: {Quantity})";
        }
    }
}
