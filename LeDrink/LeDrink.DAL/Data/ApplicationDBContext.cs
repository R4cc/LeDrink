using LeDrink.DAL.Models;
using LeDrink.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
