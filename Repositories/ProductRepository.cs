using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Entities;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        RepositoriesContext context;
        public ProductRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddProduct(Product prod)
        {
            context.Products.Add(prod);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteProduct(int id)
        {
            var prod = context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (prod != null)
            {
                context.Products.Remove(prod);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public int ModifyProduct(Product prod)
        {
            var product = context.Products.Where(p => p.Id == prod.Id).SingleOrDefault();
            if (product != null)
            {
                product.Name = prod.Name;
                product.Price = prod.Price;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
