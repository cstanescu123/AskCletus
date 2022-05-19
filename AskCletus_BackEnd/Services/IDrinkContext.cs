namespace AskCletus_BackEnd.Services.DALModels
{
    public interface IDrinkContext: IAddUser
    {
    }

    public interface IAddUser
    {
        User AddUser(User user);
    }
}
