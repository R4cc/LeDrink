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
            return await _context.Drinks.FirstOrDefaultAsync(drink => drink.Id == drinkId);
        }

        public async Task<List<Drink>> GetDrinks()
        {
            return await _context.Drinks.Include(d => d.Mixes).ToListAsync();
        }

        public Task RemoveDrink(Drink drink)
        {
            _context.Remove(drink);
            return Task.CompletedTask;
        }

        public Task UpdateDrink(Drink drink)
        {
            _context.Update(drink);
            return Task.CompletedTask;
        }

        
    }
}