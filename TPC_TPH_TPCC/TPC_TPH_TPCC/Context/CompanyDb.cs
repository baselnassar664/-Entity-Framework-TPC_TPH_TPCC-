using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPC_TPH_TPCC.Entities;

namespace TPC_TPH_TPCC.Context
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer("server=.;database=CompanyyDb;trusted_connection=true");


        //for TPH//دمجهم في جدول واحد
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
               
            base.OnModelCreating(modelBuilder);
        }

        //TPCC
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }

        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }


        //TPH //دمجهم في جدول واحد

        public DbSet<Employee> Employees { get; set; }
    }
}
