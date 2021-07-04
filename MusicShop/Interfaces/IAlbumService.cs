using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> FindAllAsync();
        Task<Album> FindByNameAsync(string name);
        Task CreateAsync(Album album);
    }
}
