using OnlineShop.Domain.Models;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface IOrderRepository
    {
        Task<bool> CreateOrderAsync(Order order);
    }
}
