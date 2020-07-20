using System;
using System.Collections.Generic;
using System.Text;

namespace Victory.Core.Extensions
{
   public static class ObjectExtensions
    {

        /// <summary>
        /// 转换为以属性分行的字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToLineText(this object obj)
        {
            Type t = obj.GetType();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(t.FullName);
            var properties = t.GetProperties();
            foreach (var item in properties)
            {
                sb.AppendLine($"[{item.Name.PadRight(20, (Char)0x20)}]{item.GetValue(obj, null)}");
            }
            return sb.ToString();
        }
    }
}
