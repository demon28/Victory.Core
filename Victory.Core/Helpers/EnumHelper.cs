using System;
using System.Collections.Generic;
using System.Text;

namespace Victory.Core.Helpers
{
  public static  class EnumHelper
    {

        /// <summary>
        /// 枚举类型转换为字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string EnumConvertToString<T>(T en)
        {
            return Enum.GetName(en.GetType(), en);
        }
        public static T StringConvertToEnum<T>(string str)
        {
            T result = default(T);
            try
            {
                result = (T)Enum.Parse(typeof(T), str);
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
    }
}
