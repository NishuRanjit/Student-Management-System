using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS.Application.DTOs;
using SMS.Application.Interfaces;
using SMS.Domain.Entities;
using SMS.Infrastructure.Unit_Of_Work;

namespace Student_Management_System.Controllers
{
    public class StudentController : Controller
    {
       
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var student = (await _studentService.GetAllStudentsAsync())
                            .FirstOrDefault(s => s.Id == id);

            return View(student);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var student = (await _studentService.GetAllStudentsAsync()).FirstOrDefault(s => s.Id == id);
            return View(student);
        }
        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllStudentsAsync();
            return View(students);
        }
        public async Task<IActionResult> Details(int id)
        {
            var student = (await _studentService.GetAllStudentsAsync()).FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            await _studentService.CreateAsync(dto);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            await _studentService.UpdateStudentAsync(student);

            return RedirectToAction("Index");
        }

    }
}
    
