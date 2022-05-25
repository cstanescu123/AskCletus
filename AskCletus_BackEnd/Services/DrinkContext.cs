using AskCletus_BackEnd.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace AskCletus_BackEnd.Services
{
    public class DrinkContext : DbContext, IDrinkContext
    {
        //private readonly string _connectionString;

        public DbSet<User> Users { get; set; }
        public DbSet<Ingredients> UserIngredient { get; set; }
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

        public IEnumerable<DrinkHistory> GetDrinkHistory(int userId)
        {
            var myHistory = DrinkHistories.Where(x => x.UserId == userId);
            return myHistory;
        }

        public IEnumerable<DrinkHistory> GetHistory()
        {
            return DrinkHistories;

        }
        public IEnumerable<Ingredients> GetBars()
        {
            return UserIngredient;
        }
        
        public IEnumerable<Ingredients> GetMyBar(int userId)
        {
            var myBar = UserIngredient.Where(x => x.UserId == userId);
            return myBar;
        }

        public Ingredients DeleteBar(int userId)
        {
            var dbIngredients = UserIngredient.Find(userId);
            if (dbIngredients != null)
            {
                var entity = UserIngredient.Remove(dbIngredients).Entity;
                SaveChanges();
                return entity;
            }
            return null;
        }

        public Ingredients AddBar(Ingredients userIngredient)
        {
            var userEntity = UserIngredient.Add(userIngredient).Entity;
            SaveChanges();
            return userEntity;
        }

        public User GetUser(int id)
        {
            var dbUsers = Users.Find(id);
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