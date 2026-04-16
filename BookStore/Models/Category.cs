using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public Category()
        {

        }
        public Category(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public override string GetDisplayName()
        {
            return $"{base.GetDisplayName()} - Thể loại {Name}";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
