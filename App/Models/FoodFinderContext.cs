using Microsoft.EntityFrameworkCore;

namespace FoodFinder.Models
{
  public class FoodFinderContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    
    public FoodFinderContext(DbContextOptions options) : base(options) { }
  }
}