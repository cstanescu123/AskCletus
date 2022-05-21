using AskCletus_BackEnd.Services.DALModels;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public interface IDrinkContext: IAddUser, IGetAllUsers, IUpdateUser, IDeleteUser, IGetMyBar
    {
    }

    public interface IGetMyBar
    {
        IEnumerable<UserBar> GetMyBar();
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
        User UpdateUser(User user);
    }

}//insert interfaces into IDrinkcontext