﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class OrderItems
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
