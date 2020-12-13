using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesListAsync();
    }
}
