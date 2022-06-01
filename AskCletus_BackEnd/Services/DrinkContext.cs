using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using Identity_Back_End.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public class DrinkContext : DbContext, IDrinkContext
    {
       // private readonly string _connectionString;

        public DbSet<AppUsers> AppUsers { get; set; }
        public DbSet<Ingredients> UserIngredient { get; set; }
        public DbSet<DrinkHistory> DrinkHistories { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public DrinkContext()
        {
            //_connectionString = dbConfig.Value.AskCletus;
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
        
        public Ingredients AddBar(Ingredients userIngredient)
        {
            var userEntity = UserIngredient.Add(userIngredient).Entity;
            SaveChanges();
            return userEntity;
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

        public AppUsers DeleteUser(int userId)
        {
            var dbUsers = AppUsers.Find(userId);
            if (dbUsers != null)
            {
                var entity = AppUsers.Remove(dbUsers).Entity;
                SaveChanges();
                return entity; 
            }
            return null;
        }

        public IEnumerable<AppUsers> GetAllUsers()
        {
            return AppUsers;
        }

        public AppUsers AddUser(AppUsers user)
        {
            var userEntity = AppUsers.Add(user).Entity;
            SaveChanges();
            return userEntity;
        }

        public AppUsers UpdateUser(AppUsers user, int userId)
        {
            var dbUser = AppUsers.Find(userId);
            if (dbUser != null)
            {
                dbUser.UserName = user.UserName;
                dbUser.Email = user.Email;
                dbUser.Token = user.Token;
                dbUser.Ingredients = user.Ingredients;


                var entityUser = AppUsers.Update(dbUser).Entity;
                SaveChanges();
                return entityUser;
            }
            return null;
        }

        public async Task<AppUsers> GetUser(int userId)
        {
            return await AppUsers.FindAsync(userId);
        }
        
        public async Task<AppUsers> UpsertGithubUser(GithubUser githubUser, string token)
        {
            var user = await AppUsers.FirstOrDefaultAsync(user => user.Email == githubUser.email);
            if (user == null)
            {
                user = new AppUsers();
                user.UserName = githubUser.login;
                user.Email = githubUser.email;
                user.Authority = Authority.Github;
                user.Token = token;
                user = (await AppUsers.AddAsync(user)).Entity;
            }
            else
            {
                user.Token = token;
                AppUsers.Update(user);
            }
            await SaveChangesAsync();
            return user;
        }


        public async Task<AppUsers> UpdateUserToken(int userId, string token)
        {
            var user = await GetUser(userId);
            user.Token = token;
            AppUsers.Update(user);
            await SaveChangesAsync();
            return user;
        }

        public async Task Logout(int userId)
        {
            await UpdateUserToken(userId, null);
        }

        public bool IsLoggedIn(int userId)
        {
            var user = AppUsers.Find(userId);

            return user != null && user.Token != null;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            // @"Data Source=localhost;Initial Catalog=DrinkDb;Integrated Security=True");

            @"Data Source=askcletus-backenddbserver.database.windows.net;Initial Catalog=AskCletus_BackEnd_db;
            User ID=Carson;Password=chickenSandwich1;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False");

        }
    }
}

