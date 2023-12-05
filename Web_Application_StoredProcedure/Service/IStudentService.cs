using Web_Application_StoredProcedure.Models;

namespace Web_Application_StoredProcedure.Service
{
    public interface IStudentService
    {
        List<Student>GetStudents(string Name);
        void SaveOrUpdate(Student student);
        void Delete(int Id);
    }
}
