using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Domain.Models;

namespace WebStore.Domain.Intefaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
