using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;

namespace Victory.Core.Controller
{
    public class TopControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>
        /// 不打nonaction 会被当成Action，在Swagger的时候会报错 
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>

        [NonAction]
        public JsonResult FailMessage(string msg = "失败")
        {
            return Json(new { Success = false, Code = 0, Message = msg });
        }
        [NonAction]
        public JsonResult SuccessMessage(string msg = "成功")
        {
            return Json(new { Success = true, Code = 1, Message = msg });
        }

        [NonAction]
        public JsonResult SuccessResult<T>(T t, string msg = "成功")
        {

            return Json(new { Success = true, Code = 1, Message = msg, Content = t });

        }
        [NonAction]
        public JsonResult SuccessResultList<T>(List<T> list, Models.PageModel page, string msg = "成功")
        {
            
            return Json(new { Success = true, Code = 1, Message = msg, PageIndex = page.PageIndex, PageSize = page.PageSize, TotalCount = page.TotalCount, TotalPage = page.ToTalPage, Content = list });
        }

        [NonAction]
        public JsonResult SuccessResultList<T>(List<T> list, string msg = "成功")
        {

            return Json(new { Success = true, Code = 1, Message = msg, Content = list });
        }



    }
}
