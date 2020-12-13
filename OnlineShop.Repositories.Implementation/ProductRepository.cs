using OnlineShop.Domain;
using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShopDbContext dbContext;

        public ProductRepository(OnlineShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Product> GetProductDetailsAsync(int productId)
        {
            return await dbContext.Products.FindAsync(new { Id = productId });
        }

        public Task<List<Product>> GetProductsListAsync()
        {
            return Task.FromResult(dbContext.Products.ToList());
        }

        public Task<List<Product>> GetProductsListAsync(int subCategoryId)
        {
            return Task.FromResult(dbContext.Products.ToList());
        }
    }
}
