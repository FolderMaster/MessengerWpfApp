using System.Net;
using System.Net.Sockets;

namespace Model.Network.Provider
{
    public class TcpNetworkProvider : INetworkProvider
    {
        private TcpClient _client = new();

        private NetworkStream? _stream;

        public void Connect(IPEndPoint ipEndPoint)
        {
            _client.Connect(ipEndPoint);
            _stream = _client.GetStream();
        }

        public void Close() => _client.Close();

        public async Task SendData(byte[] data) => _stream?.WriteAsync(data).AsTask();

        public async Task<byte[]> ReceiveData()
        {
            var memory = new Memory<byte>();
            _stream?.ReadAsync(memory);
            return memory.ToArray();
        }
    }
}