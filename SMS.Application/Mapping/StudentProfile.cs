using AutoMapper;
using SMS.Application.DTOs;
using SMS.Domain.Entities;

namespace SMS.Application.Mapping
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentCreateDTO, Student>();
        }
    }
}
