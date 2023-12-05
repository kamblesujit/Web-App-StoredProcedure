using Microsoft.EntityFrameworkCore;
using Web_Application_StoredProcedure.Data;
using Web_Application_StoredProcedure.Models;

namespace Web_Application_StoredProcedure.Service
{
    public class StudentService : IStudentService
    {
        DBContext _dbContext;
        public StudentService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void Delete(int Id)
        {
            _dbContext.Database.ExecuteSqlRaw($"DeleteStudent {Id}");
            var students = _dbContext.Students.ToList();
        }

        public List<Student> GetStudents(string Name)
        {
            var students = _dbContext.Students.FromSqlRaw($"GetStudents {Name}").ToList();
            return students;
        }

        public void SaveOrUpdate(Student student)
        {
            _dbContext.Database.ExecuteSqlRaw($"SaveOrUpdateStudent {student.Name}{student.Gender} {student.Standard}{student.Address}{student.City}{student.Note}");
            var students = _dbContext.Students.ToList();
        }
    }
}
