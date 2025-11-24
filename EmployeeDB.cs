using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace _243506_Labtask10_VP
{
    class EmployeeDB: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=EmployeeDBMS; Trusted_Connection=True;");
        }

        public DbSet<Employee> employee{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e=>e.Id)
                .ValueGeneratedNever();

            base.OnModelCreating(modelBuilder);
        }
    }
}
