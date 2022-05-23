using AskCletus_BackEnd.Services.DALModels;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services
{
    public interface IHistoryContext : IAddDrink, IGetDrinkHistory, IGetAllHistory
    {
        DrinkHistory AddDrink(DrinkHistory drink);
    }
    public interface IAddDrink
    {
        DrinkHistory AddDrink(DrinkHistory drink);
    }

    public interface IGetDrinkHistory
    {
        DrinkHistory GetDrinkHistory(int id);
    }

    public interface IGetAllHistory
    {
        IEnumerable<DrinkHistory> GetHistory();
    }
}
