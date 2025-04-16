using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Models
{
    public class FoodCategory
    {
        public string Name { get; set; }  // used for filterCategory('...')
        public string DisplayName { get; set; }  // shown as <p> text
        public string Image { get; set; }  // image src
    }

}
