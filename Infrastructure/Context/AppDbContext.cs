using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class AppDbContext:DbContext
{
    public DbSet<Employer> Employers { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }

    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       // optionsBuilder.UseSqlite("Data Source=app.db");
       optionsBuilder.UseInMemoryDatabase("app-db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employer>().HasKey(e => e.Id);
        base.OnModelCreating(modelBuilder);
    }
}