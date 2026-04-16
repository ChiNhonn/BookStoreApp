using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    _price = 0;
                else
                    _price = value;
            }
        }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                    _quantity = 0;
                else
                    _quantity = value;
            }
        }
        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0) throw new Exception("Lỗi: Số lượng tồn kho không hợp lệ.");
                _stock = value;
            }
        }
        public Book() { }
        public Book(string id, string title, string author, string categoryId, Category category, decimal price, int stock)
        {
            Id = id;
            Title = title;
            CategoryId = categoryId;
            Category = category;
            Price = price;
            Stock = stock;
        }
        public override string GetDisplayName()
        {
            return $"{base.GetDisplayName()} - Sách: {Title} (Giá:{ Price: N0}VNĐ | Tồn: { Stock})";
        }
        public override string ToString()
        {
            return Title + " - " + Price + "VNĐ - " + Category.Name;
        }
    }
}
