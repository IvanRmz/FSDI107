using Microsoft.EntityFrameworkCore;

namespace myCalendar.Models 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Task> TasksTable {get; set;}

        // public DbSet<User> TasksTable {get; set;}
        // public DbSet<Product> TasksTable {get; set;}
    }
}