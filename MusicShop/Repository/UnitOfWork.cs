using MusicShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IBandRepository Bands { get; }

        public IAlbumRepository Albums { get; }
        public ITracklistRepository Tracklists { get; }

        public UnitOfWork(ApplicationDbContext context
            ,IBandRepository bandRepository
            ,IAlbumRepository albumRepository
            ,ITracklistRepository tracklistRepository)
        {
            this.context = context;
            Bands = bandRepository;
            Albums = albumRepository;
            Tracklists = tracklistRepository;
        }

        public async Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
