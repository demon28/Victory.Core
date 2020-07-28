using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using Victory.Core.Helpers;

namespace Victory.Core.Filter
{
    public class GlobalExceptionFilter : IExceptionFilter
    {

        public void OnException(ExceptionContext context)
        {
            Exception ex = context.Exception;
            Log4netHelper.Error(ex.Message);//记录错误日志
            context.ExceptionHandled = true; //代表异常已经处理，不会再跳转到开发调试时的异常信息页，可以跳转到我们下面自定义的方法中。若开发过程可以将 该行注释掉，则直接抛出异常调试

            //通过HTTP请求头来判断是否为Ajax请求，Ajax请求的request headers里都会有一个key为x-requested-with，值“XMLHttpRequest”
            var requestData = context.HttpContext.Request.Headers.ContainsKey("x-requested-with");
            bool IsAjax = false;
            if (requestData)
            {
                IsAjax = context.HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest" ? true : false;
            }
            if (!IsAjax)//不是异步请求则跳转页面，异步请求则返回json
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Home",
                    action = "Error"
                }));

            }
            else
            {
                context.Result = new JsonResult(new { Success = false, Code = 405, Message = "您没有该功能操作权限！" });
            }
        }

    }


}
