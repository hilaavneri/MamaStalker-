using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MamasStalker.SendRecv
{
    public class TcpListenerSendRecv : ISendRecv
    {
        private NetworkStream _stream;

        public TcpListenerSendRecv(NetworkStream stream)
        {
            _stream = stream;
        }

        public void CloseConnection()
        {
            _stream.Close();
        }

        public Tuple<int,byte[]> ReadData()
        {
            byte[] bytes = new byte[1024];
            int bytesRec = _stream.Read(bytes, 0, bytes.Length);
            return new Tuple<int, byte[]>(bytesRec,bytes);
        }

        public void WriteData(byte[] data)
        {
            _stream.Write(data, 0, data.Length);
        }
    }
}
