using System.Collections.Generic; 

namespace FoodFinder.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public string Description { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}