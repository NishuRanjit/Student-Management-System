using SMS.Application.Interfaces;
using SMS.Infrastructure.Data;

namespace SMS.Infrastructure.Unit_Of_Work
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SmsDbContext _context;
        public IStudentRepository Students { get; }
        public UnitOfWork(SmsDbContext context,IStudentRepository repo) {
            _context = context;
            Students = repo;
        }
        

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }

        
    }
}
