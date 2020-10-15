using Hemsida.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemsida.Data
{
    public class HemsidaRepository : IHemsidaRepository
    {
        private readonly HemsidaContext _ctx;

        public HemsidaRepository(HemsidaContext ctx)
        {
            _ctx = ctx;
        }

        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(p => p.Product)
                .ToList();
            return orders;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products
                .OrderBy(p => p.Title)
                .ToList();
        }

        public Order GetOrderById(int id)
        {
            return _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(p => p.Product)
                .FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products.Where(p => p.Category == category).ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
