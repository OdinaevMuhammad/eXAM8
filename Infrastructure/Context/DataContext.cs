using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Context;

public class DataContext:DbContext
{
 public DataContext(DbContextOptions<DataContext> options) : base(options)
 {

 }
 protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            
      

             modelBuilder.Entity<Employee>()
            .HasOne<Job>(s => s.Job)
            .WithMany(g => g.Employees)
            .HasForeignKey(s => s.JobId);

            modelBuilder.Entity<JobHistory>()
            .HasOne<Job>(s => s.Job)
            .WithMany(g => g.JobHistories)
            .HasForeignKey(s => s.JobId);


            modelBuilder.Entity<JobHistory>()
            .HasOne<Employee>(s => s.Employee)
            .WithMany(g => g.JobHistories)
            .HasForeignKey(s => s.EmployeeId);

            modelBuilder.Entity<JobTimeHistory>()
            .HasOne<Employee>(s => s.Employee)
            .WithMany(g => g.JobTimeHistories)
            .HasForeignKey(s => s.EmployeeId);
            
 

            
        

    }
 public DbSet<Employee> Employees {get; set;}
 public DbSet<Job> Jobs {get; set;}
 public DbSet<JobTimeHistory> JobTimeHistories {get; set;}
 public DbSet<JobHistory> JobHistories {get; set;}

}