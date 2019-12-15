using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace postingArticlesNNTP
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "news.dotsrc.org"; // "time.nrc.ca";  // 
            int port = 119; // 37

            TcpClient socket = new TcpClient();

            NetworkStream ns = null;
            StreamReader reader = null;
            StreamWriter writer = null;
            // (0) Check the ip via DNS first
            IPAddress ip = Dns.GetHostEntry(url).AddressList[0];
            IPEndPoint endpoint = new IPEndPoint(ip, port);

            // (1) This blocks until connection is reached or fails 
            socket.Connect(endpoint);

            // (2) Get the streams
            ns = socket.GetStream();    

            Console.WriteLine("Connected to remote server, the stream is ready");

            // (3) Communicate (write and read) messages to/from the stream 

            // int timeout = ns.ReadTimeout;

            // Console.WriteLine("readTimeout = "+timeout);


            // b) Read from the server
            reader = new StreamReader(ns, Encoding.UTF8);
            writer = new StreamWriter(ns, Encoding.UTF8);
            string data = " ";
            string emptyCommand = "";
            string username = "authinfo user maximilien.viallon@gmail.com";
            string password = "authinfo pass dbed50";
            string command = "post";
            string from = "from: maximilien.viallon@gmail.com\r\nnewsGroups: dk.test\r\nsubject: testmax2\r\n\r\nmaximilienviallon\r\n.";

            writer.WriteLine(emptyCommand);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Flush();
            writer.WriteLine(command);
            writer.WriteLine(from);
            writer.Flush();
            while (true)
            {   
                data = reader.ReadLine();
                Console.WriteLine(data);
                if(data == ".")
                {
                    break;
                }
            }
           
            Console.ReadLine();

        }
    }
}
