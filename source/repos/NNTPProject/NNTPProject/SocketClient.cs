using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace NNTPProject
{
    class SocketClient
    {
        NetworkStream ns = null;
        StreamReader reader = null;
        StreamWriter sw = null;
        TcpClient socket = new TcpClient();
        IPEndPoint endpoint = null;
        IPAddress ip = null;
        public void Connect(string url, int port)
        {


            try
            {
                // (0) Check the ip via DNS first
                 ip = Dns.GetHostEntry(url).AddressList[0];
                 endpoint = new IPEndPoint(ip, port);

                // (1) This blocks until connection is reached or fails 
                socket.Connect(endpoint);

                // (2) Get the streams
                ns = socket.GetStream();

                Console.WriteLine("Connected to remote server, the stream is ready");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UserConnect(string userName, string password)
        {
            sw = new StreamWriter(ns, Encoding.UTF8);
            reader = new StreamReader(ns, Encoding.UTF8);
            string serverMessage = "";
            string starterWriting = " ";
            string username = "authinfo user " + userName;
            string passWord = "authinfo pass " + password;
            sw.WriteLine(starterWriting);
            sw.WriteLine(username);
            sw.WriteLine(passWord);
            sw.Flush();
            while(serverMessage != null)
            {
                serverMessage = reader.ReadLine();
                Console.WriteLine(serverMessage);
                if(serverMessage.Equals("281 Ok"))
                {
                    serverMessage = null;
                }    
            }
            
            
           
        }

        public List<string> GetNewsGroup()
        {   
            Connect("news.dotsrc.org", 119);
            UserConnect("maximilien.viallon@gmail.com", "dbed50");

            string getList= "list";
            string data = " ";
            sw.WriteLine(getList);
            sw.Flush();
            data = reader.ReadLine();
            Console.WriteLine(data);
            List<string> returnValue = new List<string>();
            while (data != ".")
            {

                data = reader.ReadLine();
                returnValue.Add(data);
                Console.WriteLine(data);

            }
            Console.WriteLine("potato");
            
            return returnValue;
        }
        public void GetGroup()
        {
            List<string> newsGroupList = GetNewsGroup();
            string specificNewsGroup = "group " + "alt.politics.trump";

            string data = "";
            sw.WriteLine(specificNewsGroup);

            sw.Flush();
            data = reader.ReadLine();
            Console.WriteLine(data);
            
        }

        public void GetHead()
        {
            GetGroup();
            string head = "head 89666";

            string data = "";
            sw.WriteLine(head);
            sw.Flush();
            data = reader.ReadLine();
            Console.WriteLine(data);

        }
        public List<string> GetBody()
        {
            //GetHead();
            
            string body = "body 89666";
            string data = " ";
            sw.WriteLine(body);
            sw.Flush();
            List<string> bodyList = new List<string>();
            while (data != ".") {
                data = reader.ReadLine();
                bodyList.Add(data);
                Console.WriteLine(data);
                }
            return bodyList;
            Disconnect();
        }

        public void Disconnect()
        {
            if (ns != null)
            {
                ns.Close();
            }
            if(reader != null)
            {
                reader.Close();
            }
            if(socket != null)
            {
                socket.Close();
            }
            if(sw != null)
            {
                sw.Close();
            }
        }
            
    }
}
