using AskCletus_BackEnd.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public class DrinkContext : DbContext, IDrinkContext
    {
        //private readonly string _connectionString;

        public DbSet<User> Users { get; set; }
        public DbSet<UserBar> UserBars { get; set; }
        public DbSet<DrinkHistory> DrinkHistories { get; set; }

        //public DrinkContext(IOptions<DBConfig> dbConfig)
        //{
        //    _connectionString = dbConfig.Value.Cletus;
        //}

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

        public DrinkHistory AddDrink(DrinkHistory drink)
        {
            var drinkEntity = DrinkHistories.Add(drink).Entity;
            SaveChanges();
            return drinkEntity;
        }

        public DrinkHistory GetDrinkHistory(int id)
        {
            var dbDrink = DrinkHistories.Find(id);
            if (dbDrink != null)
            {
                dbDrink.DrinkId = id;
                return dbDrink;
            }
            return null;
        }

        public IEnumerable<DrinkHistory> GetHistory()
        {
            return DrinkHistories;

        }
        public IEnumerable<UserBar> GetBars()
        {
            return UserBars;
        }
        
        public UserBar GetMyBar(int userId)
        {
            var bar = UserBars.Find(userId);
            return bar;
        }

        public UserBar DeleteBar(int userId)
        {
            var dbUserBar = UserBars.Find(userId);
            if (dbUserBar != null)
            {
                var entity = UserBars.Remove(dbUserBar).Entity;
                SaveChanges();
                return entity;
            }
            return null;
        }

        public UserBar AddBar(UserBar userBar)
        {
            var userEntity = UserBars.Add(userBar).Entity;
            SaveChanges();
            return userEntity;
        }

        public User GetUser(int ticketId)
        {
            var dbUsers = Users.Find(ticketId);
            return dbUsers;
        }

        public User UpdateUser(User user, int userId)
        {
            var dbUser = Users.Find(userId);
            if (dbUser != null)
            {
                dbUser.UserName = user.UserName;
                dbUser.Email = user.Email;
                dbUser.Token = user.Token;
                dbUser.Ingredients = user.Ingredients;

                var entityUser = Users.Update(dbUser).Entity;
                SaveChanges();
                return entityUser;
            }
            return null;
        }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost;Initial Catalog=DrinkDb;Integrated Security=True");
             //this._connectionString);
        }
     }

}