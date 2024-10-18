using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.IRepository
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
    }
}