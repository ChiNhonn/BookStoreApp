using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public Category BookCategory { get; set; }

        public Book(int id, string title, string author, Category category, decimal price, int quantity)
            : base(id, title, price, quantity)
        {
            Author = author;
            BookCategory = category;
        }
        public override string ToString()
        {
            return $"{Author} (Giá: {Price:N0} VNĐ | Số lượng: {Quantity})";
        }
    }
}
