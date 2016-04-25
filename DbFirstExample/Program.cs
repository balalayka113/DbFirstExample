using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstExample {
    class Program {
        static void Main(string[] args) {
            using (ShopDb shopDb = new ShopDb()) {
                Product product = new Product {
                    Currency = new Currency { Name = "$" },
                    Manufacturer = new Manufacturer { Name = "Dell" },
                    Price = 100,
                    Name = "monitor"
                };
                shopDb.Products.Add(product);
                shopDb.SaveChanges();

                shopDb.Products.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            }

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
