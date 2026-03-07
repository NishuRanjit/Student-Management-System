using SMS.Application.DTOs;
using SMS.Domain.Entities;

namespace SMS.Application.Interfaces
{
    public interface IStudentService
    {
       
        Task CreateAsync(StudentCreateDTO dto);
        Task<List<Student>> GetAllStudentsAsync();
        Task UpdateStudentAsync(Student student);
    }
}
