
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

        public ConfigHelper(string filename)
        {
            BuildConfiguration(filename);
        }

        private void BuildConfiguration(string filename)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(filename);
            _configuration = builder.Build();
        }

        /// <summary>
        /// 读取指定节点信息
        /// </summary>
        /// <param name="key">节点名称，多节点以:分隔</param>
        public string GetSingle(string key)
        {
            return _configuration.GetSection(key).Value;
        }

        /// <summary>
        /// 读取指定节点信息
        /// </summary>
        public T Get<T>(string key)
        {
            return _configuration.GetSection(key).Get<T>();

        }
    }
}
