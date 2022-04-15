using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LeDrink.DAL.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        private IDrinkRepo? _drinkRepo;
        private IBottleRepo? _bottleRepo;
        private IRaspiRepo? _raspiRepo;
        private IMixRepo? _mixRepo;

        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
        }

        public IDrinkRepo DrinkRepo => _drinkRepo ?? new DrinkRepo(_db);
        public IBottleRepo BottleRepo => _bottleRepo ?? new BottleRepo(_db);
        public IRaspiRepo RaspiRepo => _raspiRepo ?? new RaspiRepo();
        public IMixRepo MixRepo => _mixRepo ?? new MixRepo(_db);

        public async Task SaveChanges()
        {
            bool saveFailed;
            do
            {
                saveFailed = false;

                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    // Update the values of the entity that failed to save from the store
                    ex.Entries.Single().Reload();
                }

            } while (saveFailed);
        }
    }
}
