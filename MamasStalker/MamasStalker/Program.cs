using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandleImage;
using MamasStalker.ClientHandlers;
using MamasStalker.Listener;

namespace MamasStalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = int.Parse(args[0]);
            TcpListen tl = new TcpListen(port);
            tl.Connect();
            tl.AcceptClients(new ClientHandler(new ImageWriter(), 1000));


        }
    }
}
