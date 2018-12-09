using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ETalk_Shell.shell.user
{
    public class User
    {
        public void Login(string username,string password)
        {
            Console.WriteLine("username {0:G} password **",username);

        }

        public void Test()
        {
            IPEndPoint ipEndPoint=new IPEndPoint(IPAddress.Broadcast,18080);
            var client = new UdpClient();
            client.EnableBroadcast = true;
            byte[] message = Encoding.UTF8.GetBytes("hi this is a dog");
            int send =client.Send(message,message.Length, ipEndPoint);
            Console.Write(send);
        }
    }
}