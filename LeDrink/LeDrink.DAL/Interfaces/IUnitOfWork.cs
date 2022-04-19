using LeDrink.DAL.Data;
using LeDrink.DAL.Repos;

namespace LeDrink.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IBottleRepo BottleRepo { get; }
        IDrinkRepo DrinkRepo { get; }
        IMixRepo MixRepo { get; }
        IRaspiRepo RaspiRepo { get; }
        Task SaveChanges();
    }
}