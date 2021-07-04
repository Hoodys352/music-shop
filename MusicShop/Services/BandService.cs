using Microsoft.EntityFrameworkCore;
using MusicShop.Data;
using MusicShop.Interfaces;
using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Services
{
    public class BandService : IBandService
    {
        public readonly ApplicationDbContext _context;

        public BandService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Band>> FindAllAsync()
        {
            return await _context.Bands.ToListAsync();
        }

        public async Task<Band> FindByNameAsync(string name)
        {
            return await _context.Bands.Where(b => b.Name == name).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Band band)
        {
            var bandToCreate = new Band()
            {
                Id = Guid.NewGuid(),
                Name = band.Name
            };
            await _context.Bands.AddAsync(bandToCreate);
            await _context.SaveChangesAsync();
        }
    }
}
