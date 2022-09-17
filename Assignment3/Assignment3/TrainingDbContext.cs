using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class TrainingDbContext : DbContext
    {
        public readonly string _connectionString;
        public readonly string _assemblyName;

        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-FVRR4GO\\SQLEXPRESS;Database=CSharpB11; User Id=admin; Password=admin1234;";
            _assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
