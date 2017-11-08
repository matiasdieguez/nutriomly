namespace Nutriomly.Models
{
    public class Ingredient 
    {
        public string Emoji { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public FoodTypes FoodType { get; set; }
    }
}
