
/*
namespace HW3.DAL.Repository.DataBase
{
    public sealed class UserDbContext : DbContext
    {
        public DbSet<Persons>? Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder
            .UseNpgsql("Host=vma-postgres;Database=vma;Username=vma;Password=K8YEW7nZHkX2+cvF; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persons>().Ignore(x => x.Comment);

        }
    }
}*/