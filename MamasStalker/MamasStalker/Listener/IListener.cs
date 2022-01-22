using MamasStalker.ClientHandlers;

namespace MamasStalker.Listener
{
    public interface IListener
    {
        void Connect();
        void AcceptClients(ClientHandlerBase clientHandler);
    }
}
