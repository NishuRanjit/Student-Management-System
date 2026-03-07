using Microsoft.EntityFrameworkCore;
using SMS.Application.Interfaces;
using SMS.Infrastructure.Data;
using System.Linq.Expressions;

namespace SMS.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SmsDbContext _context;
        private readonly DbSet<T> _dbset;
        public GenericRepository(SmsDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.FirstOrDefaultAsync(predicate);
        }
    }
}
