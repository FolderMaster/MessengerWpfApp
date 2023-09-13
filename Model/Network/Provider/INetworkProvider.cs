using System.Net;

namespace Model.Network.Provider
{
    public interface INetworkProvider
    {
        public void Connect(IPEndPoint ipEndPoint);

        public void Close();

        public Task SendData(byte[] data);

        public Task<byte[]> ReceiveData();
    }
}