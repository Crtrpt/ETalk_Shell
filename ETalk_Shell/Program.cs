using System;
using ETalk_Shell.shell.user;

namespace ETalk_Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseArgs(args);
        }

        static void ParseArgs(string[] args)
        {
            try
            {
                if (args[0] == "-h" || args[0] == "--help" || args[0] == "h")
                {
                    Help();
                }
                User user=new User();
                switch (args[0])
                {
                        case "login":
                            user.Login(args[2],args[4]);
                            break;
                        default:
                            Help();
                            break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Help();
            }
        }

        static void Help()
        {
            Console.Write(@"
Usage: et [COMMAND]... [OPTION]...

 login 
    -u     --username     login username
    -p     --password     login password
 group 
    -l  --List          get group list

 exit                 logout Et network
  
 -v --Version  output version information and exit
 

Examples:
et login 
            ");
            Environment.Exit(0);
        }
    }
}