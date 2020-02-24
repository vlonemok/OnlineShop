using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Item
    {
        public Item()
        {
            Orders = new HashSet<OrderItems>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int OrderId { get; set; }
        public virtual ICollection<OrderItems> Orders { get; set; }
    }
}
