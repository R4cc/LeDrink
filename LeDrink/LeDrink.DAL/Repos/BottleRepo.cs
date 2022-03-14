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
            return await _context.Bottles.FirstOrDefaultAsync(b => b.Id == bottleId);
        }

        public async Task<List<Bottle>> GetBottles()
        {
            return await _context.Bottles.ToListAsync();
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
