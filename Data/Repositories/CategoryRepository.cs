using LiquorStore_AspCore.Data.Interfaces;
using LiquorStore_AspCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiquorStore_AspCore.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext; 
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
