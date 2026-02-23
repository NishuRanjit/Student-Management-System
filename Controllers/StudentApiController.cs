using Microsoft.AspNetCore.Mvc;
using SMS.Application.Interfaces;
using SMS.Domain.Entities;

namespace Student_Management_System.Controllers
{
    [ApiController]
    [Route("api/Students")]
    public class StudentApiController : Controller
    {
        private readonly IGenericRepository<Student> _repo;
        public StudentApiController(IGenericRepository<Student> repo)

        {
           _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok(await _repo.GetAllAsync());
        }
    }
}
