using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface IAttributeValueRepository
    {
        Task<List<AttributeValue>> GetProductAttributeValuesAsync(int productId);
    }
}
