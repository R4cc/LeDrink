using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using LeDrink.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LeDrink.DAL.Repos
{
    public class DrinRepo : IDrinkRepo
    {
        private readonly ApplicationDBContext _context;

        public DrinRepo(ApplicationDBContext applicationDBContext)
        {
            _context = applicationDBContext;
        }

        public async Task AddDrink(Drink drink)
        {
            await _context.AddAsync(drink);
        }

        public async Task<Drink> GetDrink(int drinkId)
        {
            return await _context.Drinks.FirstOrDefaultAsync(drink => drink.Id == drinkId);
        }

        public async Task<List<Drink>> GetDrinks()
        {
            return await _context.Drinks.ToListAsync();
        }

        public async Task RemoveDrink(Drink drink)
        {
            _context.Remove(drink);
        }

        public async Task UpdateDrink(Drink drink)
        {
            _context.Update(drink);
        }

        public async Task<Bottle> GetBottle(int bottleId)
        {
            return await _context.Bottles.FirstOrDefaultAsync(b => b.Id == bottleId);
        }

    }
}
