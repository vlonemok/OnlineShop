using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
    }
}
