using Microsoft.EntityFrameworkCore;
using SMS.Application.Interfaces;
using SMS.Domain.Entities;
using SMS.Infrastructure.Data;


namespace SMS.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SmsDbContext _context;
        public StudentRepository(SmsDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
        }

        public IQueryable<Student> GetAll()
        {
            return _context.Students.Where(x=>!x.IsDeleted);
        }
    }
}
