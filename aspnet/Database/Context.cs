using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using aspnet.Database.Models;

namespace aspnet.Database;

public class Context : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Grades> Grade { get; set; }
    public object Grades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=students.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Grades)
            .WithOne(g => g.Student)
            .HasForeignKey(g => g.StudentId);
    }
}