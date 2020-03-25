
namespace TestXamarin.Api.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Data.Repositories;
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAll());
        }
    }
}
