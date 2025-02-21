using Microsoft.AspNetCore.Mvc;
using WebStore.Application.Services.Interfaces;

namespace WebStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
