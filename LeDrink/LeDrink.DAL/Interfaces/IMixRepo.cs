using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IMixRepo
    {
        Task AddMix(Mix mix);
        Task<List<Mix>> GetAll();
        Task<Mix> GetMix(int mixId);
        Task RemoveMix(Mix mix);
        Task UpdateMix(Mix mix);
        Task<List<Mix>> GetMixesFromDrinkId(int drinkId);
    }
}