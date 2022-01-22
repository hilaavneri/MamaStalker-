using Common;
using MamasStalker.SendRecv;
using System;
using System.Threading;

namespace MamasStalker.ClientHandlers
{
    public class ClientHandler : ClientHandlerBase
    {
        private IDataWriter _writer;
        private int _interval;

        public ClientHandler(IDataWriter writer, int interval)
        {
            _writer = writer;
            _interval = interval;
        }


        public override void HandleClient(ISendRecv sender)
        {
            Console.WriteLine("start");
            try
            {
                while (true)
                {
                    sender.WriteData(_writer.GetData());
                    Thread.Sleep(_interval);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sender.CloseConnection();
            }

        }
    }
}
