using Microsoft.EntityFrameworkCore;

namespace chefs_and_dishes.Models
{
    public class MyContext : DbContext 
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<Chef> Chefs {get;set;}
        public DbSet<Dish> Dishes {get;set;}
    }
}