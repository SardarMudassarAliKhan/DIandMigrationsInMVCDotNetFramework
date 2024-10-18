using System.Collections.Generic;
using System.Linq;
using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Models;

namespace WebApplication2.Service
{
    public class ProductService : IProductService
    {
        private readonly MyDbContext _context;

        public ProductService(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}