using SMS.Application.DTOs;
using SMS.Application.Interfaces;
using SMS.Domain.Entities;
using AutoMapper;

namespace SMS.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public StudentService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task CreateAsync(StudentCreateDTO dto)
        {
            var student = _mapper.Map<Student>(dto);
            await _uow.Students.AddAsync(student);
            await _uow.SaveAsync();
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students =  _uow.Students.GetAll();
            return students.ToList();
        }
        public async Task UpdateStudentAsync(Student student)
        {
            var existingStudent = await _uow.Students
                                .GetByIdAsync(student.Id);

            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Program = student.Program;
                existingStudent.Age = student.Age;

                _uow.Students.Update(existingStudent);
                await _uow.SaveAsync();
            }
        }


    }
}