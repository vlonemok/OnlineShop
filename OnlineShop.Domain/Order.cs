using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Order
    {
        public Order()
        {
            Items = new HashSet<OrderItems>();
        }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<OrderItems> Items { get; set; }
    }
}
