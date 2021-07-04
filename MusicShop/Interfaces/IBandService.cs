using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Interfaces
{
    public interface IBandService
    {
        Task<IEnumerable<Band>> FindAllAsync();
        Task<Band> FindByNameAsync(string name);
        Task CreateAsync(Band Band);
    }
}
