namespace LeDrink.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IDrinkRepo DrinkRepo { get; }
    }
}