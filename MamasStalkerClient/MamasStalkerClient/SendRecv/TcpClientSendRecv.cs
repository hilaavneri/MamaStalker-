using System;
using System.Net.Sockets;

namespace MamasStalkerClient.SendRecv
{
    class TcpClientSendRecv : ISendRecv
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private string _ip;
        private int _port;

        public TcpClientSendRecv(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public void CloseConnection()
        {
            _stream.Close();
        }

        public (int, byte[]) ReadData()
        {
            byte[] bytes = new byte[1024000];
            int bytesRec = _stream.Read(bytes, 0, bytes.Length);
            return (bytesRec, bytes);
        }

        public void StartConnection()
        {
            try

            {
                _client = new TcpClient(_ip, _port);
                _stream = _client.GetStream();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void WriteData(byte[] data)
        {
            _stream.Write(data, 0, data.Length);
        }
    }
}
