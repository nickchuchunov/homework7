using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractMeneger
{
    public class ContractMenegerDatabaseContext: DbContext
    {
       public ContractMenegerDatabaseContext() { }

        public DbSet<ContractDatabase> ContractDatabases { get; set; }
        public DbSet<CustomerDatabase> CustomerDatabases { get; set; }
        public DbSet<EmployeDatabase> EmployeDatabases { get; set; }
        public DbSet<InvoiceDatabase> InvoiceDatabases { get; set; }
        public DbSet<InvoiceTaskDatabase> InvoiceTaskDatabases { get; set; }
        public DbSet<TaskDatabase> TaskDatabases { get; set; }
        public DbSet<TaskEmployeeDatabase> TaskEmployeeDatabases { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ec2-54-228-99-58.eu-west-1.compute.amazonaws.com; Database=d43u7ksft9lf8b; User Id=jyneyajllhouta;  Password=6578a96a7b4d70f700f5047998136d6b59479ec5eb59614c1fb3ef59caa773f4; Port=5432; sslmode=Require; Trust Server Certificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractDatabase>();
            modelBuilder.Entity<CustomerDatabase>();
            modelBuilder.Entity<EmployeDatabase>();
            modelBuilder.Entity<InvoiceDatabase>();
            modelBuilder.Entity<InvoiceTaskDatabase>();
            modelBuilder.Entity<TaskDatabase>();
            modelBuilder.Entity<TaskEmployeeDatabase > ();




            //   Driver={PostgreSQL ODBC Driver(UNICODE)}; Server=PostgreSQL; Port=5432; Database=d73lt373eqvl1k; UID=postgres://lzmixtudpnbaym:b51dfc9664163a19c61cd599e85fb1dd4e928a78925641e958993dd21eb76901@ec2-3-248-103-75.eu-west-1.compute.amazonaws.com:5432/d73lt373eqvl1k; PWD=b51dfc9664163a19c61cd599e85fb1dd4e928a78925641e958993dd21eb76901

            //Host=ec2-54-228-99-58.eu-west-1.compute.amazonaws.com; Database=d43u7ksft9lf8b; User=jyneyajllhouta;  Password=6578A96a7b4d70f700f5047998136d6b59479ec5eb59614c1fb3ef59caa773f4; Port=5432;"


            // sslmode=Require; Trust Server Certificate=true 6578a96a7b4d70f700f5047998136d6b59479ec5eb59614c1fb3ef59caa773f4



        }










    }
}
