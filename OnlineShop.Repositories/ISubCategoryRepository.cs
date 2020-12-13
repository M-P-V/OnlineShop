using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface ISubCategoryRepository
    {
        Task<List<SubCategory>> GetSubCategoriesListAsync(int categoryId);
    }
}
