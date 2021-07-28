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

        public UnitOfWork(ApplicationDbContext context
            ,IBandRepository bandRepository
            ,IAlbumRepository albumRepository)
        {
            this.context = context;
            Bands = bandRepository;
            Albums = albumRepository;
        }

        public Task<int> Complete()
        {
            return context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
