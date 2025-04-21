using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MenuApp.Service;
using MenuApp.Models;

namespace MenuApp.Service
{
    public class TcpOrderListenerService
    {
        private readonly DatabaseService _db;
        private TcpListener _listener;
        private bool _listening = false;

        public TcpOrderListenerService(DatabaseService db)
        {
            _db = db;
        }

        public void StartListening(int port = 5000)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            _listening = true;

            Task.Run(async () =>
            {
                while (_listening)
                {
                    TcpClient client = await _listener.AcceptTcpClientAsync();
                    _ = HandleClient(client);
                }
            });
        }

        private async Task HandleClient(TcpClient client)
        {
            using NetworkStream stream = client.GetStream();
            using StreamReader reader = new(stream, Encoding.UTF8);
            string message = await reader.ReadToEndAsync();

            if (!string.IsNullOrWhiteSpace(message))
            {
                var orders = JsonSerializer.Deserialize<List<OrderItem>>(message);
                if (orders != null)
                {
                    foreach (var order in orders)
                    {
                        await _db.UpdateOrderStatusAsync(order.Id, "preparing");
                    }
                }
            }
        }

        public void StopListening()
        {
            _listening = false;
            _listener?.Stop();
        }
    }
}
