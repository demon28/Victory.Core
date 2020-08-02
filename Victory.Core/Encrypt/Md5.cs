using System;
using System.Collections.Generic;
using System.Text;
using Victory.Core.Extensions;
using System.Security.Cryptography;
using Victory.Core.Helpers;

namespace Victory.Core.Encrypt
{

    /// <summary>
    /// MD5加密
    /// </summary>
    public class Md5
    {
        /// <summary>
        /// 16位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Encrypt16(string password)
        {
            if (password.IsNull())
                return null;

            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(password)).ToHex();
            }
        }

        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Encrypt32(string password)
        {
            if (password.IsNull())
                return null;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            string result = BitConverter.ToString(md5.ComputeHash(bytes));
            return result.Replace("-", "");
        }

        /// <summary>
        /// 64位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Encrypt64(string password)
        {
            if (password.IsNull())
                return null;

            using (var md5 = MD5.Create())
            {
                byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                return s.ToBase64();
            }
        }
    }



}
