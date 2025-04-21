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

        // Cart methods
        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            await Init();
            return await _db.Table<CartItem>().ToListAsync();
        }

        public async Task<int> AddCartItemAsync(CartItem item)
        {
            await Init();
            return await _db.InsertAsync(item);
        }

        public async Task<int> RemoveCartItemAsync(int id)
        {
            await Init();
            return await _db.DeleteAsync<CartItem>(id);
        }

        public async Task<int> UpdateCartItemAsync(CartItem item)
        {
            await Init();
            return await _db.UpdateAsync(item);
        }

        public async Task ClearCartAsync()
        {
            await Init();
            await _db.DeleteAllAsync<CartItem>();
        }

        // Orders
        public async Task<List<OrderItem>> GetOrderItemsAsync()
        {
            await Init();
            return await _db.Table<OrderItem>().ToListAsync();
        }

        public async Task<int> AddOrderItemAsync(OrderItem item)
        {
            await Init();
            return await _db.InsertAsync(item);
        }

        public async Task<int> DeleteAllOrdersAsync()
        {
            await Init();
            return await _db.DeleteAllAsync<OrderItem>();
        }

        public async Task UpdateOrderStatusAsync(int orderId, string newStatus)
        {
            await Init();
            var order = await _db.Table<OrderItem>().Where(o => o.Id == orderId).FirstOrDefaultAsync();
            if (order != null)
            {
                order.Status = newStatus;
                await _db.UpdateAsync(order);
            }
        }

    }
}
