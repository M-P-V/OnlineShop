using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface IAttributeRepository
    {
        Task<List<Attribute>> GetAttributesListAsync();
    }
}
