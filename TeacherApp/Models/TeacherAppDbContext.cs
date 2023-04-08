using Microsoft.EntityFrameworkCore;

namespace TeacherApp.Models
{
    public class TeacherAppDbContext : DbContext
    {
        public TeacherAppDbContext(DbContextOptions<TeacherAppDbContext> options)
       : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
