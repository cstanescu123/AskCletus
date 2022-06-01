﻿using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public interface ICocktailClient : IGetRandomDrink, IGetRecentDrink, ISearchByDrinkName, ISearchByIngredientName, ISearchMultipleIngredients
    {
    }

    public interface ISearchMultipleIngredients
    {
        Task<CocktailResponse> SearchByMultiIngredients(string itemOne, string itemTwo, string itemThree, string itemFour);
    }

    public interface ISearchByIngredientName
    {
        Task<CocktailResponse> SearchSearchByIngredient(string search);
    }

    public interface ISearchByDrinkName
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
