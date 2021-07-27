using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindByName(string name);
        Task<IEnumerable<T>> GetAll();
    }
}
