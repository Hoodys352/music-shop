using Microsoft.EntityFrameworkCore;
using MusicShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<T> Find(Guid Id)
        {
            return await entities.FindAsync(Id);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = entities;
            if(filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task Add(T entity)
        {
            await entities.AddAsync(entity);
        }

    }
}
