using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.DataAccess
{
    public class TodoDbContext:DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=MyTodoDB;User=root;Password=root;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id=1,FullName="Author 1",AddressNo="15",Street="Street 1",City="City1"},
                new Author { Id=2,FullName="Author 2",AddressNo="25",Street="Street 2",City="City2" }
            });
            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
            {
                Id = 1,
                Title = "Title A",
                Description = "Dis A",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1,

            },
            new Todo
            {
                Id = 2,
                Title = "Title B",
                Description = "Dis B",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId= 1,

            },
            new Todo
            {
                Id = 3,
                Title = "Title C",
                Description = "Dis C",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId= 2,

            }
            });
        }
    }
}
