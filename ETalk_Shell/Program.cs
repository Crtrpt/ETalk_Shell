using System;
using ETalk_Shell.core;

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
                
                Ctx ctx = Ctx.Init();
                ctx.User.Test();
                if (args.Length==0 || args[0] == "-h" || args[0] == "--help" || args[0] == "h")
                {
                    Help();
                }


                
/*                switch (args[0])
                {
                        case "login":
                            ctx.User.Login(args[2],args[4]);
                            break;
                        default:
                            
                            Help();
                            break;
                }*/
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                Console.WriteLine(e.Message);
                Help();
            }
        }

        static void Help()
        {
            Console.Write(@"
Usage: et [COMMAND]... [OPTION]...
 setting
    -l        --langage          set language
 login 
    -u        --username         login username
    -p        --password         login password
 group 
    -l        --List             get group list
 refresh                         reload config
 exit                            logout Et network
  
 -v --Version  output version information and exit
 

Examples:
et login 
            ");
            Environment.Exit(0);
        }
    }
}