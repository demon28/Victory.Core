
using System;
using System.IO;
using Victory.Core.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Binder;
using Newtonsoft.Json;

namespace Victory.Core.Helpers
{
    // <summary>
    /// 配置帮助类
    /// </summary>
    public class ConfigHelper
    {
        private static IConfiguration _configuration;

        static ConfigHelper()
        {
            BuildConfiguration();
        }

        private static void BuildConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false).AddJsonFile("appsettings.Development.json", true);
            _configuration = builder.Build();
        }

        /// <summary>
        /// 读取指定节点信息
        /// </summary>
        /// <param name="key">节点名称，多节点以:分隔</param>
        public static string Get(string key)
        {
            return _configuration[key];
        }

        /// <summary>
        /// 读取指定节点信息
        /// </summary>
        public static T Get<T>(string key)
        {
            string json = Get(key);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
