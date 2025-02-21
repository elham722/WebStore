using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Application.ViewModels;

namespace WebStore.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProduct();
    }
}
