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
                Item shampoo = new Item { Name = "Шамнпунь", Cost = 8, Count = 1000 };
                Item crisps = new Item { Name = "Чипсы", Cost = 3, Count = 300 };
                Item pizza = new Item { Name = "Пицца", Cost = 10, Count = 100 };

                Client client1 = new Client { Adress = "Mogilev", Name = "Kirill", Surname = "Mokeichev", PhoneNumber = 1234567 };
                Client client2 = new Client { Adress = "Minsk", Name = "Ivan", Surname = "Ivanov", PhoneNumber = 7654321 };

                Order order1 = new Order { ClientId = 1, OrderDate = "22.02.2020" };
                Order order2 = new Order { ClientId = 2, OrderDate = "16.08.2019" };

                db.Items.AddRange(shampoo, crisps, pizza);
                db.Clients.AddRange(client1, client2);
                db.Orders.AddRange(order1, order2);
                db.SaveChanges();
                Console.WriteLine("Changes saved");

                Console.WriteLine("Items: ");
                var item = db.Items.ToList();
                foreach (Item i in item) {
                    Console.WriteLine($"{i.Id} name = {i.Name}, cost = {i.Cost}, count = {i.Count}");
                }

                Console.WriteLine("Clients: ");
                var client = db.Clients.ToList();
                foreach (Client c in client) {
                    Console.WriteLine($"{c.Id} adress = {c.Adress}, name = {c.Name}, surname = {c.Surname}, phoneNumber = {c.PhoneNumber}");
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
