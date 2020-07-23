using System;
using Victory.Core.Models;

namespace Victory.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PageModel page = new PageModel();

            page.PageSize = 10;
            page.TotalCount = 101;


            Console.WriteLine("Hello World!"+ page.ToTalPage);
        }
    }
}
