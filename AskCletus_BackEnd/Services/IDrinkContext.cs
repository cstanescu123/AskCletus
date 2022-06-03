using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public interface IDrinkContext: IAddUser, IGetAllUsers, IUpdateUser, IDeleteUser, IGetBars, IGetMyBar, IDeleteBar, 
                     IAddBar, IAddDrink, IGetDrinkHistory, IGetAllHistory, IGetUser, IUpsertGitHubUser, IUpdateUserToken, ILogout, IIsLoggedIn
    {
    }


    public interface IAddDrink
    {
        DrinkHistory AddDrink(DrinkHistory drink);
    }

public interface IGetDrinkHistory
    {
        IEnumerable<DrinkHistory> GetDrinkHistory(int id);
    }

public interface IGetAllHistory
    {
        IEnumerable<DrinkHistory> GetHistory();
    }
public interface IAddBar
    {
        Ingredients AddBar(Ingredients userBar);
    }

    public interface IGetBars
    {
        IEnumerable<Ingredients> GetBars();
    }

    public interface IGetMyBar
    {
        IEnumerable<Ingredients> GetMyBar(int userId);
    }

    public interface IDeleteBar
    {
        Ingredients DeleteBar(int userId);
    }

    public interface IDeleteUser
    {
        AppUsers DeleteUser(int userId);
    }

    public interface IGetAllUsers
    {
        IEnumerable<AppUsers> GetAllUsers();
    }

    public interface IAddUser
    {
        AppUsers AddUser(AppUsers user);
    }
    public interface IUpdateUser
    {
        AppUsers UpdateUser(AppUsers user, int userId);
    }

    public interface IGetUser
    {
        Task<AppUsers> GetUser(int userId);
    }

    public interface IUpsertGitHubUser
    {
        Task<AppUsers> UpsertGithubUser(GithubUser githubUser, string token);
    }

    public interface IUpdateUserToken
    {
        Task<AppUsers> UpdateUserToken(int userId, string token);
    }

    public interface ILogout
    {
        Task Logout(int userId);
    }

    public interface IIsLoggedIn
    {
        bool IsLoggedIn(int userId);
    }
}