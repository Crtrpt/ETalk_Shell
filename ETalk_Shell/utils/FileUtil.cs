using System.Collections.Generic;
using System.IO;
using IniParser;
using IniParser.Model;
using Newtonsoft.Json;

namespace ETalk_Shell.utils
{
    public class FileUtil
    {
       /**
        * 加载json文件
        */
       public static T LoadJson<T>(string filename)
       {
           T ret=default(T);
           using (StreamReader r = new StreamReader(filename))
           {
               string json = r.ReadToEnd();
               ret = JsonConvert.DeserializeObject<T>(json);
           }
           return ret;
       }
        
        /**
         * 加载配置文件
         */
        public static IniData LoadIni(string filename)
        {
            var parser = new FileIniDataParser();
            return parser.ReadFile(filename);
        }

    }
}