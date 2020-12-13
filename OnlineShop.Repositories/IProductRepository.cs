using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsListAsync();

        Task<List<Product>> GetProductsListAsync(int subCategoryId);

        Task<Product> GetProductDetailsAsync(int productId);
    }
}
