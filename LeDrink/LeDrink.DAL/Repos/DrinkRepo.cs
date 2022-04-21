using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LeDrink.DAL.Repos
{
    /// <summary>
    /// Direct data interface with DB entries for Drink model
    /// </summary>
    public class DrinkRepo : IDrinkRepo
    {
        private readonly ApplicationDBContext _context;

        public DrinkRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task AddDrink(Drink drink)
        {
            await _context.AddAsync(drink);
        }

        public async Task<Drink?> GetDrink(int drinkId)
        {
            var drink = await _context.Drinks.FirstOrDefaultAsync(drink => drink.Id == drinkId);
            _context.Entry(drink).Reload();
            return drink;
        }

        public async Task<List<Drink>> GetDrinks()
        {
            var drinks = await _context.Drinks.Include(d => d.Mixes).ToListAsync();
            foreach (var drink in drinks)
            {
                _context.Entry(drink).Reload();
            }
            return drinks;
        }

        public async Task RemoveDrink(Drink drink)
        {
            _context.Remove(drink);
        }

        public async Task UpdateDrink(Drink drink)
        {
            _context.Update(drink);
        }
    }
}