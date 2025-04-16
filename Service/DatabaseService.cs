using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuApp.Models;

namespace MenuApp.Service
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _db;

        public async Task Init()
        {
            if (_db != null)
                return;

            // Database file path
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "menu.db");
            _db = new SQLiteAsyncConnection(dbPath);

            // Create tables if not exist
            await _db.CreateTableAsync<CartItem>();
            await _db.CreateTableAsync<OrderItem>();
        }

        // Cart methods...
        public Task<List<CartItem>> GetCartItemsAsync() => _db.Table<CartItem>().ToListAsync();
        public Task<int> AddCartItemAsync(CartItem item) => _db.InsertAsync(item);
        public Task<int> RemoveCartItemAsync(int id) => _db.DeleteAsync<CartItem>(id);
        public Task<int> UpdateCartItemAsync(CartItem item) => _db.UpdateAsync(item);
        public Task ClearCartAsync() => _db.DeleteAllAsync<CartItem>();


        // Order methods...
        public Task<List<OrderItem>> GetOrderItemsAsync() => _db.Table<OrderItem>().ToListAsync();
        public Task<int> AddOrderItemAsync(OrderItem item) => _db.InsertAsync(item);
        public Task<int> UpdateOrderStatusAsync(int id, string newStatus) =>
            _db.ExecuteAsync("UPDATE OrderItem SET Status = ? WHERE Id = ?", newStatus, id);
        public Task<int> DeleteAllOrdersAsync() => _db.DeleteAllAsync<OrderItem>();


    }
}
