using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoControls
{
    public class UdpHelper
    {
        private readonly UdpClient _udpClient;
        private readonly IPEndPoint _ipEndPoint;

        public UdpHelper(string ipAddress, int port)
        {
            _udpClient = new UdpClient();
            _ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port); 
        }

        public async Task SendAsync(string data)
        {
            string dataToSend = data.ToString();
            byte[] bytesToSend = Encoding.UTF8.GetBytes(dataToSend);
            await _udpClient.SendAsync(bytesToSend, bytesToSend.Length, _ipEndPoint);
        }

        public void Dispose()
        {
            _udpClient?.Dispose();
        }
    }
}
