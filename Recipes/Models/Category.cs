using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool Active { get; set; } 
        public DateTime Created { get; set; }
    }
}