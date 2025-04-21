using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Service
{
    public class TcpStatusListenerService
    {
        private TcpListener listener;
        private bool isListening = false;
        private readonly int port = 5555;

        public event Action<string, string> OnStatusUpdateReceived;

        public void StartListening()
        {
            if (isListening) return;

            isListening = true;
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            Task.Run(async () =>
            {
                while (isListening)
                {
                    try
                    {
                        var client = await listener.AcceptTcpClientAsync();
                        _ = HandleClientAsync(client);
                    }
                    catch
                    {
                        // Handle errors (e.g. logging)
                    }
                }
            });
        }

        public void StopListening()
        {
            isListening = false;
            listener?.Stop();
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            using var stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byteCount = await stream.ReadAsync(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, byteCount);

            if (message.StartsWith("status:"))
            {
                var parts = message.Split('|');
                if (parts.Length == 2)
                {
                    string status = parts[0].Replace("status:", "").Trim();
                    string tableNumber = parts[1].Trim();

                    OnStatusUpdateReceived?.Invoke(tableNumber, status);
                }
            }
        }
    }

}
