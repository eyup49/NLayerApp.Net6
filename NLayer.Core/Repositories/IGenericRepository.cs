using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
//Task<IEnumerable<T>> GetAllAsync();
//IQueryable<T> GetAll();
//IQueryable GetAll<T>();
//IQueryable GetAll<T>(Func<T, bool> predicate);
//IQueryable GetAll<T>(Func<T, bool, bool> predicate);
//IQueryable AddAsync(T entity);