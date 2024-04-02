namespace Menu.Models
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<FlavorIngredients>? FlavorIngredients { get; set; }
    }
}
