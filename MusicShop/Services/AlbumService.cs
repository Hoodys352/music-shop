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
    public class AlbumService : IAlbumService
    {
        private readonly ApplicationDbContext context;
        public AlbumService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Album>> FindAllAsync()
        {
            return await context.Albums.ToListAsync();
        }

        public async Task<Album> FindByNameAsync(string name)
        {
            return await context.Albums.Where(a => a.Name == name).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Album album)
        {
            var albumToCreate = new Album()
            {
                Id = Guid.NewGuid(),
                Name = album.Name,
                ReleaseDate = album.ReleaseDate,
                Price = album.Price,
                BandId = album.BandId
            };
            await context.Albums.AddAsync(albumToCreate);
            await context.SaveChangesAsync();
        }
    }
}
