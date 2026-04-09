using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class  Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {

        }
        public Category(int Id, string Name)
        {
            CategoryId = Id;
            CategoryName = Name;
        }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}
