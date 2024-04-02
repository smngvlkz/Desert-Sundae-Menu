namespace Menu.Models
{
    public class FlavorIngredients
    {
        public int FlavorId { get; set; }
        public Flavors Flavor { get; set; }
        public int IngredientId { get; set; }
        public Ingredients Ingredients { get; set; }
    }
}
