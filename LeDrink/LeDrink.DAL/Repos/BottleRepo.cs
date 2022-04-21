using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LeDrink.DAL.Repos
{
    public class BottleRepo : IBottleRepo
    {
        private readonly ApplicationDBContext _context;

        public BottleRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task AddBottle(Bottle bottle)
        {
            await _context.AddAsync(bottle);
        }

        public async Task<Bottle> GetBottle(int bottleId)
        {
            var bottle = await _context.Bottles.FirstOrDefaultAsync(b => b.Id == bottleId);
            _context.Entry(bottle).Reload();
            return bottle;
        }

        public async Task<List<Bottle>> GetBottles()
        {
            var bottles = await _context.Bottles.ToListAsync();
            foreach (var bottle in bottles)
            {
                _context.Entry(bottle).Reload();
            }
            return bottles;
        }

        public async Task RemoveBottle(Bottle bottle)
        {
            _context.Remove(bottle);
        }

        public async Task UpdateBottle(Bottle bottle)
        {
            _context.Update(bottle);
        }
    }
}