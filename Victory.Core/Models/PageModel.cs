using System;
using System.Collections.Generic;
using System.Text;

namespace Victory.Core.Models
{
    public class PageModel
    {

        /// <summary>
        /// 当前第几页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        public int PageSize { get; set; }
        
        /// <summary>
        /// 总共多少条数据
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 总共多少页
        /// </summary>
        public int ToTalPage { get { return TotalCount % PageSize == 0 ? TotalCount / PageSize : TotalCount / PageSize + 1; }  }

    }
}
