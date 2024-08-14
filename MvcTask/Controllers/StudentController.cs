using Microsoft.AspNetCore.Mvc;
using MvcTask.Models;

namespace MvcTask.Controllers
{
    public class StudentController : Controller
    {
        MockStudentData studentData = new MockStudentData();
        public IActionResult Details(int id)
        {
            
            Student studentModel = studentData.GetStudentById(id);
            return View("StudentDetail",studentModel);
        }

        public IActionResult Index()
        {
            List<Student> students = studentData.GetAllStudents();
            return View("ShowAll", students);
        }



    }
}
