using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public interface ICocktailClient : IGetRandomDrink, IGetRecentDrink, ISearchSingleDrink
    {
    }

    public interface ISearchSingleDrink
    {
        Task<CocktailResponse> SearchSearchByName(string search);
    }

    public interface IGetRecentDrink
    {
        Task<CocktailResponse> GetRecent();
    }

    public interface IGetRandomDrink
    {
        Task<CocktailResponse> GetRandomDrink();
    }
}
