using System;
using System.Collections.Generic;
using System.Text;

namespace MamasStalkerClient.SendRecv
{
    public interface ISendRecv
    {
        (int, byte[]) ReadData();
        void WriteData(byte[] data);
        void CloseConnection();
        void StartConnection();
    }
}
