using Microsoft.AspNetCore.Mvc;
using VeilingKlok.Models;


namespace VeilingKlok.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // get api/product
        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(Product.Products);
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = Product.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet("test")]
        public string GetTestString()
        {             
            return "endpoint werkt";
        }
        // post api/product
        [HttpPost]
        public ActionResult<Product> CreateProduct(Product newProduct)
        {
            Product.Products.Add(newProduct);
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.Id }, newProduct);
        }
    }
}