﻿using OnlineShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategoriesListAsync();
    }
}
