using MamasStalker.SendRecv;

namespace MamasStalker.ClientHandlers
{
    public abstract class ClientHandlerBase
    {
        public abstract void HandleClient(ISendRecv sendRecv);
    }
}
