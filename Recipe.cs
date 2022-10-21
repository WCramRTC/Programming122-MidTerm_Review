using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Review
{
    public class Recipe
    {
        // Fields
        string _name;
        List<Ingredient> _ingredients;
        // Constructor
        public Recipe(string name)
        {
            _name = name;
            _ingredients = new List<Ingredient>();
        } // Recipe

        // Properties
        public string Name { get => _name; set => _name = value; }
        public List<Ingredient> Ingredients { 
            get
                {
                return _ingredients;
                }
        } // Ingredients

        // Methods
        public void AddIngredient(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
        }


    } // class

} // namespace
