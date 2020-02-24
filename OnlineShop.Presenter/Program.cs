using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain;
using OnlineShop.Infastructure;

namespace OnlineShop.Presenter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                //Item shampoo = new Item { Name = "Шамнпунь", Cost = 8 };
                //Item crisps = new Item { Name = "Чипсы", Cost = 3 };
                //Item pizza = new Item { Name = "Пицца", Cost = 10 };

                //Client client1 = new Client { Name = "Kirill", Surname = "Mokeichev" };
                //Client client2 = new Client { Name = "Ivan", Surname = "Ivanov" };

                //Order order1 = new Order { ClientId = 1, OrderDate = DateTime.Now };
                //Order order2 = new Order { ClientId = 2, OrderDate = DateTime.Now };

                //db.Items.AddRange(shampoo, crisps, pizza);
                //db.Clients.AddRange(client1, client2);
                //db.Orders.AddRange(order1, order2);
                //db.SaveChanges();
                //Console.WriteLine("Changes saved");

                Console.WriteLine("Items: ");
                var item = db.Items.ToList();
                foreach (Item i in item) {
                    Console.WriteLine($"{i.Id} name = {i.Name}, cost = {i.Cost}");
                }

                Console.WriteLine("Clients: ");
                var client = db.Clients.ToList();
                foreach (Client c in client) {
                    Console.WriteLine($"{c.Id} name = {c.Name}, surname = {c.Surname}");
                }

                Console.WriteLine("Orders: ");
                var order = db.Orders.ToList();
                foreach (Order o in order) {
                    Console.WriteLine($"{o.Id} clientId = {o.ClientId}, orderDate = {o.OrderDate} ");
                }

                Console.ReadKey();
            }
        }
    }
}
