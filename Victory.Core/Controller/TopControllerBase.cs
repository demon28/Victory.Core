using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;

namespace Victory.Core.Controller
{
    public class TopControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {


        public JsonResult FailMessage(string msg = "失败")
        {
            return Json(new { Success = false, Code = 0, Message = msg });
        }

        public JsonResult SuccessMessage(string msg = "成功")
        {
            return Json(new { Success = true, Code = 1, Message = msg });
        }


        public JsonResult SuccessResult<T>(T t, string msg = "成功")
        {

            return Json(new { Success = true, Code = 1, Message = msg, Content = t });

        }

        public JsonResult SuccessResultList<T>(List<T> list, Models.PageModel page, string msg = "成功")
        {
            
            return Json(new { Success = true, Code = 1, Message = msg, PageIndex = page.PageIndex, PageSize = page.PageSize, TotalCount = page.TotalCount, TotalPage = page.ToTalPage, Content = list });
        }


        public JsonResult SuccessResultList<T>(List<T> list, string msg = "成功")
        {

            return Json(new { Success = true, Code = 1, Message = msg, Content = list });
        }



    }
}
