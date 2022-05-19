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

        public User UpdateUser(User user)
        {
           var updatedUser = Users.Update(user);
            SaveChanges();
            return updatedUser.Entity;
        }

        public User DeleteUser(int userId)
        {
            var dbUsers = Users.Find(userId);
            if (dbUsers != null)
            {
                var entity = Users.Remove(dbUsers).Entity;
                SaveChanges();
                return entity; 
            }
            return null;
          
        }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost;Initial Catalog=DrinkDb;Integrated Security=True");
        }
    }
}
