using Microsoft.AspNetCore.Mvc;

namespace Student_Management_System.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult create()
        {
            return View();
        }
    }
}
