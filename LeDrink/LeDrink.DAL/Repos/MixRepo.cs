﻿using LeDrink.DAL.Data;
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
            var mix = await _context.Mixes.FirstOrDefaultAsync(mix => mix.Id == mixId);
            _context.Entry(mix).Reload();
            return mix;
        }

        public async Task<List<Mix>> GetAll()
        {
            return await _context.Mixes.ToListAsync();
        }

        public async Task RemoveMix(Mix mix)
        {
            _context.Remove(mix);
        }

        public Task UpdateMix(Mix mix)
        {
            _context.Update(mix);
            return Task.CompletedTask;
        }

        public async Task<List<Mix>> GetMixesFromDrinkId(int drinkId)
        {
            return _context.Mixes.Include(m => m.Bottle)
                .Where(m => m.drinkId == drinkId)
                .ToList();
        }
    }
}
