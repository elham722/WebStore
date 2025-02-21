using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Domain.Intefaces;
using WebStore.Domain.Models;
using WebStore.Infra.Data.Context;

namespace WebStore.Infra.Data.Repositories
{
   public class ProductRepository:IProductRepository
   {
       private WebStoreDBContext _context;

       public ProductRepository(WebStoreDBContext context)
       {
           _context = context;
       }
       public IEnumerable<Product> GetProducts()
       {
           return _context.Products;
       }
    }
}
