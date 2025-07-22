using Microsoft.EntityFrameworkCore;
using StudentApp.Models; // ✅ Updated to match model

namespace StudentApp.Data  // ✅ Do not use just "Student"
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
