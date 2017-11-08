
using Nutriomly.Data;
using Nutriomly.Models;
using Nutriomly.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nutriomly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var breakfastStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            var breakfastEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 59, 59);

            var morningTentempieStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0);
            var morningTentempieEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 59, 59);

            var lunchStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            var lunchEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 59, 59);

            var teaStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
            var teaEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 59, 59);

            var eveningTentempieStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
            var eveningTentempieEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 59, 59);

            var dinnerStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);
            var dinnerEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 00, 0);

            switch (DateTime.Now)
            {
                case DateTime t when (t >= breakfastStart && t <= breakfastEnd):
                    TimeFor.Text = AppResources.TimeFor + AppResources.Breakfast;
                    GenerateFood(Categories.BreakfastAndTea);
                    break;
                case DateTime t when (t >= morningTentempieStart && t <= morningTentempieEnd):
                    TimeFor.Text = AppResources.TimeFor + AppResources.MorningTentempie;
                    GenerateFood(Categories.Tentempie);
                    break;
                case DateTime t when (t >= lunchStart && t <= lunchEnd):
                    TimeFor.Text = AppResources.TimeFor + AppResources.Lunch;
                    GenerateFood(Categories.LunchAndDinner);
                    break;
                case DateTime t when (t >= teaStart && t <= teaEnd):
                    TimeFor.Text = AppResources.TimeFor + AppResources.Tea;
                    GenerateFood(Categories.BreakfastAndTea);
                    break;
                case DateTime t when (t >= eveningTentempieStart && t <= eveningTentempieEnd):
                    TimeFor.Text = AppResources.TimeFor + AppResources.EveningTentempie;
                    GenerateFood(Categories.Tentempie);
                    break;
                case DateTime t when (t >= dinnerStart && t <= dinnerEnd):
                    TimeFor.Text = AppResources.TimeFor + AppResources.Dinner;
                    GenerateFood(Categories.LunchAndDinner);
                    break;
                default:
                    TimeFor.Text = "\U0001f376 " + AppResources.TimeFor + AppResources.Water;
                    break;
            }

        }

        public void GenerateFood(Categories category)
        {
            if (category == Categories.LunchAndDinner)
            {
                var proteins = IngredientManager.GetIngredient(category, FoodTypes.Proteins);
                var carbohydrates = IngredientManager.GetIngredient(category, FoodTypes.Carbohydrates);
                var vegetables = IngredientManager.GetIngredient(category, FoodTypes.Vegetables);
                var essentialFats = IngredientManager.GetIngredient(category, FoodTypes.EssentialFattyAcids);

                Proteins.Text = proteins.Emoji + " " + AppResources.Quarter + proteins.Name;
                Carbohydrates.Text = carbohydrates.Emoji + " " + AppResources.Quarter + carbohydrates.Name;
                Vegetables.Text = vegetables.Emoji + " " + AppResources.Half + vegetables.Name;
                EssentialFattyAcids.Text = essentialFats.Emoji + " " + essentialFats.Name;
            }

            if (category == Categories.Tentempie)
            {
                var dessert = IngredientManager.GetIngredient(category, FoodTypes.Desserts);
                Proteins.Text = dessert.Emoji + " " + dessert.Name;
            }

            if (category == Categories.BreakfastAndTea)
            {
                var dessert = IngredientManager.GetIngredient(category, FoodTypes.Desserts);
                var carbohydrates = IngredientManager.GetIngredient(category, FoodTypes.Fruits);

                Proteins.Text = dessert.Emoji + " " + dessert.Name;
                Carbohydrates.Text = carbohydrates.Emoji + " " + carbohydrates.Name;
            }
        }
    }
}