using AskCletus_BackEnd.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace AskCletus_BackEnd.Services
{
    public class DrinkContext : DbContext, IDrinkContext
    {
       // private readonly string _connectionString;

        public DbSet<AppUser> Appusers { get; set; }
        public DbSet<Ingredients> UserIngredient { get; set; }
        public DbSet<DrinkHistory> DrinkHistories { get; set; }

        public DrinkContext()
        {
            //_connectionString = dbConfig.Value.AskCletus;
        }

        public IEnumerable<AppUser> GetAllUsers()
        {
            return Appusers;
        }

        public AppUser AddUser(AppUser user)
        {
            var userEntity = Appusers.Add(user).Entity;
            SaveChanges();
            return userEntity;
        }

        public AppUser DeleteUser(int userId)
        {
            var dbUsers = Appusers.Find(userId);
            if (dbUsers != null)
            {
                var entity = Appusers.Remove(dbUsers).Entity;
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

        public Ingredients DeleteBar(int ingredientId)
        {
            var dbIngredients = UserIngredient.Find(ingredientId);
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

        public AppUser GetUser(int id)
        {
            var dbUsers = Appusers.Find(id);
            return dbUsers;
        }

        public AppUser UpdateUser(AppUser user, int userId)
        {
            var dbUser = Appusers.Find(userId);
            if (dbUser != null)
            {
                dbUser.UserName = user.UserName;
                dbUser.Email = user.Email;
                dbUser.Token = user.Token;
                dbUser.Ingredients = user.Ingredients;


                var entityUser = Appusers.Update(dbUser).Entity;
                SaveChanges();
                return entityUser;
            }
            return null;
        }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            //@"Data Source=localhost;Initial Catalog=DrinkDb;Integrated Security=True");
            // this._connectionString);
            @"Data Source=askcletus-backenddbserver.database.windows.net;Initial Catalog=AskCletus_BackEnd_db;
            User ID=Carson;Password=chickenSandwich1;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False");

        }
    }
}