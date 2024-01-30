using ConsoleApp18.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp18.DataAccess
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JT5F1N0\SQLEXPRESS;Database=EFTask;Trusted_Connection=true;");
        }
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<StudentGroup> StudentGroups { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<StudentGroup>()
                .HasKey(sg => new { sg.GroupId, sg.StudentId });

            modelbuilder.Entity<Student>()
                .HasMany(s => s.StudentGroups)
                .WithOne(sg => sg.Student)
                .HasForeignKey(sg => sg.StudentId);

            modelbuilder.Entity<Group>()
                .HasMany(g => g.StudentGroups)
                .WithOne(sg => sg.Group)
                .HasForeignKey(sg => sg.GroupId);
        }
    }
}