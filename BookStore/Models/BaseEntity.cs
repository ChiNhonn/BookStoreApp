using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }

        public BaseEntity()
        { 
            CreateDate = DateTime.Now;
        }
        public virtual string GetDisplayName()
        {
            return $"Id:{Id}";
        }

    }
}
