using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace VeilingKlok.Data
{
    public class ProductRepository
    {
        
        private readonly VeilingKlokContext _context;

        public ProductRepository(VeilingKlokContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Producten.ToListAsync();
        }

        public async Task<Product> AddProduct(Product product)
        {
            
            _context.Producten.Add(product);
            
            
            await _context.SaveChangesAsync();

            return product;
        }
        public async Task UpdateProduct(Product product)
        {
            _context.Producten.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Producten.FindAsync(id);

            if (product != null)
            {
                _context.Producten.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

    }
}