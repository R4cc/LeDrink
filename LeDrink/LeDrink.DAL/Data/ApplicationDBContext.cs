using LeDrink.DAL.Models;
using LeDrink.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LeDrink.DAL.Data
{
    public  class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Mix> Mixes { get; set; }
        public DbSet<Bottle> Bottles { get; set; }
    }
}
