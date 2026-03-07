using System.Linq.Expressions;

namespace SMS.Application.Interfaces
{
    public interface IGenericRepository<T>where T : class
    {
        Task AddAsync(T entity);
        Task <IEnumerable<T>> GetAllAsync();
        Task <T?>GetAsync(Expression<Func<T, bool>> predicate);
    }
}
