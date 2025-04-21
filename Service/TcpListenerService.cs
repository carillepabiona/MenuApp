using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Service
{
    public class TcpListenerService
    {
        private readonly DatabaseService _db;
        private TcpListener _listener;
        private readonly int _port = 5000;

        public TcpListenerService(DatabaseService db)
        {
            _db = db;
        }

        public async Task StartListeningAsync()
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();

            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                _ = Task.Run(() => HandleClient(client));
            }
        }

        private async Task HandleClient(TcpClient client)
        {
            using var stream = client.GetStream();
            using var reader = new StreamReader(stream);

            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                // Format: orderId|status
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    if (int.TryParse(parts[0], out int orderId))
                    {
                        string newStatus = parts[1];
                        await _db.UpdateOrderStatusAsync(orderId, newStatus);
                    }
                }
            }
        }


    }
}
