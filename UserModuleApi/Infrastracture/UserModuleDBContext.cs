using Microsoft.EntityFrameworkCore;
using System;
using UserModuleApi.Models;

namespace UserModuleApi.Infrastracture
{
    public class UserModuleDBContext : DbContext
    {
        public UserModuleDBContext(DbContextOptions<UserModuleDBContext> options)
          : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Name = "Ruben",
                Address = "Yerevan",
                BirthDate = 1998,
                Created = DateTime.Now,
                Info = "Doc",
                IsActive = true,
                UserName = "Ruben@gmail.com"
            },
            new User()
            {
                Id = 2,
                Name = "Mukuch",
                Address = "Alaverdi",
                BirthDate = 2001,
                Created = DateTime.Now,
                Info = "Custom",
                IsActive = true,
                UserName = "Mko@gmail.com"
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}