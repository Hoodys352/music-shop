using MusicShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<T> FindByName(string name)
        {
            return null;
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return null;
        }
    }
}
