using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Victory.Core.Enums
{

    /// <summary>
    /// 状态码枚举
    /// </summary>
    public enum HttpStatusCode
    {
        /// <summary>
        /// 操作失败
        /// </summary>
        [Description("操作失败")]
        操作失败 = 0,

        /// <summary>
        /// 操作成功
        /// </summary>
        [Description("操作成功")]
        操作成功 = 1,


        /// <summary>
        ///请求错误
        /// </summary>
        [Description("请求错误")]
        请求错误 = 400,

        /// <summary>
        /// 未登录（需要重新登录）
        /// </summary>
        [Description("未登录")]
        未登录 = 401,

        /// <summary>
        /// 请求超过时间范围
        /// </summary>
        [Description("请求超过时间范围")]
        请求超过时间范围 = 402,

        /// <summary>
        /// 权限不足
        /// </summary>
        [Description("权限不足")]
        权限不足 = 403,

        /// <summary>
        /// 资源不存在
        /// </summary>
        [Description("资源不存在")]
        资源不存在 = 404,

        /// <summary>
        /// 签名错误
        /// </summary>
        [Description("签名错误")]
        签名错误 = 417,

        /// <summary>
        /// 系统内部错误（非业务代码里显式抛出的异常，例如由于数据不正确导致空指针异常、数据库异常等等）
        /// </summary>
        [Description("系统内部错误")]
        系统内部错误 = 500,

        /// <summary>
        /// 服务器错误
        /// </summary>
        [Description("服务器错误")]
        服务器错误 = 503

    }
}
