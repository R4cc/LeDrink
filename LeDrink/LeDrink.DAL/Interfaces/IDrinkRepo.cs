using LeDrink.DAL.Models;
using LeDrink.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDrink.DAL.Interfaces
{
    public interface IDrinkRepo
    {
        Task<IEnumerable<Drink>> GetDrinks();
        Task<Drink> GetDrink(int Id);
        Task AddDrink(Drink drink);
        Task RemoveDrink(Drink drink);
        Task UpdateDrink(Drink drink);
        Task<Bottle> GetBottle(int bottleId);
    }
}
