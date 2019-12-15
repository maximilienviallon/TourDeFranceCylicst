using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NNTPProject
{
    class SocketServer
    {
        private int servPort = 119;

        TcpListener listener;

        public void Connection()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, servPort);
                listener.Start();
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.Message);
                Environment.Exit(se.ErrorCode);
            }
            Console.WriteLine("Waiting for connections....");
        }


    }
}