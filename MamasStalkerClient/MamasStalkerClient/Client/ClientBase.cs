using MamasStalkerClient.SendRecv;
using System;
using System.Collections.Generic;
using System.Text;

namespace MamasStalkerClient.Client
{
    public abstract class ClientBase
    {
        protected ISendRecv SendRecv;

        protected ClientBase(ISendRecv sendRecv)
        {
            SendRecv = sendRecv;
        }

        public abstract void Run();
    }
}
