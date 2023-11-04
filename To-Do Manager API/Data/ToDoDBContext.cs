using Microsoft.EntityFrameworkCore;
using To_Do_Manager_API.Models;

namespace To_Do_Manager_API.Data
{
    public class ToDoDBContext : DbContext
    {
        public ToDoDBContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<TaskModel> Tasks { get; set;}
    }
}
