using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models.Data
{
    public class UniversityContext : DbContext
    { public DbSet<Student> Student { get; set; }
        static public int count = 0;
        static private UniversityContext Unicontext ;
        private UniversityContext (DbContextOptions o): base(o) {
            count++;
        }
        static public UniversityContext Instantiate_universityContext()
        {   if (Unicontext == null)
            {

                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\Firas\Desktop\database.db");
                Unicontext = new UniversityContext(optionsBuilder.Options);
            }

                return Unicontext ;   
        }
    }
}
