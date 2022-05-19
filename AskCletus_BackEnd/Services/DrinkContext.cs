using AskCletus_BackEnd.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public class DrinkContext : DbContext, IDrinkContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserBar> UserBars { get; set; }
        public DbSet<DrinkHistory> DrinkHistories { get; set; }

        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }

        public User AddUser(User user)
        {
            var userEntity = Users.Add(user).Entity;
            SaveChanges();
            return userEntity;
        }








        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost;Initial Catalog=DrinkDb;Integrated Security=True");
        }
    }
}
