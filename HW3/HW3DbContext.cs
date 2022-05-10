using HW3.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace HW3
{
    public class HW3DbContext : DbContext
    {
        
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }
        
        public HW3DbContext(DbContextOptions<HW3DbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
