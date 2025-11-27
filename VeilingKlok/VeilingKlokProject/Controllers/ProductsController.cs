using Microsoft.AspNetCore.Mvc;
using VeilingKlok.Data;

namespace VeilingKlok.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductsController(VeilingKlokContext context)
        {
           
            _repository = new ProductRepository(context);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _repository.GetAllProducts();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            var savedProduct = await _repository.AddProduct(product);

            return CreatedAtAction(nameof(Get), new { id = savedProduct.Id }, savedProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateProduct(product);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteProduct(id);

            return NoContent();
        }

    }
}