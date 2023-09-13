using System.Net.Sockets;
using System.Net;

namespace Model.Network.Provider
{
    public class UdpNetworkProvider : INetworkProvider
    {
        private UdpClient _client = new();

        public void Connect(IPEndPoint ipEndPoint) => _client.Connect(ipEndPoint);

        public void Close() => _client.Close();

        public async Task SendData(byte[] data) => await _client.SendAsync(data);

        public async Task<byte[]> ReceiveData() => _client.ReceiveAsync().Result.Buffer;
    }
}