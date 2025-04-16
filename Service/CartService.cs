using System;
using System.Collections.Generic;
using System.Linq;
using MenuApp.Models;

namespace MenuApp.Models
{
    /// <summary>
    /// Service to manage the cart state across the app.
    /// </summary>
    public class CartService
    {
        public event Action? OnChange;

        /// <summary>
        /// The internal list of items in the cart.
        /// </summary>
        public List<CartItem> CartItems { get; private set; } = new();

        /// <summary>
        /// Adds a food item to the cart or increases quantity if already present.
        /// </summary>
        public void AddToCart(FoodItem item)
        {
            var existing = CartItems.FirstOrDefault(c => c.Name == item.Name);
            if (existing != null)
            {
                existing.Quantity++;
            }
            else
            {
                CartItems.Add(new CartItem
                {
                    Name = item.Name,
                    Image = item.Image,
                    Price = item.Price,
                    Quantity = 1
                });
            }

            NotifyStateChanged();
        }

        /// <summary>
        /// Increases the quantity of a cart item.
        /// </summary>
        public void IncreaseQuantity(CartItem cartItem)
        {
            cartItem.Quantity++;
            NotifyStateChanged();
        }

        /// <summary>
        /// Decreases the quantity of a cart item, or removes it if quantity becomes zero.
        /// </summary>
        public void DecreaseQuantity(CartItem cartItem)
        {
            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
            }
            else
            {
                CartItems.Remove(cartItem);
            }

            NotifyStateChanged();
        }

        /// <summary>
        /// Removes a specific item from the cart.
        /// </summary>
        public void RemoveItem(CartItem cartItem)
        {
            CartItems.Remove(cartItem);
            NotifyStateChanged();
        }

        /// <summary>
        /// Gets the total count of items in the cart (summing quantities).
        /// </summary>
        public int GetCartCount() => CartItems.Sum(ci => ci.Quantity);

        /// <summary>
        /// Clears the cart entirely.
        /// </summary>
        public void ClearCart()
        {
            CartItems.Clear();
            NotifyStateChanged();
        }

        /// <summary>
        /// Triggers a UI refresh by notifying subscribers.
        /// </summary>
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
