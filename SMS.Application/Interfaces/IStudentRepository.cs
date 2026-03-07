using SMS.Domain.Entities;
namespace SMS.Application.Interfaces
{
    public interface IStudentRepository
    {
     
            Task AddAsync(Student student);
            IQueryable<Student> GetAll();

        Task<Student> GetByIdAsync(int id);
        void Update(Student student);


    }


}
