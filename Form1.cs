using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm_Review
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes = new List<Recipe>();
        public Form1()
        {
            InitializeComponent();
            Preload();
        }

        public void Preload()
        {



            Recipe milkshake = new Recipe("Milkshake");

            Ingredient milk = new Ingredient("Milk", 2, "cups");
            Ingredient iceCream = new Ingredient("Ice Cream", 3, "scoops");

            milkshake.AddIngredient(milk);
            milkshake.AddIngredient(iceCream);
            milkshake.AddIngredient(new Ingredient("Chocolate", 1, "bar"));

            recipes.Add(milkshake);

            Recipe hamburger = new Recipe("Hamburger");
            hamburger.AddIngredient(new Ingredient("Beef", .5f, "lb"));
            hamburger.AddIngredient(new Ingredient("Bun", 1, "bun"));
            recipes.Add(hamburger);

            DisplayRecipe(recipes[1]);

        } // Preload();

        public void DisplayRecipes(List<Recipe> recipes)
        {
            foreach (Recipe recipe in recipes)
            {
                DisplayRecipe(recipe);
            }
        }

        public void DisplayRecipe(Recipe recipe)
        {
            rtbDisplay.Text += "Recipe: " + recipe.Name + "\n";
            DisplayIngredients(recipe.Ingredients);
            rtbDisplay.Text += "\n";
        }

        public void DisplayIngredients(List<Ingredient> list)
        {
            foreach (Ingredient ing in list)
            {
                DisplayIngredient(ing);
            }
        }

        public void DisplayIngredient(Ingredient ing)
        {
            rtbDisplay.Text += $"{ing.Name} -" +
            $" {ing.Qty} " +
            $"{ing.Measurement}\n";
        }

    }
}
