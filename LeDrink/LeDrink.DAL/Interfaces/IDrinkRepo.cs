using LeDrink.DAL.Models;

namespace LeDrink.DAL.Interfaces
{
    public interface IDrinkRepo
    {
        Task<List<Drink>> GetDrinks();
        Task<Drink> GetDrink(int Id);
        Task AddDrink(Drink drink);
        Task RemoveDrink(Drink drink);
        Task UpdateDrink(Drink drink);
        Task<Bottle> GetBottle(int bottleId);
    }
}
