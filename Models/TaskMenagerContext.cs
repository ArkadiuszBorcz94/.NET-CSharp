using Microsoft.EntityFrameworkCore;

namespace TaskMenager.Models
{
    public class TaskMenagerContext: DbContext
    {


        public TaskMenagerContext(DbContextOptions option) : base(option) 
       
        { 
        




        }
        public DbSet<TaskModel>Tasks { get; set; }

    }
}
