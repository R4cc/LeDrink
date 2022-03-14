using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDrink.DAL.Repos
{
    public class MixRepo : IMixRepo
    {
        private readonly ApplicationDBContext _context;

        public MixRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task AddMix(Mix mix)
        {
            await _context.AddAsync(mix);
        }

        public async Task<Mix> GetMix(int mixId)
        {
            return await _context.Mixes.FirstOrDefaultAsync(mix => mix.Id == mixId);
        }

        public async Task<List<Mix>> GetAll()
        {
            return await _context.Mixes.ToListAsync();
        }

        public async Task RemoveMix(Mix mix)
        {
            _context.Remove(mix);
        }

        public async Task UpdateMix(Mix mix)
        {
            _context.Update(mix);
        }

        public async Task<List<Mix>> GetMixesFromDrinkId(int drinkId)
        {
            return _context.Mixes.Include(m => m.Bottle).Where(m => m.drinkId == drinkId).ToList();
        }
    }
}
