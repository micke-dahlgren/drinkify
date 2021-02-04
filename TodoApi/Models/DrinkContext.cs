using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class DrinkContext : DbContext
    {
        public DrinkContext(DbContextOptions<DrinkContext> options)
            : base(options)
        {
        }

        public DbSet<Drink> Drinks { get; set; }
    }
}