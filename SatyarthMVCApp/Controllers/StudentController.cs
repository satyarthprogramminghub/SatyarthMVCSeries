using Microsoft.AspNetCore.Mvc;
using SatyarthMVCApp.Models;

namespace SatyarthMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetStudentDetails(int Id)
        {
            StudentRepository repo = new StudentRepository();
            Student student = repo.GetStudentById(Id);

            return View(student);
        }
    }
}
