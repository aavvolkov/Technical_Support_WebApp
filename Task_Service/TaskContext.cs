using Task_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_Service
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Task> Task { get; set; }

        public TaskDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Tasks.db");
        }
    }
}