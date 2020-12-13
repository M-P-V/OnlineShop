using OnlineShop.Domain.Models;
using OnlineShop.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetCategoriesListAsync()
        {
            return await categoryRepository.GetCategoriesListAsync();
        }
    }
}
