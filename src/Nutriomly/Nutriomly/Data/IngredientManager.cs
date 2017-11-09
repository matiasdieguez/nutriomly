using Nutriomly.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nutriomly.Data
{
    public static class IngredientManager
    {
        public static Ingredient GetIngredient(Categories category, FoodTypes foodType = FoodTypes.All, List<Ingredient> omit = null)
        {
            Ingredient[] list =
            {
                new Ingredient { Emoji = "\U0001f356", Name = "Carne", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f414", Name = "Pollo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f41f", Name = "Atún", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f41f", Name = "Salmón", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f419", Name = "Mariscos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f344", Name = "Hongos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f95a", Name = "Huevos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f9c0", Name = "Queso", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Proteins },
                new Ingredient { Emoji = "\U0001f33e", Name = "Cereal de fibras", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f35a", Name = "Arroz", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f33e", Name = "Quinoa", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates},
                new Ingredient { Emoji = "\U0001f35d", Name = "Fideos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f35e", Name = "Croutons", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f35c", Name = "Lentejas", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f375", Name = "Porotos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f375", Name = "Garbanzos", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f954", Name = "Papa", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f360", Name = "Batata", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f33d", Name = "Choclo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f957", Name = "Lechuga", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f952", Name = "Pepino", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f346", Name = "Berenjena", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f957", Name = "Repollo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f957", Name = "Espinaca", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f345", Name = "Tomate", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f952", Name = "Broccoli", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f952", Name = "Cebolla", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f336", Name = "Morrón", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f955", Name = "Zanahoria", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f383", Name = "Calabaza", Category = Categories.LunchAndDinner, FoodType = FoodTypes.Vegetables },
                new Ingredient { Emoji = "\U0001f951", Name = "Palta", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f330", Name = "Nueces, pistachos o almendras", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f944", Name = "Aceite de oliva", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f944", Name = "Aceite de girasol", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f330", Name = "Semillas de chía, girasol o sésamo", Category = Categories.LunchAndDinner, FoodType = FoodTypes.EssentialFattyAcids },
                new Ingredient { Emoji = "\U0001f944", Name = "Granola", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f944", Name = "Avena", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Carbohydrates },
                new Ingredient { Emoji = "\U0001f353", Name = "Frutillas", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f347", Name = "Uvas", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f95d", Name = "Kiwi", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f352", Name = "Bayas", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f351", Name = "Durazno", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f34d", Name = "Ananá", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f350", Name = "Pera", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f34c", Name = "Banana", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f34e", Name = "Manzana", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f34a", Name = "Mandarina", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Fruits },
                new Ingredient { Emoji = "\U0001f944", Name = "Gelatina", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Barra de cereal light", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f379", Name = "Ensalada de frutas", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Marroc", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Dos cabsha", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Vauquita", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Mini alfajor havanna", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Rodhesia", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f366", Name = "Cono de helado", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Biznike", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Tita", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Barrita kinder", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Medallón de menta", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Mini conito havanna", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f36b", Name = "Barrita aguila", Category = Categories.Tentempie, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U00002615", Name = "Té", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Desserts },
                new Ingredient { Emoji = "\U0001f95b", Name = "Yogurt descremado", Category = Categories.BreakfastAndTea, FoodType = FoodTypes.Desserts }
            };

            if (omit != null)
                list = list.Where(item => omit.Any(o => o.Name!=item.Name)).ToArray();

            list = list.Where(i => i.Category == category).ToArray();

            if (foodType != FoodTypes.All)
                list = list.Where(i => i.FoodType == foodType).ToArray();

            list = list.OrderBy(x => new Random((int)DateTime.Now.Ticks).Next()).ToArray();

            return list[0];
        }
    }
}
