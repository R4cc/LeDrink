using LeDrink.DAL.Interfaces;

namespace LeDrink.DAL.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDrinkRepo _drinkRepo;

        public IDrinkRepo DrinkRepo => _drinkRepo = new DrinRepo();
    }
}
