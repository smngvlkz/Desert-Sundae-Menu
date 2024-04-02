namespace Menu.Models
{
    public class Flavors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

        public List<FlavorIngredients>? FlavorIngredients { get; set; }
    }
}
