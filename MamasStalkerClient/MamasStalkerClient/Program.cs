using MamasStalkerClient.Client;
using MamasStalkerClient.SendRecv;
using System;
using System.Net.Sockets;
using ImageHandler;

namespace MamasStalkerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ImageClient(new TcpClientSendRecv("127.0.0.1", 5500), new ImageDataHandler());
            client.Run();
          
        }
    }
}
