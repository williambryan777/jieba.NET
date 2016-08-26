using System;
using System.Configuration;
using System.IO;

namespace JiebaNet.Segmenter
{
    public class ConfigManager
    {
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

        public static string MainDictFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "dict.txt"); }
        }

        public static string ProbTransFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "prob_trans.json"); }
        }

        public static string ProbEmitFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "prob_emit.json"); }
        }

        public static string PosProbStartFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "pos_prob_start.json"); }
        }

        public static string PosProbTransFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "pos_prob_trans.json"); }
        }

        public static string PosProbEmitFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "pos_prob_emit.json"); }
        }

        public static string CharStateTabFile
        {
            get { return Path.Combine(ConfigFileBaseDir, "char_state_tab.json"); }
        }
    }
}