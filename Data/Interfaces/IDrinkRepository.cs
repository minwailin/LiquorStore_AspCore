using LiquorStore_AspCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiquorStore_AspCore.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get;  }
        IEnumerable<Drink> IsPreferredDrink { get; }
        Drink GetDrinkById(int drinkId);



    }
}
