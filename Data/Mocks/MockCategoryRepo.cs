using LiquorStore_AspCore.Data.Interfaces;
using LiquorStore_AspCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiquorStore_AspCore.Data.Mocks
{
    public class MockCategoryRepo : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName ="Alcoholic" , Description="All AlcholDrinks"},
                    new Category {CategoryName ="Non-Alcoholic" , Description="All Non-AlcholDrinks"},
                };
            }
                }
    }
}
