using OnlineShop.Domain;
using OnlineShop.Domain.Models;
using System.Threading.Tasks;

namespace OnlineShop.Repositories.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OnlineShopDbContext dbContext;

        public OrderRepository(OnlineShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<bool> CreateOrderAsync(Order order)
        {
            dbContext.Orders.Add(order);

            return Task.FromResult(true);
        }
    }
}
