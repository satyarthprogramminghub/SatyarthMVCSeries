using Microsoft.AspNetCore.Mvc;
using SatyarthMVCApp.Models;

namespace SatyarthMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public JsonResult GetStudentDetails(int Id)
        {
            StudentRepository repo = new StudentRepository();
            Student student = repo.GetStudentById(Id);

            return Json(student);
        }
    }
}
