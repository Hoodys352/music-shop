using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBandRepository Bands { get; }
        IAlbumRepository Albums { get; }
        ITracklistRepository Tracklists { get; }
        Task<int> Complete();
    }
}
