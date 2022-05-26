using AskCletus_BackEnd.Services.DALModels;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public interface IDrinkContext: IAddUser, IGetAllUsers, IUpdateUser, IDeleteUser, IGetBars, IGetMyBar, IDeleteBar, IAddBar, IGetUser, IAddDrink, IGetDrinkHistory, IGetAllHistory
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
        User DeleteUser(int userId);
    }

    public interface IGetAllUsers
    {
        IEnumerable<User> GetAllUsers();
    }

    public interface IAddUser
    {
        User AddUser(User user);
    }
    public interface IUpdateUser
    {
        User UpdateUser(User user, int userId);
    }
    public interface IGetUser
    {
        User GetUser(int userId);
    }

}