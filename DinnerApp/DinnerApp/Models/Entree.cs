using System.Collections.Generic;

namespace DinnerApp.Models
{
    public class Entree
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Entree()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}