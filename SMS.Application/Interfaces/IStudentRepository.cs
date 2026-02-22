using SMS.Domain.Entities;
namespace SMS.Application.Interfaces
{
    public interface IStudentRepository
    {
     
            Task AddAsync(Student student);
            IQueryable<Student> GetAll();

        
    }


}
