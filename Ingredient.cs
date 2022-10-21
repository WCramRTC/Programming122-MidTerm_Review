using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Review
{
    public class Ingredient
    {
        //         Item Name(Strawberries, butter, etc.. )
        // Quantity(like how much of an ingredient. Ex. 1, .5, 1.5 )
        // Type of measurement(oz, lb, dash, etc... ) this can be a string

        string _name;
        float _qty;
        string _measurement;

        public Ingredient(string name, float qty, string measurement)
        {
            _name = name;
            _qty = qty;
            _measurement = measurement;
        }

        public string Name { get => _name; set => _name = value; }
        public float Qty { get => _qty; set => _qty = value; }
        public string Measurement { get => _measurement; set => _measurement = value; }
    } // class

} // namespace
