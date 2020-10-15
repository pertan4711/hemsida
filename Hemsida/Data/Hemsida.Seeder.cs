using Hemsida.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemsida.Data
{
    public class HemsidaSeeder
    {
        private readonly HemsidaContext _ctx;
        private readonly IHostingEnvironment _hosting;

        public HemsidaSeeder(HemsidaContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);

                //var order = _ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();
                //if (order != null)
                //{
                //    order.Items = new List<OrderItem>()
                //    {
                //        new OrderItem()
                //        {
                //            Product = products.First(),
                //            Quantity = 5,
                //            UnitPrice = products.First().Price,
                //        }
                //    };
                //}

            }

            if (!_ctx.Orders.Any())
            {
                var order = new Order()
                {
                    Id = 1,
                    OrderDate = DateTime.Now,
                    OrderNumber = "12345",
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Id = 1,
                            Product = _ctx.Products.First(),
                            Quantity = 1,
                            UnitPrice = 2,
                        },
                    }
                };

                _ctx.Orders.Add(order);
            }
            
            _ctx.SaveChanges();
        }
    }
}
