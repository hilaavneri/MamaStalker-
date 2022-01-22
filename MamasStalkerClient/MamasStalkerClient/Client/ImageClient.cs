using MamasStalker.Common;
using MamasStalkerClient.SendRecv;
using System;

namespace MamasStalkerClient.Client
{
    class ImageClient : ClientBase
    {
        private IDataHandler _dataHandler;

        public ImageClient(ISendRecv sendRecv, IDataHandler dataHandler) : base(sendRecv)
        {
            _dataHandler = dataHandler;
        }

        public override void Run()
        {
            SendRecv.StartConnection();
            try
            {
                while (true)
                {

                    (int byteRec, byte[] bytes) = SendRecv.ReadData();
                    _dataHandler.HandleData(byteRec, bytes);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                SendRecv.CloseConnection();
            }

        }
    }
}
