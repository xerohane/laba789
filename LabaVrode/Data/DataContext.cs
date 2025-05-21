using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaVrode.Data
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\праймгод\\Desktop\\jsadfasdf\\db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Login = "admin", Password = "123", isAdmin = true },
                new User() { Id = 2, Login = "user1", Password = "321", isAdmin = false }
            );
        }

        public DbSet<Marks> Marks { get; set; }
    }
}
