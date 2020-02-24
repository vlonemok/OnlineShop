using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string OrderDate { get; set; }
    }
}
