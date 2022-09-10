using Microsoft.AspNetCore.Mvc;
using WebApplication5.Controllers.Models.Repositories;
using WebApplication5.Controllers.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productRepository.Create(product);
            return new OkResult();
        }

    }
}
