using Nutriomly.Models;
using System;
using System.Linq;

namespace Nutriomly.Data
{
    public static class IngredientManager
    {
        public static Ingredient GetIngredient(Categories category, FoodTypes foodType = FoodTypes.All)
        {
            Ingredient[] list =
            {
                new Ingredient { Emoji = "\U0001f356", Name = "Carne", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Pollo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Atún", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Salmón", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Mariscos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Huevos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Queso", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f356", Name = "Cereal de fibras", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Arroz", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Quinoa", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates},
                new Ingredient { Emoji = "\U0001f356", Name = "Fideos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Croutons", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Lentejas", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Porotos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Garbanzos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Papa", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Batata", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Choclo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Lechuga", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Pepino", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Repollo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Espinaca", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Tomate", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Broccoli", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Cebolla", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Morrón", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Zanahoria", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Calabaza", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f356", Name = "Palta", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f356", Name = "Nueces, pistachos o almendras", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f356", Name = "Aceite de oliva", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f356", Name = "Soja", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f356", Name = "Maní", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f356", Name = "Semillas de chía, girasol o sésamo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f356", Name = "Granola", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Avena", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Banana", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f356", Name = "Manzana", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f356", Name = "Mandarina", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f356", Name = "Granola", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f356", Name = "Gelatina", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Barra de cereal light", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Ensalada de frutas", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Marroc", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Dos cabsha", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Vauquita", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Mini alfajor havanna", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Rodhesia", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Cono de helado", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Biznike", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Tita", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Barra kinder", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Medallón de menta", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Mini conito havanna", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Barra de cereal light", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Barrita aguila", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Té", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f356", Name = "Yogurt descremado", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Desserts }
            };

            list = list.Where(i => i.Category == category).ToArray();

            if (foodType != FoodTypes.All)
                list = list.Where(i => i.FoodType == foodType).ToArray();

            list = list.OrderBy(x => new Random((int)DateTime.Now.Ticks).Next()).ToArray();

            return list[0];
        }
    }
}
