using LeDrink.DAL.Data;

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