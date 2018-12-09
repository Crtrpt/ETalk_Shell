using System;
using System.IO;
using System.Resources;
using ETalk_Shell.shell.user;
using ETalk_Shell.utils;
using IniParser.Model;

namespace ETalk_Shell.core
{
    public class Ctx
    {
        static Ctx ctx = new Ctx();
        private static IniData config = null;
        public User User { get; set; }

        public static  Ctx Init()
        {
            ctx=new Ctx();
            ctx.InitDefaultSetting();
            ctx.InitLanguage();
            ctx.InitUser();
            return ctx;
        }


        void InitCombined()
        {
            InitLanguage();
        }
        /**
         * 初始化用户信息
         */
        void InitUser()
        {
            User=new User();
        }
        /**
         * 加载配置文件
         */
        void InitDefaultSetting()
        {
            config= FileUtil.LoadIni("config/main.ini");
            Console.WriteLine(config["main"]["version"].ToString());
            Console.WriteLine("init default setting");
        }
        /**
         * 初始化语言
         */
        void InitLanguage()
        {
            Console.WriteLine("init language setting");
        }
        /**
         * 重新加载语言
         */
        void ReloadLanguage()
        {
            Console.WriteLine("init language setting");
        }

        void ReloadConfig()
        {
            Console.WriteLine("重新加载配置");
        }
    }
}