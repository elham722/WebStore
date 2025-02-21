using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Models;

namespace WebStore.Infra.Data.Context
{
  public class WebStoreDBContext:DbContext
    {
        public WebStoreDBContext(DbContextOptions<WebStoreDBContext> options) :base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
