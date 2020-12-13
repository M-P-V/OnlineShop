using OnlineShop.Domain;
using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineShopDbContext dbContext;

        public CategoryRepository(OnlineShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Category>> GetCategoriesListAsync()
        {
            return await Task.FromResult(dbContext.Categories.ToList());
        }
    }
}
