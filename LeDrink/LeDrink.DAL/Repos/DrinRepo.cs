using LeDrink.DAL.Data;
using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Models;
using LeDrink.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDrink.DAL.Repos
{
    public class DrinRepo : IDrinkRepo
    {
        private readonly ApplicationDBContext _applicationDbContext;

        public DrinRepo(ApplicationDBContext applicationDBContext)
        {
            _applicationDbContext = applicationDBContext;
        }

        public Task AddDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public Task<Drink> GetDrink(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Drink>> GetDrinks()
        {
            throw new NotImplementedException();
        }

        public Task RemoveDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public Task<Bottle> GetBottle(int bottleId)
        {
            throw new NotImplementedException();
            //return _applicationDbContext.
        }
    }
}
