using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;

namespace LeDrink.DAL.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        private IDrinkRepo? _drinkRepo;
        private IBottleRepo? _bottleRepo;
        private IRaspiRepo? _raspiRepo;

        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
        }

        public IDrinkRepo DrinkRepo => _drinkRepo ?? new DrinkRepo(_db);
        public IBottleRepo BottleRepo => _bottleRepo ?? new BottleRepo(_db);
        public IRaspiRepo RaspiRepo => _raspiRepo ?? new RaspiRepo();

        public async Task SaveChanges()
        {
            await _db.SaveChangesAsync();
        }
    }
}
