using System;

namespace ETalk_Shell.shell.user
{
    public class User
    {
        public void Login(string username,string password)
        {
            Console.WriteLine("username {0:G} password **",username);
        }
    }
}