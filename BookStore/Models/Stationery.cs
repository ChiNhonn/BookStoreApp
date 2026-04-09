using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;
namespace BookStore.Models
{
    public class Stationery : Product
    {
        public string MauSac { get; set; }

        public Stationery(int id, string name, decimal price, int quantity, string mausac)
            : base(id, name, price, quantity)
        {
            this.MauSac = mausac;
        }
        public override string ToString()
        {
            return $"{ProductName} - {MauSac} (Giá: {Price:N0} VNĐ | SL: {Quantity})";
        }
    }
}
