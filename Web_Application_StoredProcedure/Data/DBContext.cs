using Microsoft.EntityFrameworkCore;
using Web_Application_StoredProcedure.Models;

namespace Web_Application_StoredProcedure.Data
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var conncetionString = string.Format(@"Data Source=DESKTOP-ALP065B\SQLEXPRESS;Initial Catalog=CRUD_DB;Integrated Security=True;Trust Server Certificate=True");
            options.UseSqlServer(conncetionString);
        }
        public DbSet<Student>Students { get; set; }
    }
}
