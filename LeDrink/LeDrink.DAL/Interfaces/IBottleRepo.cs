using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IBottleRepo
    {
        Task AddBottle(Bottle bottle);
        Task<List<Bottle>> GetBottles();
        Task<Bottle> GetBottle(int bottleId);
        Task RemoveBottle(Bottle bottle);
        Task UpdateBottle(Bottle bottle);
    }
}