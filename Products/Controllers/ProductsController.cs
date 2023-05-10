using Microsoft.AspNetCore.Mvc;

namespace Products.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Products> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Products
            {
                Date = DateTime.Now.AddDays(index),
                Precio = Random.Shared.Next(100, 400),
                Nombre = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}