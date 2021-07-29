using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Find(Guid Id);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
    }
}
