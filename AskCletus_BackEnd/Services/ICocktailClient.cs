using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public interface ICocktailClient
    {
        Task<CocktailResponse> GetRecent();
    }
}