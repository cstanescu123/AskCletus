using AskCletus_BackEnd.Services.DALModels;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public interface IDrinkContext: IAddUser, IGetAllUsers
    {
    }

    public interface IGetAllUsers
    {
        IEnumerable<User> GetAllUsers();
    }

    public interface IAddUser
    {
        User AddUser(User user);
    }
}