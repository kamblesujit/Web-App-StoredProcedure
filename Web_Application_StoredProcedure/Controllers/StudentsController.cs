using Microsoft.AspNetCore.Mvc;
using Web_Application_StoredProcedure.Models;
using Web_Application_StoredProcedure.Service;

namespace Web_Application_StoredProcedure.Controllers
{
    public class StudentsController : Controller
    {
        IStudentService _studentService;
        public StudentsController(IStudentService studentService) { 
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<Student> GetStudents(string Name )
        {
            return _studentService.GetStudents(Name);
        }
        public void SaveOrUpdate(Student student)
        {
            _studentService.SaveOrUpdate(student);
        }
        public void Delete(int Id)
        {
            _studentService.Delete(Id);
        }
    }
}
