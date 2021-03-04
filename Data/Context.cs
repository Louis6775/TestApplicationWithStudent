using Microsoft.EntityFrameworkCore;
using TestApplication3.Models;

namespace TestApplication3.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Values> Values {get; set;}

        public DbSet<Student> Student {get; set;}

        public DbSet<Student_description> Student_description {get; set;}
    }
}