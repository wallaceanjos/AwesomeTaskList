using AwesomeTaskList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AwesomeTaskList.Infrastructure
{
    public class AwesomeTaskListDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        public AwesomeTaskListDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AwesomeTaskListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
