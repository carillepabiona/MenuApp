using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Models
{
    public static class FoodItemData
    {
        public static List<FoodItem> GetFoodItems()
        {
            return new List<FoodItem>
            {
            // Noodles
            new FoodItem { Name = "Seafood Pancit Canton", Category = "Noodles", Price = 378, Image = "28_Treasures_Menu/SeafoodPancit.png", Description = "A savory seafood stir-fried noodle dish with a medley of fresh ingredients." },
            new FoodItem { Name = "Pancit Canton", Category = "Noodles", Price = 378, Image = "28_Treasures_Menu/Pancit_Canton.png", Description = "Classic stir-fried noodles with vegetables, meat, and seafood." },
            new FoodItem { Name = "Fried Noodles with Shredded Meat", Category = "Noodles", Price = 398, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Stir-fried noodles with a variety of meats and a rich, savory flavor." },
            new FoodItem { Name = "Soy Noodles with Bean Sprout", Category = "Noodles", Price = 328, Image = "28_Treasures_Menu/SoyNoodles.png", Description = "Lightly stir-fried soy noodles with fresh bean sprouts for a satisfying, crunchy texture." },
            new FoodItem { Name = "Fried Beef & Vegetables", Category = "Noodles", Price = 358, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Stir-fried HOFAN noodles with tender beef or asado and mixed vegetables." },
            new FoodItem { Name = "Asado HOFAN & Beansprout", Category = "Noodles", Price = 358, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Stir-fried HOFAN noodles with savory beef or asado and crisp bean sprouts." },
            new FoodItem { Name = "Misua Guisado", Category = "Noodles", Price = 368, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A classic Filipino noodle dish with vegetables, meat, and savory seasoning." },
    
            // NOODLE MAMI
            new FoodItem { Name = "28 Treasures Special", Category = "Noodles Mami", Price = 258, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A special noodle dish featuring a variety of flavors and ingredients." },
            new FoodItem { Name = "Beef with Shrimp Wanton", Category = "Noodles Mami", Price = 258, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Tender beef paired with savory shrimp wantons in a rich broth." },
            new FoodItem { Name = "Shrimp Wanton", Category = "Noodles Mami", Price = 238, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Delicate shrimp-filled wantons in a flavorful broth." },
            new FoodItem { Name = "Braised Beef Brisket", Category = "Noodles Mami", Price = 258, Image = "28_Treasures_Menu/BraisedBeefBrisket.png", Description = "Tender braised beef brisket served with noodles in a savory broth." },
            new FoodItem { Name = "Fish Ball & Fish Cake", Category = "Noodles Mami", Price = 228, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Fish balls and fish cakes in a light and flavorful broth." },
            new FoodItem { Name = "Pork Meatballs", Category = "Noodles Mami", Price = 228, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Juicy pork meatballs in a warm, savory noodle soup." },
            new FoodItem { Name = "Asado", Category = "Noodles Mami", Price = 268, Image = "28_Treasures_Menu/AsadoPork.png", Description = "Tender asado served with noodles in a flavorful broth." },
            new FoodItem { Name = "Shredded Chicken", Category = "Noodles Mami", Price = 228, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Shredded chicken in a savory noodle broth, perfect for a light meal." },
            new FoodItem { Name = "Roast Duck", Category = "Noodles Mami", Price = 388, Image = "28_Treasures_Menu/Chopsuey.png.jpg", Description = "Savory roast duck served with noodles in a rich broth." },
            new FoodItem { Name = "Seasonal Vegetables with Oyster Sauce", Category = "Noodles Mami", Price = 258, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A healthy combination of seasonal vegetables cooked in oyster sauce, served with noodles." },

           // CONGEE
            new FoodItem { Name = "Fish Fillet", Category = "Congee", Price = 288, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A warm, comforting congee with tender fish fillet." },
            new FoodItem { Name = "Shrimp Balls", Category = "Congee", Price = 256, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Delicious shrimp balls served with soft congee." },
            new FoodItem { Name = "Sliced Chicken with Mushroom", Category = "Congee", Price = 238, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Sliced chicken and savory mushrooms in a hearty congee." },
            new FoodItem { Name = "Pork Meatball (Bola-Bola)", Category = "Congee", Price = 238, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Succulent pork meatballs in a comforting congee." },
            new FoodItem { Name = "Sliced Pork with Century Egg", Category = "Congee", Price = 248, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Sliced pork and century egg in a flavorful congee." },
            new FoodItem { Name = "Asado and Salted Egg", Category = "Congee", Price = 288, Image = "28_Treasures_Menu/dChopsuey.png", Description = "Savory asado and salted egg served in a rich congee." },

            // SWEET DESSERT
            new FoodItem { Name = "Butchi (4 pcs)", Category = "Sweet Dessert", Price = 118, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Deep-fried glutinous rice balls filled with sweet mung bean paste." },
            new FoodItem { Name = "Mango Sago", Category = "Sweet Dessert", Price = 128, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A sweet mango dessert with sago pearls for a refreshing treat." },
            new FoodItem { Name = "Black Gulaman", Category = "Sweet Dessert", Price = 88, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A cool, refreshing dessert made with black gulaman jelly." },
            new FoodItem { Name = "Black Gulaman with Lychee", Category = "Sweet Dessert", Price = 98, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A refreshing mix of black gulaman jelly and juicy lychee." },

            // DIMSUM
            new FoodItem { Name = "Prawn Hakaw (4 pcs)", Category = "Dimsum", Price = 158, Image = "28_Treasures_Menu/Hawak.png", Description = "Delicate steamed dumplings filled with succulent prawn." },
            new FoodItem { Name = "Pork and Shrimp Siomai (4 pcs)", Category = "Dimsum", Price = 158, Image = "28_Treasures_Menu/Pork_Shrimp_Siomai.png", Description = "A flavorful mix of pork and shrimp wrapped in a soft dumpling wrapper." },
            new FoodItem { Name = "Sharksfin Dumpling (4 pcs)", Category = "Dimsum", Price = 138, Image = "28_Treasures_Menu/Sharsfin_Dumpling.png", Description = "Steamed dumplings filled with tender sharksfin and other savory fillings." },
            new FoodItem { Name = "Japanese Siomai (4 pcs)", Category = "Dimsum", Price = 138, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Japanese-inspired siomai with a delicate filling and soft wrapper." },
            new FoodItem { Name = "Kutchay Dumpling (3 pcs)", Category = "Dimsum", Price = 138, Image = "28_Treasures_Menu/Cuchay_Dumpling.png", Description = "Steamed dumplings filled with savory kutchay (Chinese chives)." },
            new FoodItem { Name = "Beancurd Roll (3 pcs)", Category = "Dimsum", Price = 148, Image = "28_Treasures_Menu/Bean_Curd_Roll.png", Description = "Crispy beancurd rolls filled with a mix of meat and vegetables." },
            new FoodItem { Name = "Beef Ball (3 pcs)", Category = "Dimsum", Price = 148, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Tender beef balls served in a savory sauce." },
            new FoodItem { Name = "Spareribs with Taosi", Category = "Dimsum", Price = 158, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Delicious spareribs simmered in a flavorful taosi (fermented bean paste) sauce." },
            new FoodItem { Name = "Chicken Feet", Category = "Dimsum", Price = 138, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Steamed chicken feet with a savory sauce, a popular dimsum treat." },
            new FoodItem { Name = "Jumbo Siopao (1 pc)", Category = "Dimsum", Price = 158, Image = "28_Treasures_Menu/JumboSiopao.png", Description = "Large steamed bun filled with savory asado filling." },
            new FoodItem { Name = "Asado Siopao (3 pcs)", Category = "Dimsum", Price = 138, Image = "28_Treasures_Menu/Chopsuey.png", Description = "Soft steamed buns filled with flavorful asado pork." },
            new FoodItem { Name = "Bola Siopao (3 pcs)", Category = "Dimsum", Price = 138, Image = "28_Treasures_Menu/default.jpg", Description = "Steamed buns filled with savory pork and egg filling." },
            new FoodItem { Name = "Mantao (Fry or Steam, 6 pcs)", Category = "Dimsum", Price = 128, Image = "28_Treasures_Menu/default.jpg", Description = "Soft steamed or fried buns served as a perfect side or snack." },

            // SOUP
            new FoodItem { Name = "Polonchai Seafood Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/PolonchayTofuwithMushroom.png", Description = "A flavorful seafood soup with fresh ingredients." },
            new FoodItem { Name = "Seafood Beancurd Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "A hearty soup with seafood and soft beancurd." },
            new FoodItem { Name = "West Lake Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "A traditional Chinese soup with delicate flavors." },
            new FoodItem { Name = "Crabmeat Sweet Corn Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "A sweet and savory soup with crabmeat and corn." },
            new FoodItem { Name = "Minced Chicken Corn Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "A comforting soup made with minced chicken and sweet corn." },
            new FoodItem { Name = "Bird’s Nest Quail Egg Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/Bird'sNestSoup.png", Description = "A luxurious soup made with bird’s nest and quail eggs." },
            new FoodItem { Name = "Bird’s Nest Crabmeat Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/Bird'sNestSoup.png", Description = "A rich soup combining bird’s nest and crabmeat." },
            new FoodItem { Name = "Hot & Sour Soup", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "A spicy and tangy soup with a variety of vegetables." },
            new FoodItem { Name = "Hototai", Category = "Soup", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "A traditional soup with various meats and vegetables." },

            // APPETIZER
            new FoodItem { Name = "Pan-Fried Oyster Cake", Category = "Appetizer", Price = 298, Image = "28_Treasures_Menu/default.jpg", Description = "A crispy, golden oyster cake, fried to perfection." },
            new FoodItem { Name = "X.O. Raddish Cake", Category = "Appetizer", Price = 288, Image = "28_Treasures_Menu/default.jpg", Description = "Savory radish cake with a flavorful X.O. sauce." },
            new FoodItem { Name = "Shanghai Fried Rolls", Category = "Appetizer", Price = 298, Image = "28_Treasures_Menu/ShanghaiRolls.png", Description = "Crispy fried rolls filled with savory filling." },
            new FoodItem { Name = "Wanton (Fry or Steam)", Category = "Appetizer", Price = 248, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy fried or steamed wantons filled with savory meat." },
            new FoodItem { Name = "Salted Egg Tofu", Category = "Appetizer", Price = 258, Image = "28_Treasures_Menu/Salted_Egg_Tofu.png", Description = "Crispy tofu topped with salted egg for a unique flavor." },
            new FoodItem { Name = "Salt and Pepper Tofu", Category = "Appetizer", Price = 258, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy tofu seasoned with salt and pepper for a bold taste." },

     
           // RICE
            new FoodItem { Name = "Seafood Fried Rice", Category = "Rice", Price = 298, Image = "28_Treasures_Menu/default.jpg", Description = "Fried rice with a medley of seafood." },
            new FoodItem { Name = "Yang Chow Fried Rice", Category = "Rice", Price = 298, Image = "28_Treasures_Menu/YangChowRice.png", Description = "Classic Yang Chow fried rice with a mix of vegetables, shrimp, and pork." },
            new FoodItem { Name = "Beef Fried Rice", Category = "Rice", Price = 288, Image = "28_Treasures_Menu/default.jpg", Description = "Fried rice with savory beef pieces." },
            new FoodItem { Name = "Garlic Fried Rice", Category = "Rice", Price = 198, Image = "28_Treasures_Menu/default.jpg", Description = "Simple fried rice with aromatic garlic flavor." },
            new FoodItem { Name = "Plain Rice", Category = "Rice", Price = 70, Image = "28_Treasures_Menu/default.jpg", Description = "Steamed white rice, a perfect complement to any dish." },

            // VEGETABLES
            new FoodItem { Name = "Saute Mixed Vegetables", Category = "Vegetables", Price = 298, Image = "28_Treasures_Menu/default.jpg", Description = "A mix of fresh vegetables sautéed to perfection." },
            new FoodItem { Name = "Lohanchay", Category = "Vegetables", Price = 348, Image = "28_Treasures_Menu/default.jpg", Description = "A traditional vegetarian dish with various stir-fried vegetables." },
            new FoodItem { Name = "Polonchai with 3 Kinds Egg", Category = "Vegetables", Price = 348, Image = "28_Treasures_Menu/default.jpg", Description = "Stir-fried polonchai with three different types of eggs." },
            new FoodItem { Name = "Chop Suey", Category = "Vegetables", Price = 368, Image = "28_Treasures_Menu/Chopsuey.png", Description = "A delicious mixed vegetable stir-fry with a savory sauce." },
            new FoodItem { Name = "Salted Egg French Beans (New!)", Category = "Vegetables", Price = 328, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy French beans with salted egg and a burst of flavor." },

            // BEEF
            new FoodItem { Name = "Beef Broccoli with Oyster Sauce", Category = "Beef", Price = 398, Image = "28_Treasures_Menu/Beef_Brocolli.png", Description = "Tender beef stir-fried with broccoli in a rich oyster sauce." },
            new FoodItem { Name = "Sliced Tender Beef with A1 Sauce", Category = "Beef", Price = 398, Image = "28_Treasures_Menu/default.jpg", Description = "Sliced tender beef served with a tangy A1 sauce." },
            new FoodItem { Name = "Sliced Tender Beef with Black Pepper Sauce", Category = "Beef", Price = 398, Image = "28_Treasures_Menu/default.jpg", Description = "Tender beef slices cooked in a bold black pepper sauce." },
            new FoodItem { Name = "Beef Brisket with Radish", Category = "Beef", Price = 398, Image = "28_Treasures_Menu/default.jpg", Description = "Slow-cooked beef brisket with radish in a savory broth." },

            // PORK
            new FoodItem { Name = "Sweet and Sour Pork", Category = "Pork", Price = 388, Image = "28_Treasures_Menu/SweetandSourPork.png", Description = "Crispy pork in a tangy and sweet sauce." },
            new FoodItem { Name = "Salt and Pepper Spareribs", Category = "Pork", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Spareribs seasoned with salt and pepper for a flavorful dish." },
            new FoodItem { Name = "Kingdao Spareribs Wasabe Sauce", Category = "Pork", Price = 368, Image = "28_Treasures_Menu/default.jpg", Description = "Spareribs cooked with a spicy wasabi sauce for an extra kick." },
            new FoodItem { Name = "Mapo Tofu", Category = "Pork", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Spicy and savory mapo tofu with minced pork." },
            new FoodItem { Name = "Chopped Pork with French Beans", Category = "Pork", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Tender pork stir-fried with crunchy French beans." },
            new FoodItem { Name = "Lechon Tofu (New!)", Category = "Pork", Price = 428, Image = "28_Treasures_Menu/default.jpg", Description = "A crispy lechon-style tofu with flavorful seasoning." },

            // CHICKEN
            new FoodItem { Name = "Kung Pao Chicken", Category = "Chicken", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Spicy and savory kung pao chicken with peanuts and vegetables." },
            new FoodItem { Name = "Salted Egg Chicken", Category = "Chicken", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy chicken coated with a rich salted egg sauce." },
            new FoodItem { Name = "Lemon Chicken", Category = "Chicken", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Tangy lemon sauce served with tender chicken." },
            new FoodItem { Name = "Salt & Pepper Chicken", Category = "Chicken", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy chicken seasoned with salt and pepper." },
            new FoodItem { Name = "Butter Garlic Chicken", Category = "Chicken", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Succulent chicken cooked with a rich butter garlic sauce." },

            // Seafood
            new FoodItem { Name = "Hot Shrimp Salad", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "A fresh and spicy shrimp salad with vibrant vegetables and a tangy dressing." },
            new FoodItem { Name = "Honey Walnut Shrimp (New!)", Category = "Seafood", Price = 488, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy shrimp coated in a rich honey sauce and topped with crunchy walnuts." },
            new FoodItem { Name = "Emperor’s Shrimp (New!)", Category = "Seafood", Price = 488, Image = "28_Treasures_Menu/default.jpg", Description = "Delicious shrimp cooked to perfection in a luxurious sauce fit for royalty." },
            new FoodItem { Name = "Shrimp Vegetable with Oyster Sauce", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Shrimp stir-fried with fresh vegetables and a savory oyster sauce." },
            new FoodItem { Name = "Shrimp Suahe in Golden Sauce", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Juicy shrimp cooked in a rich and flavorful golden sauce, a treat for the taste buds." },
            new FoodItem { Name = "Salt and Pepper Shrimp Suahe", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Tender shrimp coated in a zesty salt and pepper seasoning for an irresistible taste." },
            new FoodItem { Name = "Sweet and Sour Fish Fillet", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy fish fillets served with a tangy and sweet sauce, perfect balance of flavors." },
            new FoodItem { Name = "Fish Fillet Beancurd and Black Bean", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Fish fillets cooked with tofu and a savory black bean sauce, a classic pairing." },
            new FoodItem { Name = "Szechuan Fish Fillet (New!)", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Spicy Szechuan-style fish fillets, cooked with bold and aromatic spices." },
            new FoodItem { Name = "Steamed Fish Fillet with Garlic", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Delicate fish fillets steamed with garlic for a fragrant and savory dish." },
            new FoodItem { Name = "Fish Fillet Thai Mango Sauce", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Fish fillets served with a refreshing and tangy Thai mango sauce." },
            new FoodItem { Name = "Oyster X.O.", Category = "Seafood", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Oysters cooked with a flavorful X.O. sauce, offering a rich and spicy taste." },
            new FoodItem { Name = "Oyster Black Bean Sauce", Category = "Seafood", Price = 388, Image = "28_Treasures_Menu/default.jpg", Description = "Oysters served in a savory black bean sauce, combining briny and bold flavors." },
            new FoodItem { Name = "Malaysian Sauce Squid", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Squid cooked in a fragrant and aromatic Malaysian sauce for a unique twist." },
            new FoodItem { Name = "Salt and Pepper Squid", Category = "Seafood", Price = 458, Image = "28_Treasures_Menu/default.jpg", Description = "Crispy squid seasoned with salt and pepper, a crispy, savory delight." },

            // Drinks
            new FoodItem { Name = "Mango Shake", Category = "Drinks", Price = 100, Image = "28_Treasures_Menu/MangoGraham.png", Description = "A refreshing mango shake made with ripe mangoes and creamy milk." },
            new FoodItem { Name = "Lemonade", Category = "Drinks", Price = 100, Image = "28_Treasures_Menu/Lemonade.png", Description = "A tangy and sweet lemonade, perfect for a hot day." },
            new FoodItem { Name = "Pineapple Juice", Category = "Drinks", Price = 100, Image = "28_Treasures_Menu/PineappleJuice.png", Description = "Fresh pineapple juice, a tropical and refreshing drink." },
            new FoodItem { Name = "Coke", Category = "Drinks", Price = 80, Image = "28_Treasures_Menu/Coke.png", Description = "The classic Coke, fizzy and refreshing." },
            new FoodItem { Name = "Coke Zero", Category = "Drinks", Price = 80, Image = "28_Treasures_Menu/CokeZero.png", Description = "Coke Zero, the sugar-free version of your favorite cola." },
            new FoodItem { Name = "Coke Light", Category = "Drinks", Price = 80, Image = "28_Treasures_Menu/CokeLight.png", Description = "Coke Light, a lighter version of the classic Coke with fewer calories." },
            new FoodItem { Name = "Fanta", Category = "Drinks", Price = 80, Image = "28_Treasures_Menu/Fanta.png", Description = "Orange-flavored Fanta, a sweet and tangy soda." },
            new FoodItem { Name = "Sprite", Category = "Drinks", Price = 80, Image = "28_Treasures_Menu/Sprite.png", Description = "Sprite, a crisp lemon-lime soda for a refreshing experience." },
            new FoodItem { Name = "Sola Iced Tea", Category = "Drinks", Price = 80, Image = "28_Treasures_Menu/Sola.png", Description = "Chilled Sola Iced Tea, a perfect blend of tea and sweetness." },
            new FoodItem { Name = "San Miguel Beer Light", Category = "Drinks", Price = 100, Image = "28_Treasures_Menu/SanMigLight.png", Description = "San Miguel Beer Light, a crisp and smooth light beer." },
            new FoodItem { Name = "San Miguel Beer Pale", Category = "Drinks", Price = 100, Image = "28_Treasures_Menu/SanMigPale.png", Description = "San Miguel Pale Pilsen, a classic beer with a rich flavor." },
            new FoodItem { Name = "Tsing Tao Beer", Category = "Drinks", Price = 100, Image = "28_Treasures_Menu/TsingTao.png", Description = "Tsing Tao, a refreshing Chinese lager with a balanced taste." },
            new FoodItem { Name = "Arabica Coffee in French Press", Category = "Drinks", Price = 90, Image = "28_Treasures_Menu/ArabicaCoffee.png", Description = "Rich Arabica coffee brewed using a French press for a bold and aromatic flavor." },
            new FoodItem { Name = "Bottled Water", Category = "Drinks", Price = 60, Image = "28_Treasures_Menu/Water.png", Description = "Bottled water, a simple and refreshing drink to quench your thirst." }
            };
        }
        // Static variable to hold the selected food item
        public static FoodItem SelectedFoodItem { get; set; }

        // Static variable to manage the quantity
        public static int Quantity { get; set; } = 1;

        // Methods to handle quantity adjustments
        public static void DecreaseQuantity()
        {
            if (Quantity > 1)
            {
                Quantity--;
            }
        }

        public static void IncreaseQuantity()
        {
            Quantity++;
        }
    }

}
