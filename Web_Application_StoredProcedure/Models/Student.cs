using System.ComponentModel.DataAnnotations;

namespace Web_Application_StoredProcedure.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Gender { get; set; }
        public string Standard { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Note { get; set; }
    }
}
