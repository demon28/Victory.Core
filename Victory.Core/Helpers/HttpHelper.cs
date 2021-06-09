using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Victory.Core.Helpers
{
   public class HttpHelper
    {

        /// <summary>
        /// HttpPost
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="json">请求json</param>
        /// <returns></returns>
        public static string Post(string url, string json)
        {
            HttpContent content = new StringContent(json, Encoding.UTF8);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.86 Safari/537.36");
            HttpResponseMessage htttpResponse = httpClient.PostAsync(url, content).Result;
            var json_result = htttpResponse.Content.ReadAsStringAsync().Result;
            return json_result;
        }


        /// <summary>
        /// HttpGet
        /// </summary>
        /// <param name="url">url</param>
        /// <returns></returns>
        public static string Get(string url)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.86 Safari/537.36");
            HttpResponseMessage data = httpClient.GetAsync(url).Result;
            var json_result = data.Content.ReadAsStringAsync().Result;
            return json_result;
        }



        /// <summary>
        /// HttpGet
        /// </summary>
        /// <param name="url">url</param>
        /// <returns></returns>
        public static string Get(string url, Dictionary<string, string> headers)
        {
            HttpClient httpClient = new HttpClient();
            foreach (var item in headers)
            {
                httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
            }
            HttpResponseMessage data = httpClient.GetAsync(url).Result;
            var json_result = data.Content.ReadAsStringAsync().Result;
            return json_result;
        }


        /// <summary>
        /// Post 自定义请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="json">请求内容</param>
        /// <param name="type">请求类型</param>
        /// <param name="headers">请求头</param>
        /// <returns></returns>c
        public static string Post(string url, string json,string type,Dictionary<string,string> headers)
        {
            HttpContent content = new StringContent(json, Encoding.UTF8);
            content.Headers.ContentType = new MediaTypeHeaderValue(type);
            var httpClient = new HttpClient();

            foreach (var item in headers)
            {
                httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
            }

            HttpResponseMessage htttpResponse = httpClient.PostAsync(url, content).Result;
            var json_result = htttpResponse.Content.ReadAsStringAsync().Result;
            return json_result;
        }


    }
}
