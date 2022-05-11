using LiquorStore_AspCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiquorStore_AspCore.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories {get;}
    }
}


