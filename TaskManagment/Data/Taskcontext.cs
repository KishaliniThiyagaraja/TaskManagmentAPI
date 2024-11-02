using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TaskManagment.Model;
using System.Linq;


namespace TaskManagment.Data
{
    public class Taskcontext : DbContext
    {

        public Taskcontext(DbContextOptions<Taskcontext> options) : base(options)
        {

        }
        public DbSet<TaskItem> Task { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.TaskItems)
                .WithOne(t => t.Assignee)
                .HasForeignKey(t => t.AssigneeId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Address)
                .WithOne(u => u.User)
                .HasForeignKey<Address>(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<TaskItem>()
                .HasMany(c => c.CheckLists)
                .WithOne(t => t.Task)
                .HasForeignKey(t => t.TaskId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

    