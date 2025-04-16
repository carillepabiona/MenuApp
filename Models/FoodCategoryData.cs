using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Models
{
    public static class FoodCategoryData
    {
        public static List<FoodCategory> GetFoodCategories()
        {
            return new List<FoodCategory>
        {
            new FoodCategory { Name = "Appetizer", DisplayName = "Appetizer", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Rice", DisplayName = "Rice", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Soup", DisplayName = "Soup", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Noodles", DisplayName = "Noodles", Image = "28_Treasures_Menu/Hofan_Noodles.jpg" },
            new FoodCategory { Name = "Noodles Mami", DisplayName = "Noodles Mami", Image = "28_Treasures_Menu/Yang_Chow_Fried_Rice.jpg" },
            new FoodCategory { Name = "Congee", DisplayName = "Congee", Image = "28_Treasures_Menu/Hakaw.jpg" },
            new FoodCategory { Name = "Dimsum", DisplayName = "Dimsum", Image = "28_Treasures_Menu/Kutchay_Dumpling.jpg" },
            new FoodCategory { Name = "Sweet Dessert", DisplayName = "Sweet Dessert", Image = "28_Treasures_Menu/Hakaw.jpg" },
            new FoodCategory { Name = "Vegetables", DisplayName = "Vegetables", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Beef", DisplayName = "Beef", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Pork", DisplayName = "Pork", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Chicken", DisplayName = "Chicken", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Seafood", DisplayName = "Seafood", Image = "28_Treasures_Menu/Polonchay_with_three_mushrooms.jpg" },
            new FoodCategory { Name = "Drinks", DisplayName = "Drinks", Image = "28_Treasures_Menu/Hakaw.jpg" }
        };
        }
    }
}

