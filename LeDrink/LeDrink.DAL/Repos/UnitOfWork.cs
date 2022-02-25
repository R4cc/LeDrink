using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;

namespace LeDrink.DAL.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        private IDrinkRepo? _drinkRepo;

        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
        }

        public IDrinkRepo DrinkRepo => _drinkRepo ?? new DrinRepo(_db);
    }
}
