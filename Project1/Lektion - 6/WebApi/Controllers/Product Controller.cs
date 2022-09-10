using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace WebApi.Controllers
{
    public class Product_Controller
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

            [HttpGet]
            public IActionResult GetAll()
            {
                return new OkObjectResult(_productRepository.GetAll());
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var product = _productRepository.Get(id);
                if (product != null)
                    return new OkObjectResult(product);

                return new NotFoundResult();
            }


            [HttpPost]
            public IActionResult Create(CreateProduct product)
            {
                if (_productRepository.Get(product.Name) == null)
                {
                    var _product = _productRepository.Create(product.Name, product.Price);
                    if (_product != null)
                        return new CreatedResult("https://localhost:7214/api/products", _product);

                    return new BadRequestResult();
                }
                else
                {
                    return new ConflictResult();
                }
            }
        }
    }
}

