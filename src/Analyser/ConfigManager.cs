using System;
using System.Configuration;
using System.IO;

namespace JiebaNet.Analyser
{
    public class ConfigManager
    {
        // TODO: duplicate codes.
        /// <summary>
        /// 获取当前应用程序根目录
        /// </summary>
        /// <returns></returns>
        public static string GetBasePath()
        {
            if (System.Web.HttpContext.Current == null) return AppDomain.CurrentDomain.BaseDirectory;
            else return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
        }
        /// <summary>
        /// 资源文件默认路径
        /// </summary>
        public static string DefaultPath
        {
            get { return Path.Combine(GetBasePath(), "Resources"); }
        }
        public static string ConfigFileBaseDir
        {
            get
            {
                return ConfigurationManager.AppSettings["JiebaConfigFileDir"] ?? DefaultPath;
            }
        }

        public static string IdfFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "idf.txt"); }
        }

        public static string StopWordsFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "stopwords.txt"); }
        }
    }
}