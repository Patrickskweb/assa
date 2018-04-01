using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models {
    public enum Dificulty { Easy, Medium, Hard };

    public class Recipe {
        public int Id { get; set; }

        public string Title { get; set; }
        public int Cooking_time { get; set; }
        public int Preparation_time { get; set; }
        public Dificulty Dificulty { get; set; }
        public int Serves { get; set; }
        //category
        public string Description { get; set; }
        //Ingredients model
        //Instructions  model
        public string Image { get; set; } //maybe change to multiple images, idk. 
        public bool Status { get; set; } //Publish = true, not publish and save in user profile = false

    }
}