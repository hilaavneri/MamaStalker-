using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MamasStalker.SendRecv
{
    public interface ISendRecv
    {
        
        Tuple<int,byte[]> ReadData();
        void WriteData(byte[] data);
        void CloseConnection();
    }
}
